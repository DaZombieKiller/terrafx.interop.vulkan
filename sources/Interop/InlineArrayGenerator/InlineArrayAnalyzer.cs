using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;
using System.Collections.Immutable;
using System.Diagnostics;

namespace InlineArrayGenerator;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
internal sealed class InlineArrayAnalyzer : DiagnosticAnalyzer
{
    private static readonly DiagnosticDescriptor InlineArrayConversionToSpanNotSupported = new(
        "ILA0001",
        "InlineArray conversion to Span<T> not supported",
        "Cannot convert expression to 'Span<T>' because it is not an assignable variable",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InlineArrayConversionToReadOnlySpanNotSupported = new(
        "ILA0002",
        "InlineArray conversion to ReadOnlySpan<T> not supported",
        "Cannot convert expression to 'ReadOnlySpan<T>' because it may not be passed or returned by reference",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

#pragma warning disable IDE0052 // Remove unread private members
#pragma warning disable CA1823 // Avoid unused private fields
    private static readonly DiagnosticDescriptor InlineArrayIndexOutOfRange = new(
#pragma warning restore CA1823 // Avoid unused private fields
#pragma warning restore IDE0052 // Remove unread private members
        "ILA0003",
        "InlineArray index out of range",
        "Index is outside the bounds of the inline array",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InvalidInlineArrayLength = new(
        "ILA0004",
        "Invalid InlineArray length",
        "Inline array length must be greater than 0",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InvalidInlineArrayLayout = new(
        "ILA0005",
        "Invalid InlineArray layout",
        "Inline array struct must not have explicit layout",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InvalidInlineArrayFields = new(
        "ILA0006",
        "Invalid InlineArray fields",
        "Inline array struct must declare one and only one instance field which must not be a ref field",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InlineArrayBadIndex = new(
        "ILA0007",
        "InlineArray bad index",
        "Elements of an inline array type can be accessed only with a single argument implicitly convertible to int, System.Index, or System.Range",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor NamedArgumentForInlineArray = new(
        "ILA0008",
        "Named argument for InlineArray",
        "An inline array access may not have a named argument specifier",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InlineArrayUnsupportedElementFieldModifier = new(
        "ILA0009",
        "InlineArray unsupported element field modifier",
        "Inline array element field cannot be declared as required, readonly, volatile, or as a fixed size buffer",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InlineArrayForEachNotSupported = new(
        "ILA0010",
        "InlineArray foreach not supported",
        "foreach statement on an inline array of type is not supported",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    private static readonly DiagnosticDescriptor InlineArrayAttributeOnRecord = new(
        "ILA0011",
        "InlineArrayAttribute on record",
        "Attribute InlineArrayAttribute cannot be applied to a record struct",
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => [
        InlineArrayConversionToSpanNotSupported,
        InlineArrayConversionToReadOnlySpanNotSupported,
        InlineArrayBadIndex,
        InvalidInlineArrayLength,
        InvalidInlineArrayLayout,
        InvalidInlineArrayFields,
        InlineArrayBadIndex,
        NamedArgumentForInlineArray,
        InlineArrayUnsupportedElementFieldModifier,
        InlineArrayForEachNotSupported,
        InlineArrayAttributeOnRecord,
    ];

    public override void Initialize(AnalysisContext context)
    {
        if (context is not null)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.RegisterOperationAction(AnalyzeConversion, OperationKind.Conversion);
        }
    }

    private static void AnalyzeConversion(OperationAnalysisContext context)
    {
        if (context.Operation is not IConversionOperation { Conversion: { IsUserDefined: true, MethodSymbol: { } conversionMethod } } operation)
        {
            return;
        }

        if (!GeneratorHelpers.IsInlineArrayType(context.Compilation, conversionMethod.ContainingType))
        {
            return;
        }

        var spanType = context.Compilation.GetTypeByMetadataName("System.Span`1");
        var roSpanType = context.Compilation.GetTypeByMetadataName("System.ReadOnlySpan`1");
        var isConvertingToSpan = SymbolEqualityComparer.Default.Equals(operation.Type?.OriginalDefinition, spanType);
        var isConvertingToRoSpan = SymbolEqualityComparer.Default.Equals(operation.Type?.OriginalDefinition, roSpanType);

        if (!isConvertingToSpan && !isConvertingToRoSpan)
        {
            return;
        }

        var refKind = GetRefKind(operation.Operand);

        if (refKind is RefKind.None)
        {
            if (isConvertingToSpan)
            {
                context.ReportDiagnostic(Diagnostic.Create(InlineArrayConversionToSpanNotSupported, operation.Operand.Syntax.GetLocation()));
            }
            else
            {
                context.ReportDiagnostic(Diagnostic.Create(InlineArrayConversionToReadOnlySpanNotSupported, operation.Operand.Syntax.GetLocation()));
            }

            return;
        }

        if (isConvertingToSpan && refKind is RefKind.In or RefKind.RefReadOnly or RefKind.RefReadOnlyParameter)
        {
            context.ReportDiagnostic(Diagnostic.Create(InlineArrayConversionToSpanNotSupported, operation.Operand.Syntax.GetLocation()));
            return;
        }
    }

    private static RefKind GetRefKind(ISymbol referencedSymbol)
    {
        return referencedSymbol switch {
            ILocalSymbol local => local.IsRef ? local.RefKind : RefKind.Ref,
            IFieldSymbol field => field.IsReadOnly ? RefKind.RefReadOnly : RefKind.Ref,
            IPropertySymbol property => property.RefKind,
            IMethodSymbol method => method.RefKind,
            IParameterSymbol parameter => parameter.RefKind,
            _ => RefKind.None
        };
    }

    private static RefKind GetRefKind(IOperation operation)
    {
        return operation switch {
            ILocalReferenceOperation { Local: { } local } => GetRefKind(local),
            IParameterReferenceOperation { Parameter: { } param } => GetRefKind(param),
            IInvocationOperation { TargetMethod: { } method } => GetRefKind(method),
            IImplicitIndexerReferenceOperation { IndexerSymbol: { } indexer } => GetRefKind(indexer),
            IMemberReferenceOperation { Member: { } member } => GetRefKind(member),
            _ => RefKind.None
        };
    }
}

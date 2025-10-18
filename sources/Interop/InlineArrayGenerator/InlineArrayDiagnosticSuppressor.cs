using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

namespace InlineArrayGenerator;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
internal sealed class InlineArrayDiagnosticSuppressor : DiagnosticSuppressor
{
    private static readonly SuppressionDescriptor NoDefinedOrdering = new(
        id: "SP0001",
        suppressedDiagnosticId: "CS0282",
        justification: "Generated InlineArray types require fields in two partial definitions");

    private static readonly SuppressionDescriptor MakeFieldReadonly = new(
        id: "SP0002",
        suppressedDiagnosticId: "IDE0044",
        justification: "InlineArray fields should not be readonly");

    public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions => [
        NoDefinedOrdering,
        MakeFieldReadonly
    ];

    public override void ReportSuppressions(SuppressionAnalysisContext context)
    {
        foreach (var diagnostic in context.ReportedDiagnostics)
        {
            var symbol = GetSymbol(context, diagnostic);

            if (symbol is null)
            {
                continue;
            }

            if (diagnostic.Id == NoDefinedOrdering.SuppressedDiagnosticId)
            {
                HandleCS0282(context, diagnostic, symbol);
            }
            else if (diagnostic.Id == MakeFieldReadonly.SuppressedDiagnosticId)
            {
                HandleIDE0044(context, diagnostic, symbol);
            }
        }
    }

    private static void HandleIDE0044(SuppressionAnalysisContext context, Diagnostic diagnostic, ISymbol symbol)
    {
        if (symbol is IFieldSymbol && GeneratorHelpers.IsInlineArrayType(context.Compilation, symbol.ContainingType))
        {
            context.ReportSuppression(Suppression.Create(MakeFieldReadonly, diagnostic));
        }
    }

    private static void HandleCS0282(SuppressionAnalysisContext context, Diagnostic diagnostic, ISymbol symbol)
    {
        if (GeneratorHelpers.IsInlineArrayType(context.Compilation, symbol))
        {
            context.ReportSuppression(Suppression.Create(NoDefinedOrdering, diagnostic));
        }
    }

    private static ISymbol? GetSymbol(SuppressionAnalysisContext context, Diagnostic diagnostic)
    {
        if (diagnostic.Location is not { SourceSpan: { } span, SourceTree: { } sourceTree })
        {
            return null;
        }

        var node = sourceTree.GetRoot(context.CancellationToken).FindNode(span);
        var model = context.GetSemanticModel(sourceTree);
        return model.GetDeclaredSymbol(node, context.CancellationToken);
    }
}

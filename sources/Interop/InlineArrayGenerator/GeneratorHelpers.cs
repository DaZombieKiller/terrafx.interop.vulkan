using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;

namespace InlineArrayGenerator;

internal static class GeneratorHelpers
{
    public static UTF8Encoding Utf8NoBom { get; } = new(encoderShouldEmitUTF8Identifier: false);

    public const string AttributeNamespace = "TerraFX.Interop";

    public const string AttributeName = "InlineArrayAttribute";

    public const string AttributeMetadataName = $"{AttributeNamespace}.{AttributeName}";

    public static SymbolDisplayFormat QualifiedNameArityFormat { get; } = (SymbolDisplayFormat)typeof(SymbolDisplayFormat)
        .GetField(nameof(QualifiedNameArityFormat), BindingFlags.Static | BindingFlags.NonPublic)
        .GetValue(null);

    public static bool IsInlineArrayType(Compilation compilation, ISymbol symbol)
    {
        var inlineArrayAttribute = compilation.GetTypeByMetadataName(AttributeMetadataName);

        if (inlineArrayAttribute == null)
        {
            return false;
        }

        foreach (var attribute in symbol.GetAttributes())
        {
            if (SymbolEqualityComparer.Default.Equals(attribute.AttributeClass, inlineArrayAttribute))
            {
                return true;
            }
        }

        return false;
    }
}

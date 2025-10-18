using Microsoft.CodeAnalysis;

namespace InlineArrayGenerator;

internal sealed record TypeRecord(
    TypeRecord? ContainingType,
    TypeKind TypeKind,
    string FullyQualifiedMetadataName,
    string FullyQualifiedName,
    string? ContainingNamespace,
    string Name)
{
    public TypeRecord(ITypeSymbol type) : this(
        type.ContainingType != null ? new TypeRecord(type.ContainingType) : null,
        type.TypeKind,
        type.ToDisplayString(GeneratorHelpers.QualifiedNameArityFormat),
        type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
        type.ContainingNamespace is { IsGlobalNamespace: true } ? null : type.ContainingNamespace?.ToString(),
        type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat))
    {
    }
}

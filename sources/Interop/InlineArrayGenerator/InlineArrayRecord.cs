using Microsoft.CodeAnalysis;

namespace InlineArrayGenerator;

internal sealed record InlineArrayRecord(
    int Length,
    bool IsRefLike,
    TypeRecord ArrayType,
    TypeRecord ElementType)
{
    public InlineArrayRecord(int length, ITypeSymbol arrayType, ITypeSymbol elementType) : this(
        length,
        elementType.IsRefLikeType,
        new TypeRecord(arrayType),
        new TypeRecord(elementType))
    {
    }
}

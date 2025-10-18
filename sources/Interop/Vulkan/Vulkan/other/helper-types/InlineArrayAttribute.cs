using System;

namespace TerraFX.Interop;

/// <summary>Indicates that the instance's storage is sequentially replicated "length" times.</summary>
[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
internal sealed class InlineArrayAttribute : Attribute
{
    /// <summary>Gets the number of sequential fields to replicate in the inline array type.</summary>
    public int Length { get; }

    /// <summary>Creates a new <see cref="InlineArrayAttribute"/> instance with the specified length.</summary>
    /// <param name="length">The number of sequential fields to replicate in the inline array type.</param>
    public InlineArrayAttribute(int length)
    {
        Length = length;
    }
}

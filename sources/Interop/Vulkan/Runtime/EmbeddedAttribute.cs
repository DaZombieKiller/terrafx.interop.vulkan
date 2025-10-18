using System;

namespace Microsoft.CodeAnalysis;

[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Delegate |
    AttributeTargets.Enum |
    AttributeTargets.Interface |
    AttributeTargets.Struct)]
internal sealed class EmbeddedAttribute : Attribute
{
    public EmbeddedAttribute()
    {
    }
}

using System;

namespace Shared.Attributes;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class WeightAttribute : Attribute
{
    public float Value { get; }

    public WeightAttribute(float value)
    {
        Value = value;
    }
}

using System;
using System.Reflection;
using Shared.Attributes;

namespace Shared.Extensions;

public static class InteractionTypeExtensions
{
    public static float GetWeight(this Enums.InteractionType type)
    {
        var field = typeof(Enums.InteractionType).GetField(type.ToString());
        var attribute = field?.GetCustomAttribute<WeightAttribute>();
        return attribute?.Value ?? 0;
    }
}

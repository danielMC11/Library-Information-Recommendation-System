using Shared.Attributes;

namespace Shared.Enums;

public enum InteractionType
{
    [Weight(0.5f)]
    SEARCH,
    [Weight(1.0f)]
    VIEW,
    [Weight(2.0f)]
    FAVORITE,
    [Weight(-1.0f)]
    UNFAVORITE
}

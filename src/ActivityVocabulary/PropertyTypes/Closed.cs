using ActivityVocabulary.CoreTypes;

namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * Indicates the closing of a Questions. Can have either an Object, a Link, a
 * boolean or a time of close, but should only have one of them.
 * </summary>
 */
public record Closed(
    ObjectType? Object = null,
    Link? Link = null,
    bool? IsClosed = null,
    DateTimeOffset? ClosedAt = null
);
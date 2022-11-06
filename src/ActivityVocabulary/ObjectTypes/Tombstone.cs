using ActivityVocabulary.CoreTypes;

namespace ActivityVocabulary.Extended.ObjectTypes;

/**
 * <summary>
 * A Tombstone represents a content object that has been deleted. It can be used
 * in Collections to signify that there used to be an object at this position,
 * but it has been deleted.
 * </summary>
 * <param name="FormerType">The type of the object that was deleted.</param>
 * <param name="Deleted">A timestamp for when the object was deleted.</param>
 */
public record Tombstone(
    ObjectType FormerType,
    DateTimeOffset Deleted) : ObjectType;
namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor has deleted the object. If specified, the origin
 * indicates the context from which the object was deleted.
 * </summary>
 * <returns></returns>
 */
public record Delete() : CoreTypes.Activity;

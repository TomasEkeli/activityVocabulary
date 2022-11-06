namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor is removing the object. If specified, the origin
 * indicates the context from which the object is being removed.
 * </summary>
 */
public record Remove() : CoreTypes.Activity;

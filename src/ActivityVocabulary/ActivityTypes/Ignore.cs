namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor is ignoring the object. The target and origin
 * typically have no defined meaning.
 * </summary>
 */
public record Ignore() : CoreTypes.Activity;

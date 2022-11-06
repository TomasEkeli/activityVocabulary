namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor is rejecting the object. The target and origin
 * typically have no defined meaning.
 * </summary>
 */
public record Reject() : CoreTypes.Activity;

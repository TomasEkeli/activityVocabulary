namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor has joined the object. The target and origin
 * typically have no defined meaning.
 * </summary>
 * <returns></returns>
 */
public record Join() : CoreTypes.Activity;

namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor has left the object. The target and origin typically
 * have no meaning.
 * </summary>
 */
public record Leave() : CoreTypes.Activity;

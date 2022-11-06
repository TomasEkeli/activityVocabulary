namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor likes, recommends or endorses the object. The target
 * and origin typically have no defined meaning.
 * </summary>
 */
public record Like() : CoreTypes.Activity;

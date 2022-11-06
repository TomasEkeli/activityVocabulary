namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor has moved the object from origin to target. If the
 * origin or target are not specified either can be determined by context.
 * </summary>
 */
public record Move() : CoreTypes.Activity;

namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor is "flagging" the object. Flagging is defined in the
 *  sense common to many social platforms as reporting content as being
 * inappropriate for any number of reasons.
 * </summary>
 */
public record Flag() : CoreTypes.Activity;

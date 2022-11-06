namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor is "following" the object. Following is defined in
 * the sense typically used within Social systems in which the actor is
 * interested in any activity performed by or on the object. The target and
 * origin typically have no defined meaning.
 * </summary>
 */
public record Follow() : CoreTypes.Activity;

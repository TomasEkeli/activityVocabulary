namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor accepts the object. The target property can be used
 * in certain circumstances to indicate the context into which the object has
 * been accepted.
 *
 * <see href="https://www.w3.org/ns/activitystreams#Accept"/>
 * </summary>
 * <returns></returns>
 */
public record Accept() : CoreTypes.Activity;

namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * * Indicates that the actor has added the object to the target. If the target
 * property is not explicitly specified, the target would need to be determined
 * implicitly by context. The origin property can be used to identify the
 * context from which the object originated.
 *
 * <see href="https://www.w3.org/ns/activitystreams#Add"/>
 * </summary>
 */
public record Add() : CoreTypes.Activity;

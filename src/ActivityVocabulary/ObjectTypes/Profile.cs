using ActivityVocabulary.CoreTypes;

namespace ActivityVocabulary.Extended.ObjectTypes;

/**
 * <summary>
 * A Profile is a content object that describes another Object, typically used
 * to describe Actor Type objects. The describes property is used to reference
 * the object being described by the profile.
 * </summary>
 * <param name="Describes">
 * On a Profile object, the describes property identifies the object described
 * by the Profile.
 * </param>
 */
public record Profile(ObjectType? Describes) : ObjectType;

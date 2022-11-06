namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * <para>
 * Indicates that the actor has updated the object. Note, however, that this
 * vocabulary does not define a mechanism for describing the actual set of
 * modifications made to object.
 * </para><para>
 * The target and origin typically have no defined meaning.
 * </para>
 * </summary>
 */
public record Update() : CoreTypes.Activity;

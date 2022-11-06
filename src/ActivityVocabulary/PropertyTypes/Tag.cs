namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Indicates an entity that describes a related resource. Can be any kind of
 * Object. The key difference between attachment and tag is that the former
 * implies an association by inclusion, while the latter (this) implies an
 * association by reference.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#tag"/>
 * </para>
 * </summary>
 */
public record Tag() : ObjectOrLink;

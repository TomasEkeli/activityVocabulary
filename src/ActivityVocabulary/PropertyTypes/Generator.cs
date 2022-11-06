namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Identifies the entity (e.g. an application) that generated the object.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#generator"/>
 * </para>
 * </summary>
 */
public record Generator() : ObjectOrLink;

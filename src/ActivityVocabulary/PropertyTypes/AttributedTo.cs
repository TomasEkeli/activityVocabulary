namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Identifies an entity to which this object is attributed. The attributed
 * entity might not be an Actor. For instance, an object might be  attributed to
 * the completion of another activity.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#attributedTo"/>
 * </para>
 * </summary>
 */
public record AttributedTo() : ObjectOrLink;

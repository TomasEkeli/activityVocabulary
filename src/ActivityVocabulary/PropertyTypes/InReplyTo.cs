namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Inndicates one or more entities for which an object is considered a response.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#inreplyto"/>
 * </para>
 * </summary>
 */
public record InReplyTo() : ObjectOrLink;

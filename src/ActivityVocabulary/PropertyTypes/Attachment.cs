namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Identifies a resource attached or related to an object that potentially
 * requires special handling. The intent is to provide a model that is at least
 * semantically similar to attachments in email.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#attachment"/>
 * </para>
 * </summary>
 */
public record Attachment() : ObjectOrLink;

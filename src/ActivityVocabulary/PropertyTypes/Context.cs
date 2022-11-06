namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Identifies the context within which the object exists or an activity was
 * performed.
 * </para><para>
 * The notion of "context" used is intentionally vague. The intended function is
 * to serve as a means of grouping objects and activities that share a common
 * originating context or purpose. An example could be all activities relating
 * to a common project or event.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#context"/>
 * </para>
 * </summary>
 */
public record Context() : ObjectOrLink;

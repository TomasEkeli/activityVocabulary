namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Describes an indirect object from which the activity is directed. The precise
 * meaning of the origin is the object of the English preposition "from". For
 * instance, in the activity "John moved an item to List B from List A", the
 * origin of the activity is "List A".
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#origin"/>
 * </para>
 * </summary>
 */
public record Origin() : ObjectOrLink;

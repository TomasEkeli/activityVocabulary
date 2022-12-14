using ActivityVocabulary.PropertyTypes;

namespace ActivityVocabulary.CoreTypes;

/**
 * <summary>
 * Describes an object of any kind. The Object type serves as the base type for
 * most of the other kinds of objects defined in the Activity Vocabulary,
 * including other Core types such as Activity, IntransitiveActivity, Collection
 * and OrderedCollection.
 * </summary>
 * <param name="Attachment">
 * Identifies resources attached or related to an object that potentially
 * requires special handling. The intent is to provide a model that is at least
 * semantically similar to attachments in email.
 * </param>
 * <param name="AttributedTo">
 * Identifies one or more entities to which this object is attributed. The
 * attributed entities might not be Actors. For instance, an object might be
 * attributed to the completion of another activity.
 * </param>
 * <param name="Audience">
 * Identifies one or more entities that represent the total population of
 * entities for which the object can considered to be relevant.
 * </param>
 * <param name="Content">
 * <para>
 * The content or textual representation of the Object encoded as a JSON string.
 * By default, the value of content is HTML. The mediaType property can be used
 * in the object to indicate a different content type.
 * </para><para>
 * The content MAY be expressed using multiple language-tagged values. In such
 * cases the content will reside in the ContentMap property.
 * </para>
 * </param>
 * <param name="ContentMap">
 * <para>
 * The content or textual representation of the Object encoded as language-mapped
 * JSON strings. The language map is a JSON object where the keys are language
 * tags and the values are strings. By default, the value of content is HTML.
 * The mediaType property can be used in the object to indicate a different
 * content type.
 * </para><para>
 * The content MAY be expressed as a single string value. In such cases the
 * content will reside in the Content property.
 * </para>
 * </param>
 * <param name="Context">
 * <para>
 * Identifies the context within which the object exists or an activity was
 * performed.
 * </para><para>
 * The notion of "context" used is intentionally vague. The intended function
 * is to serve as a means of grouping objects and activities that share a common
 * originating context or purpose. An example could be all activities relating
 * to a common project or event.
 * </para>
 * </param>
 * <param name="Name">
 * A simple, human-readable, plain-text name for the object. HTML markup MUST
 * NOT be included. The name MAY be expressed using multiple language-tagged
 * values. In such cases, the nameMap property will contain a language map object.
 * </param>
 * <param name="NameMap">
 * A simple, human-readable, plain-text name for the object. HTML markup MUST
 * NOT be included. The name MAY be expressed as a single string value. In such
 * cases, the name property will contain that string.
 * </param>
 * <param name="EndTime">
 * The date and time describing the actual or expected ending time of the object.
 * When used with an Activity object, for instance, the endTime property
 * specifies the moment the activity concluded or is expected to conclude.
 * </param>
 * <param name="Generator">
 * Identifies the entity (e.g. an application) that generated the object.
 * </param>
 * <param name="Icon">
 * Indicates an entity that describes an icon for this object. The image should
 * have an aspect ratio of one (horizontal) to one (vertical) and should be
 * suitable for presentation at a small size.
 * </param>
 * <param name="Image"></param>
 * Indicates an entity that describes an image for this object. Unlike the icon
 * property, there are no aspect ratio or display size limitations assumed.
 * <param name="InReplyTo"></param>
 * Indicates one or more entities for which this object is considered a response.
 * <param name="Location">
 * Indicates one or more physical or logical locations associated with the object.
 * </param>
 * <param name="Preview">
 * Identifies an entity that provides a preview of this object.
 * </param>
 * <param name="Published">
 * The date and time at which the object was published.
 * </param>
 * <param name="Replies">
 * Identifies a Collection containing objects considered to be responses to this
 * object.
 * </param>
 * <param name="StartTime">
 * The date and time describing the actual or expected starting time of the
 * object. When used with an Activity object, for instance, the startTime
 * property specifies the moment the activity began or is scheduled to begin.
 * </param>
 * <param name="Summary">
 * A natural language summarization of the object encoded as HTML. Multiple
 * language tagged summaries MAY be provided. In that case, the summaryMap
 * property will contain a language map object.
 * </param>
 * <param name="SummaryMap">
 * A natural language summarization of the object encoded as HTML. A single
 * summaru MAY be provided. In that case, the summary property will contain the
 * string value.
 * </param>
 * <param name="Tag">
 * One or more "tags" that have been associated with an objects. A tag can be
 * any kind of Object. The key difference between attachment and tag is that the
 * former implies association by inclusion, while the latter implies associated
 * by reference.
 * </param>
 * <param name="Updated">
 * The date and time at which the object was updated
 * </param>
 * <param name="Url">
 * Identifies one or more links to representations of the object
 * </param>
 * <param name="To">
 * Identifies an entity considered to be part of the public primary audience of
 * an Object
 * </param>
 * <param name="Bto">
 * Identifies an Object that is part of the private primary audience of this
 * Object.
 * </param>
 * <param name="Cc">
 * Identifies an Object that is part of the public secondary audience of this
 * Object.
 * </param>
 * <param name="Bcc">
 * Identifies one or more Objects that are part of the private secondary audience
 * of this Object.
 * </param>
 * <param name="MediaType">
 * Identifies the MIME media type of the value of the content property. If not
 * specified, the content property is assumed to contain text/html content.
 * </param>
 * <param name="Duration">
 * When the object describes a time-bound resource, such as an audio or video,
 * a meeting, etc, the duration property indicates the object's approximate
 * duration. The value MUST be expressed as an xsd:duration as defined by
 * [ xmlschema11-2], section 3.3.6 (e.g. a period of 5 seconds is represented
 * as "PT5S").
 * </param>
 * <returns></returns>
 */
public record ObjectType(
    IEnumerable<Attachment>? Attachment = null,
    IEnumerable<AttributedTo>? AttributedTo = null,
    IEnumerable<Audience>? Audience = null,
    string? Content = null,
    Dictionary<string, string>? ContentMap = null,
    Context? Context = null,
    string? Name = null,
    Dictionary<string, string>? NameMap = null,
    DateTimeOffset? EndTime = null,
    Generator? Generator = null,
    Icon? Icon = null,
    IEnumerable<ImageOrLink>? Image = null,
    InReplyTo? InReplyTo = null,
    IEnumerable<Location>? Location = null,
    Preview? Preview = null,
    DateTimeOffset? Published = null,
    Collection? Replies = null,
    DateTimeOffset? StartTime = null,
    string? Summary = null,
    Dictionary<string, string>? SummaryMap = null,
    IEnumerable<Tag>? Tag = null,
    DateTimeOffset? Updated = null,
    IEnumerable<UrlOrLink>? Url = null,
    IEnumerable<Audience>? To = null,
    IEnumerable<Audience>? Bto = null,
    IEnumerable<Audience>? Cc = null,
    IEnumerable<Audience>? Bcc = null,
    MediaType? MediaType = null,
    TimeSpan? Duration = null
);

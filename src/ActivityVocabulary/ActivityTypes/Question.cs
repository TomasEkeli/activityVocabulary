using ActivityVocabulary.PropertyTypes;

namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * <para>
 * Represents a question being asked. Question objects are an extension of
 * IntransitiveActivity. That is, the Question object is an Activity, but the
 * direct object is the question itself and therefore it would not contain an
 * object property.
 * </para><para>
 * Either of the anyOf and oneOf properties MAY be used to express possible
 * answers, but a Question object MUST NOT have both properties.
 * </para>
 * </summary>
 * <param name="OneOf">
 * Identifies an exclusive option for a Question. Use of oneOf implies that the
 * Question can have only a single answer. To indicate that a Question can have
 * multiple answers, use anyOf.
 * </param>
 * <param name="AnyOf">
 * Identifies an inclusive option for a Question. Use of anyOf implies that the
 * Question can have multiple answers. To indicate that a Question can have only
 * one answer, use oneOf.
 * </param>
 * <param name="Closed">
 * Indicates that a question has been closed, and answers are no longer accepted.
 * </param>
 */
public record Question(
    IEnumerable<ObjectOrLink>? OneOf = null,
    IEnumerable<ObjectOrLink>? AnyOf = null,
    Closed? Closed = null
) : CoreTypes.IntransitiveActivity;
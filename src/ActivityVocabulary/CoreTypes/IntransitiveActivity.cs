using ActivityVocabulary.PropertyTypes;

namespace ActivityVocabulary.CoreTypes;

/**
 * <summary>
 * <para>
 * Instances of IntransitiveActivity are a sub-type of Activity representing
 * intransitive actions. The object property is therefore inappropriate for
 * these activites.
 * </para><para>
 * Since inheritance in C# is additive the Activity is implemented as a subclass
 * of IntransitiveActivity. This means that the Activity class is a subtype of
 * IntransitiveActivity and Object, while semantically the IntransitiveActivity
 * class is a subtype of Activity.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#IntransitiveActivity"/>
 * </para>
 * </summary>
 * <param name="Actor">
 * Describes one or more entities that either performed or are expected to
 * perform the activity. Any single activity may have multiple actors. The
 * actor property may be specified using an indirect Link.
 * </param>
 * <param name="Target">
 * Describes the indirect object, or target, of the activity. The precise
 * meaning of the target is largely dependent on the type of action being
 * described but will often be the object of the English preposition "to". For
 * instance, in the activity "John added a movie to his wishlist", the target
 * of the activity is John's wishlist. An activity can have more than one target.
 * </param>
 * <param name="Result">
 * Describes the result of the activity. For instance, if a particular action
 * results in the creation of a new resource, the result property can be used
 * to describe the new resource. The result property can be specified using an
 * </param>
 * <param name="Origin">
 * Describes an indirect object from which the activity is directed. The precise
 * meaning of the origin is the object of the English preposition "from". For
 * instance, in the activity "John moved an item to List B from List A", the
 * origin of the activity is "List A".
 * </param>
 * <param name="Instrument">
 * Identifies one or more objects used (or to be used) in the completion of an
 * activity.
 * </param>
 */
public record IntransitiveActivity(
    IEnumerable<Actor>? Actor = null,
    Target? Target = null,
    Result? Result = null,
    Origin? Origin = null,
    IEnumerable<Instrument>? Instrument = null
) : ObjectType;

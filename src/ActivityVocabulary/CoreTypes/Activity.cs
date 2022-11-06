namespace ActivityVocabulary.CoreTypes;

/**
 * <summary>
 * <para>
 * An Activity is a subtype of Object that describes some form of action that
 * may happen, is currently happening, or has already happened. The Activity
 * type itself serves as an abstract base type for all types of activities. It
 * is important to note that the Activity type itself does not carry any
 * specific semantics about the kind of action being taken.
 * </para><para>
 * Since inheritance in C# is additive the Activity is implemented as a subclass
 * of IntransitiveActivity. This means that the Activity class is a subtype of
 * IntransitiveActivity and Object, while semantically the IntransitiveActivity
 * class is a subtype of Activity.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#Activity"/>
 * </para>
 * </summary>
 * <param name="Object">
 * The object of the (transitive) activity. The precise meaning of the object
 * is largely dependent on the type of action being described but will often
 * be the object of the English preposition "to". For instance, in the activity
 * "John added a movie to his wishlist", the object of the activity is the
 * movie.
 * </param>
 * <returns></returns>
 */
public record Activity(ObjectType? Object = null) : IntransitiveActivity;

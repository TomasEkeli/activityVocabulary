using ActivityVocabulary.PropertyTypes;

namespace ActivityVocabulary.CoreTypes;

/**
 * <summary>
 * <para>
 * A Collection is a subtype of Object that represents ordered or unordered
 * sets of Object or Link instances.
 * </para><para>
 * Refer to the Activity Streams 2.0 Core specification for a complete
 * description of the Collection type.
 * </para>
 * </summary>
 * <param name="TotalItems">
 * A non-negative integer specifying the total number of objects contained by
 * the logical view of the collection. This number might not reflect the actual
 * number of items serialized within the Collection object instance.
 * </param>
 * <param name="Current">
 * In a paged Collection, indicates the page that contains the most recently
 * updated member items.
 * </param>
 * <param name="First">
 * In a paged Collection, indicates the furthest preceeding page of items in the
 * collection.
 * </param>
 * <param name="Last">
 * In a paged Collection, indicates the furthest proceeding page of the
 * collection.
 * </param>
 * <param name="Items">
 * Identifies the items contained in a collection. The items might be ordered or
 * unordered.
 * </param>
 * <returns></returns>
 */
public record Collection(
    uint? TotalItems = null,
    CollectionPageOrLink? Current = null,
    CollectionPageOrLink? First = null,
    CollectionPageOrLink? Last = null,
    IEnumerable<ObjectOrLink>? Items = null
) : ObjectType;

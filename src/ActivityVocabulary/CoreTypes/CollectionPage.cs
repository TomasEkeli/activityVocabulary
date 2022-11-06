using ActivityVocabulary.PropertyTypes;

namespace ActivityVocabulary.CoreTypes;

/**
 * <summary>
 * Used to represent distinct subsets of items from a Collection. Refer to the
 * Activity Streams 2.0 Core for a complete description of the CollectionPage
 * object.
 * </summary>
 * <param name="PartOf">
 * Identifies the Collection to which a CollectionPage objects items belong.
 * </param>
 * <param name="Next">
 * In a paged Collection, indicates the next page of items.
 * </param>
 * <param name="Prev">
 * In a paged Collection, indicates the previous page of items.
 * </param>
 * <returns></returns>
 */
public record CollectionPage(
    LinkOrCollection? PartOf = null,
    CollectionPageOrLink? Next = null,
    CollectionPageOrLink? Prev = null
) : Collection;

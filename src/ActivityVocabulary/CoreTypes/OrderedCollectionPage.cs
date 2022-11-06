namespace ActivityVocabulary.CoreTypes;

/**
 * <summary>
 * Used to represent ordered subsets of items from an OrderedCollection. Refer
 * to the Activity Streams 2.0 Core for a complete description of the
 * OrderedCollectionPage object.
 * </summary>
 * <param name="StartIndex">
 * A non-negative integer value identifying the relative position within the
 * logical view of a strictly ordered collection.
 * </param>
 * <returns></returns>
 */
public record OrderedCollectionPage(uint? StartIndex = null) : CollectionPage;

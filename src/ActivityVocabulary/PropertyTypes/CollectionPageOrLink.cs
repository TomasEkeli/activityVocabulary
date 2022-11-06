using ActivityVocabulary.CoreTypes;

namespace ActivityVocabulary.PropertyTypes;

public record CollectionPageOrLink(
    CollectionPage? CollectionPage = null,
    Link? Link = null
);

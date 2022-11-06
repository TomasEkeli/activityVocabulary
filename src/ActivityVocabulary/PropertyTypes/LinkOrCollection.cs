using ActivityVocabulary.CoreTypes;

namespace ActivityVocabulary.PropertyTypes;

public record LinkOrCollection(
    Link? Link = null,
    Collection? Collection = null
);
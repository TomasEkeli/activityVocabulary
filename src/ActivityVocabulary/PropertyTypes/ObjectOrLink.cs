using ActivityVocabulary.CoreTypes;

namespace ActivityVocabulary.PropertyTypes;

public record ObjectOrLink(
    ObjectType? Object = null,
    Link? Link = null
);

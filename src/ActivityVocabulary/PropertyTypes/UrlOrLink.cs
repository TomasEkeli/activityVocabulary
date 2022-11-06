using ActivityVocabulary.CoreTypes;

namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * A direct URL (URI) or a Link to something
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#url"/>
 * </para>
 * </summary>
 * <param name="Url"></param>
 * <param name="Link"></param>
 */
public record UrlOrLink(
    Uri? Url = null,
    Link? Link = null
);

using ActivityVocabulary.CoreTypes;
using ActivityVocabulary.Extended.ObjectTypes;

namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * Indicates an entity that describes an image an object. Unlike the icon there
 * are no aspect ratio or display size limitations assumed.
 * </summary>
 * <param name="Image"></param>
 * <param name="Link"></param>
 * <returns></returns>
 */
public record ImageOrLink(
    Image? Image = null,
    Link? Link = null
);

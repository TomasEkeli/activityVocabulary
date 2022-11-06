using ActivityVocabulary.PropertyTypes;

namespace ActivityVocabulary.CoreTypes;

/**
 * <summary>
 * A Link is an indirect, qualified reference to a resource identified by a URL.
 * The fundamental model for links is established by [ RFC5988]. Many of the
 * properties defined by the Activity Vocabulary allow values that are either
 * instances of Object or Link. When a Link is used, it establishes a qualified
 * relation connecting the subject (the containing object) to the resource
 * identified by the href. Properties of the Link are properties of the
 * reference as opposed to properties of the resource.
 * </summary>
 * <param name="Href">The target resource pointed to by this link</param>
 * <param name="Rel">
 * <para>
 * A link relation associated with a Link. The value MUST conform to both the
 * [HTML5] and [RFC5988] "link relation" definitions.
 * </para><para>
 * In the [HTML5], any string not containing the "space" U+0020, "tab" (U+0009),
 * "LF" (U+000A), "FF" (U+000C), "CR" (U+000D) or "," (U+002C) characters can be
 * used as a valid link relation.
 * </para>
 * </param>
 * <param name="MediaType">
 * Identifies the MIME media type of the referenced resource.
 * </param>
 * <param name="Name">
 * A natural language name for the link. Multiple language tagged names MAY be
 * provided. In that case, the nameMap property will contain a language map
 * object.
 * </param>
 * <param name="NameMap">
 * A natural language name for the link. A single name MAY be provided. In that
 * case, the name property will contain the string value.
 * </param>
 * <param name="HrefLang">
 * Hints as to the language used by the target resource. Value MUST be a [BCP47]
 * Language-Tag.
 * </param>
 * <param name="Height">
 * Specifies a hint as to the rendering height in device-independent pixels of
 * the linked resource.
 * </param>
 * <param name="Width">
 * Specifies a hint as to the rendering width in device-independent pixels of
 * the linked resource.
 * </param>
 * <param name="Preview">
 * Identifies an entity that provides a preview of this Link.
 * </param>
 */
public record Link(
    Uri? Href = null,
    IEnumerable<string>? Rel = null,
    MediaType? MediaType = null,
    string? Name = null,
    Dictionary<string, string>? NameMap = null,
    string? HrefLang = null,
    uint? Height = null,
    uint? Width = null,
    Preview? Preview = null
);

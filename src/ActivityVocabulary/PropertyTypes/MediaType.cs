namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * When used on a Link, identifies the MIME media type of the referenced
 * resource.
 * </para><para>
 * When used on an Object, identifies the MIME media type of the value of the
 * content property. If not specified, the content property is assumed to
 * contain text/html content.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#mediaType"/>
 * </para>
 * </summary>
 * <param name="Value"></param>
 */
public record MediaType(string Value)
{
    public static implicit operator MediaType(string v) => new(v);

    public static implicit operator string(MediaType mt) => mt.Value;
}

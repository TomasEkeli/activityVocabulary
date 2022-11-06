namespace ActivityVocabulary.PropertyTypes;

/**
 * <summary>
 * <para>
 * Indicates an entity that describes an icon for an object. The image should
 * have an aspect ratio of one (horizontal) to one (vertical) and should be
 * suitable for presentation at a small size.
 * </para><para>
 * <see href="https://www.w3.org/ns/activitystreams#icon"/>
 * </para>
 * </summary>
 */
public record Icon() : ImageOrLink;

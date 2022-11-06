namespace ActivityVocabulary.Extended.ObjectTypes;

/**
 * <summary>
 * Represents a logical or physical location. See 5.3 Representing Places for
 * additional information
 * </summary>
 * <param name="Accuracy">
 * Indicates the accuracy of position coordinates on a Place objects. Expressed
 * in properties of percentage. e.g. "94.0" means "94.0% accurate".
 * </param>
 * <param name="Altitude">
 * Indicates the altitude of a place. The measurement units is indicated using
 * the units property. If units is not specified, the default is assumed to be
 * "m" indicating meters.
 * </param>
 * <param name="Latitude">
 * The latitude of a place
 * </param>
 * <param name="Longitude">
 * The longitude of a place
 * </param>
 * <param name="Radius">
 * The radius from the given latitude and longitude for a Place. The units is
 * expressed by the units property. If units is not specified, the default is
 * assumed to be "m" indicating "meters".
 * </param>
 * <param name="Units">
 * Specifies the measurement units for the radius and altitude properties on a
 * Place object. If not specified, the default is assumed to be "m" for "meters".
 * </param>
 */
public record Place(
    double? Accuracy = null,
    double? Altitude = null,
    double? Latitude = null,
    double? Longitude = null,
    double? Radius = null,
    string? Units = null
) : CoreTypes.ObjectType;


namespace ActivityVocabulary.Extended.ObjectTypes;

public record Relation(
    string? Subject = null,
    string? Object = null,
    string? Relationship = null
) : CoreTypes.ObjectType;

public record Article() : CoreTypes.ObjectType;

public record Document() : CoreTypes.ObjectType;

public record Audio() : Document;

public record Image() : Document;

public record Video() : Document;

public record Note() : CoreTypes.ObjectType;

public record Page() : Document;

public record Event(
    string? Accuracy = null,
    string? Altitude = null,
    string? Latitude = null,
    string? Longitude = null,
    string? Radius = null,
    string? Units = null
) : CoreTypes.ObjectType;

public record Mention() : CoreTypes.Link;

public record Profile() : CoreTypes.ObjectType;

public record Tombstone() : CoreTypes.ObjectType;
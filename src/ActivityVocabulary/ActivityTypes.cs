namespace ActivityVocabulary.Extended.ActivityTypes;

/**
 * <summary>
 * Indicates that the actor accepts the object. The target property can be used
 * in certain circumstances to indicate the context into which the object has
 * been accepted.
 *
 * <see href="https://www.w3.org/ns/activitystreams#Accept"/>
 * </summary>
 * <returns></returns>
 */
public record Accept() : CoreTypes.Activity;

/**
 * <summary>
 * A specialization of Accept indicating that the acceptance is tentative.
 *
 * <see href="https://www.w3.org/ns/activitystreams#TentativeAccept"/>
 * </summary>
 * <returns></returns>
 */
public record TentativeAccept() : Accept;

/**
 * <summary>
 * * Indicates that the actor has added the object to the target. If the target
 * property is not explicitly specified, the target would need to be determined
 * implicitly by context. The origin property can be used to identify the
 * context from which the object originated.
 *
 * <see href="https://www.w3.org/ns/activitystreams#Add"/>
 * </summary>
 * <returns></returns>
 */
public record Add() : CoreTypes.Activity;

public record Arrive() : CoreTypes.IntransitiveActivity;

public record Create() : CoreTypes.Activity;

public record Delete() : CoreTypes.Activity;

public record Follow() : CoreTypes.Activity;

public record Ignore() : CoreTypes.Activity;

public record Join() : CoreTypes.Activity;

public record Leave() : CoreTypes.Activity;

public record Like() : CoreTypes.Activity;

public record Offer() : CoreTypes.Activity;

public record Invite() : Offer;

public record Reject() : CoreTypes.Activity;

public record TentativeReject() : Reject;

public record Remove() : CoreTypes.Activity;

public record Undo() : CoreTypes.Activity;

public record Update() : CoreTypes.Activity;

public record Listen() : CoreTypes.Activity;

public record Read() : CoreTypes.Activity;

public record Move() : CoreTypes.Activity;

public record Travel() : CoreTypes.IntransitiveActivity;

public record Announce() : CoreTypes.Activity;

public record Block() : CoreTypes.Activity;

public record Flag() : CoreTypes.Activity;

public record Dislike() : CoreTypes.Activity;

public record Question(
    string? OneOf = null,
    string? AnyOf = null,
    string? Closed = null
) : CoreTypes.IntransitiveActivity;
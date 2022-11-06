using ActivityVocabulary.PropertyTypes;

namespace ActivityVocabulary.Extended.ObjectTypes;

/**
 * <summary>
 * <para>
 * Describes a relationship between two individuals. The subject and object
 * properties are used to identify the connected individuals.
 * </para><para>
 * The Relationship object is used to represent relationships between
 * individuals. It can be used, for instance, to describe that one person is a
 * friend of another, or that one person is a member of a particular
 * organization. The intent of modeling Relationship in this way is to allow
 * descriptions of activities that operate on the relationships in general, and
 * to allow representation of Collections of relationships.
 * </para><para>
 * For instance, many social systems have a notion of a "friends list". These
 * are the collection of individuals that are directly connected within a
 * person's social graph. Suppose we have a user, Sally, with direct
 * relationships to users Joe and Jane. Sally follows Joe's updates while Sally
 * and Jane have a mutual relationship.
 * </para><para>
 * Using the Relationship object, we can model these relationships as:
 * <code>
 * {
 *   "@context": "https://www.w3.org/ns/activitystreams",
 *   "summary": "Sally's friends list",
 *   "type": "Collection",
 *   "items": [
 *     {
 *       "summary": "Sally is influenced by Joe",
 *       "type": "Relationship",
 *       "subject": {
 *         "type": "Person",
 *         "name": "Sally"
 *       },
 *       "relationship": "http://purl.org/vocab/relationship/influencedBy",
 *       "object": {
 *         "type": "Person",
 *         "name": "Joe"
 *       }
 *     },
 *     {
 *       "summary": "Sally is a friend of Jane",
 *       "type": "Relationship",
 *       "subject": {
 *         "type": "Person",
 *         "name": "Sally"
 *       },
 *       "relationship": "http://purl.org/vocab/relationship/friendOf",
 *       "object": {
 *         "type": "Person",
 *         "name": "Jane"
 *       }
 *     }
 *   ]
 * }
 * </code>
 * </para><para>
 * The relationship property specifies the kind of relationship that exists
 * between the two individuals identified by the subject and object properties.
 * Used together, these three properties form what is commonly known as a
 * "reified statement" where subject identifies the subject, relationship
 * identifies the predicate, and object identifies the object.
 * </para><para>
 * While use of reified statements can be problematic and confusing in certain
 * situations, their use within the Activity Streams vocabulary to describe
 * relationships provides a straightforward mechanism of describing changes to
 * an individual's social graph. For instance, to indicate that Sally has
 * created a new relationship to user Matt, an implementer can use the
 * Relationship object together with the Create activity:
 * </para><para>
 * <code>
 * {
 *   "@context": "https://www.w3.org/ns/activitystreams",
 *   "summary": "Sally became a friend of Matt",
 *   "type": "Create",
 *   "actor": "http://sally.example.org",
 *   "object": {
 *     "type": "Relationship",
 *     "subject": "http://sally.example.org",
 *     "relationship": "http://purl.org/vocab/relationship/friendOf",
 *     "object": "http://matt.example.org",
 *     "startTime": "2015-04-21T12:34:56"
 *   }
 * }
 * </code>
 * </para><para>
 * Additionally, modeling the relationship in this way allows implementers to
 * articulate additional properties of the relationship itself. For instance,
 * the date and time at which the relationship began or ended.
 * </para><para>
 * Implementations may reuse existing vocabularies that have been developed for
 * the purpose of describing relationships, or create their own guided by
 * requirements of their particular implementation. Existing vocabularies include
 * the "Friend of a Friend" and "Relationship" vocabularies.
 * </para>
 * </summary>
 * <param name="Subject">
 * The subject property identifies one of the connected individuals. For
 * instance, for a Relationship object describing "John is related to Sally",
 * subject would refer to John.
 * </param>
 * <param name="Object">
 * The object property identifies one of the connected individuals. For
 * instance, for a Relationship object describing "John is related to Sally",
 * object would refer to Sally.
 * </param>
 * <param name="Relationship">
 * The relationship property identifies the kind of relationship that exists,
 * between subject and object. Possibly described using the "Friend of a Friend"
 * or "Relationship" vocabularies.
 * </param>
 * <returns></returns>
 */
public record RelationshipDescriptor(
    ObjectOrLink? Subject = null,
    ObjectOrLink? Object = null,
    string? Relationship = null
) : CoreTypes.ObjectType;

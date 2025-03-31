namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node for an unknown XML tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public sealed class UnknownTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IUnknownTagDocumentationNode
{
}

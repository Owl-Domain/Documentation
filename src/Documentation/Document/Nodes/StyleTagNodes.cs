namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;b&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class BoldTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IBoldTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;i&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ItalicTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IItalicTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;u&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class UnderlineTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IUnderlineTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;a&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class LinkTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ILinkTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;br/&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class LineBreakTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ILineBreakTagDocumentationNode
{
}

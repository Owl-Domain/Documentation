namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;summary&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class SummaryTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ISummaryTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;remarks&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class RemarksTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IRemarksTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;returns&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ReturnsTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IReturnsTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;value&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ValueTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IValueTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;para&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ParagraphTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IParagraphTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;c&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class InlineCodeTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IInlineCodeTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;code&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class CodeBlockTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ICodeBlockTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;example&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ExampleTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IExampleTagDocumentationNode
{
}

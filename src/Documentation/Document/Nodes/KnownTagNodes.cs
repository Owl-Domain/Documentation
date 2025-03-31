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

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;param&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ParameterTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IParameterTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;paramref&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ParameterReferenceTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IParameterReferenceTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;typeparam&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class TypeParameterTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ITypeParameterTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;typeparamref&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class TypeParameterReferenceTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ITypeParameterReferenceTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;exception&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ExceptionTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IExceptionTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;inheritdoc&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class InheritTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IInheritTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;include&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class IncludeTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IIncludeTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;see&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class SeeTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ISeeTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;seealso&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class SeeAlsoTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ISeeAlsoTagDocumentationNode
{
}

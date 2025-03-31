namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;list&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ListTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IListTagDocumentationNode
{
	#region Properties
	/// <inheritdoc/>
	public string? ListTypeRaw => Attributes.TryGetValue("type", out string? type) ? type : null;

	/// <inheritdoc/>
	public ListTagType ListType => GetListType(ListTypeRaw);
	#endregion

	#region Helpers
	private static ListTagType GetListType(string? value)
	{
		return value switch
		{
			"bullet" => ListTagType.Bullet,
			"number" => ListTagType.Number,
			"table" => ListTagType.Table,

			_ => ListTagType.Unknown
		};
	}
	#endregion
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;listheader&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ListHeaderTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IListHeaderTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;item&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class ItemTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IItemTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;term&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class TermTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), ITermTagDocumentationNode
{
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;description&gt;</c> tag.
/// </summary>
/// <param name="tagName">The name of the XML tag.</param>
/// <param name="attributes">The raw attributes defined on the tag node.</param>
/// <param name="children">The child documentation nodes that make up the tag node.</param>
/// <param name="isSelfClosing">Whether the node is self closing.</param>
/// <exception cref="ArgumentException">
/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
/// 	and the <paramref name="children"/> collection is not empty.
/// </exception>
public class DescriptionTagDocumentationNode(
	string tagName,
	IReadOnlyDictionary<string, string> attributes,
	IReadOnlyList<IDocumentationNode> children,
	bool isSelfClosing)
	: TagDocumentationNode(tagName, attributes, children, isSelfClosing), IDescriptionTagDocumentationNode
{
}

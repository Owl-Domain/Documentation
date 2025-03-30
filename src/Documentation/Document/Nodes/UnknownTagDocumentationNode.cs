namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node for an unknown XML tag.
/// </summary>
public sealed class UnknownTagDocumentationNode : BaseTagDocumentationNode, IUnknownTagDocumentationNode
{
	#region Constructors
	/// <summary>Create a new instance of the <see cref="UnknownTagDocumentationNode"/>.</summary>
	/// <param name="tagName">The name of the XML tag.</param>
	/// <param name="attributes">The raw attributes defined on the tag node.</param>
	/// <param name="children">The child documentation nodes that make up the tag node.</param>
	/// <remarks>A node created through this constructor will not be self closing.</remarks>
	public UnknownTagDocumentationNode(string tagName, IReadOnlyDictionary<string, string> attributes, IReadOnlyList<IDocumentationNode> children)
	 : base(tagName, attributes, children)
	{
	}

	/// <summary>Create a new instance of the <see cref="UnknownTagDocumentationNode"/>.</summary>
	/// <param name="tagName">The name of the XML tag.</param>
	/// <param name="attributes">The raw attributes defined on the tag node.</param>
	/// <param name="isSelfClosing">Whether the node is self closing.</param>
	public UnknownTagDocumentationNode(string tagName, IReadOnlyDictionary<string, string> attributes, bool isSelfClosing)
	: base(tagName, attributes, isSelfClosing)
	{
	}
	#endregion
}

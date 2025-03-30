namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents the base implementation for a documentation node that is an XML tag element.
/// </summary>
public abstract class BaseTagDocumentationNode : DocumentationNodeCollection, ITagDocumentationNode
{
	#region Properties
	/// <inheritdoc/>
	public string TagName { get; }

	/// <inheritdoc/>
	public bool IsSelfClosing { get; }

	/// <inheritdoc/>
	public IReadOnlyDictionary<string, string> Attributes { get; }
	#endregion

	#region Constructors
	/// <summary>Populates the properties on the <see cref="BaseTagDocumentationNode"/> instance.</summary>
	/// <param name="tagName">The name of the XML tag.</param>
	/// <param name="attributes">The raw attributes defined on the tag node.</param>
	/// <param name="children">The child documentation nodes that make up the tag node.</param>
	/// <remarks>A node populated through this constructor will not be self closing.</remarks>
	protected BaseTagDocumentationNode(string tagName, IReadOnlyDictionary<string, string> attributes, IReadOnlyList<IDocumentationNode> children) : base(children)
	{
		TagName = tagName;
		Attributes = attributes;
	}

	/// <summary>Populates the properties on the <see cref="BaseTagDocumentationNode"/> instance.</summary>
	/// <param name="tagName">The name of the XML tag.</param>
	/// <param name="attributes">The raw attributes defined on the tag node.</param>
	/// <param name="isSelfClosing">Whether the node is self closing.</param>
	protected BaseTagDocumentationNode(string tagName, IReadOnlyDictionary<string, string> attributes, bool isSelfClosing) : base([])
	{
		TagName = tagName;
		Attributes = attributes;
		IsSelfClosing = isSelfClosing;
	}
	#endregion
}

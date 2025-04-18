namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents the base implementation for a documentation node that is an XML tag element.
/// </summary>
public class TagDocumentationNode : DocumentationNodeCollection, ITagDocumentationNode
{
	#region Properties
	/// <inheritdoc/>
	public string TagName { get; }

	/// <inheritdoc/>
	public bool IsSelfClosing { get; }

	/// <inheritdoc/>
	public IReadOnlyDictionary<string, string> Attributes { get; }

	/// <inheritdoc/>
	public Uri? Link => Attributes.TryGetValue("href", out string? href) ? new(href) : null;

	/// <inheritdoc/>
	public string? CodeReference => Attributes.TryGetValue("cref", out string? cref) ? cref : null;

	/// <inheritdoc/>
	public string? LanguageKeyword => Attributes.TryGetValue("langword", out string? langword) ? langword : null;

	/// <inheritdoc/>
	public string? NameReference => Attributes.TryGetValue("name", out string? name) ? name : null;

	/// <inheritdoc/>
	public string? PathReference => Attributes.TryGetValue("path", out string? path) ? path : null;

	/// <inheritdoc/>
	public string? FileReference => Attributes.TryGetValue("file", out string? file) ? file : null;
	#endregion

	#region Constructors
	/// <summary>Creates a new instance of the <see cref="TagDocumentationNode"/>.</summary>
	/// <param name="tagName">The name of the XML tag.</param>
	/// <param name="attributes">The raw attributes defined on the tag node.</param>
	/// <param name="children">The child documentation nodes that make up the tag node.</param>
	/// <param name="isSelfClosing">Whether the node is self closing.</param>
	/// <exception cref="ArgumentException">
	/// 	Thrown if <paramref name="isSelfClosing"/> is <see langword="true"/>
	/// 	and the <paramref name="children"/> collection is not empty.
	/// </exception>
	public TagDocumentationNode(string tagName, IReadOnlyDictionary<string, string> attributes, IReadOnlyList<IDocumentationNode> children, bool isSelfClosing) : base(children)
	{
		TagName = tagName;
		Attributes = attributes;
		IsSelfClosing = isSelfClosing;

		if (isSelfClosing && children.Count > 0)
			throw new ArgumentException($"A self closing tag node cannot have any children.", nameof(children));
	}
	#endregion
}

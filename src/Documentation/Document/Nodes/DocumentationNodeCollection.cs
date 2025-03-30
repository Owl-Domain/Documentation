namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents the base implementation for a documentation node that is made up of other child documentation nodes.
/// </summary>
/// <param name="children">The child documentation nodes that make up the collection node.</param>
public class DocumentationNodeCollection(IReadOnlyList<IDocumentationNode> children) : IDocumentationNodeCollection
{
	#region Properties
	/// <inheritdoc/>
	public IReadOnlyList<IDocumentationNode> Children { get; } = children;
	#endregion
}

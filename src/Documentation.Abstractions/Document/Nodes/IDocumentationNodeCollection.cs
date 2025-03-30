namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that is made up of other child documentation nodes.
/// </summary>
public interface IDocumentationNodeCollection : IDocumentationNode
{
	#region Properties
	/// <summary>The child documentation nodes that make up the collection node.</summary>
	IReadOnlyList<IDocumentationNode> Children { get; }
	#endregion
}

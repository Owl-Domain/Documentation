namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that consists of plain text.
/// </summary>
public interface ITextDocumentationNode : IDocumentationNode
{
	#region Properties
	/// <summary>The plain text that makes up the documentation node.</summary>
	string Text { get; }
	#endregion
}

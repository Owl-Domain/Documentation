namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that consists of plain text.
/// </summary>
/// <param name="text">The plain text that makes up the documentation node.</param>
public sealed class TextDocumentationNode(string text) : ITextDocumentationNode
{
	#region Properties
	/// <inheritdoc/>
	public string Text { get; } = text;
	#endregion
}

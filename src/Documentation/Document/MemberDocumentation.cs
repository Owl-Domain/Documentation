namespace OwlDomain.Documentation.Document;

/// <summary>
/// 	Represents the documentation for a member inside of a documentation document.
/// </summary>
/// <param name="name">The name of the documented member.</param>
/// <param name="rootNode">The root documentation node.</param>
public sealed class MemberDocumentation(string name, IDocumentationNode rootNode) : IMemberDocumentation
{
	#region Properties
	/// <inheritdoc/>
	public string Name { get; } = name;

	/// <inheritdoc/>
	public IDocumentationNode RootNode { get; } = rootNode;
	#endregion
}

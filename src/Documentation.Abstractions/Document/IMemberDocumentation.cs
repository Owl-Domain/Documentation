namespace OwlDomain.Documentation.Document;

/// <summary>
/// 	Represents the documentation for a member inside of a documentation document.
/// </summary>
public interface IMemberDocumentation
{
	#region Properties
	/// <summary>The name of the documented member.</summary>
	string Name { get; }

	/// <summary>The root documentation node.</summary>
	IDocumentationNode RootNode { get; }
	#endregion
}

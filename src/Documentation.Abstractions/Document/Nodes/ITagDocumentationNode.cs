namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that is an XML tag element.
/// </summary>
public interface ITagDocumentationNode : IDocumentationNodeCollection
{
	#region Properties
	/// <summary>The name of the tag.</summary>
	string TagName { get; }

	/// <summary>Whether the tag is self closing.</summary>
	/// <remarks>Self closing tags will not have any <see cref="IDocumentationNodeCollection.Children"/>.</remarks>
	bool IsSelfClosing { get; }

	/// <summary>The raw attributes defined on the tag node.</summary>
	IReadOnlyDictionary<string, string> Attributes { get; }
	#endregion
}

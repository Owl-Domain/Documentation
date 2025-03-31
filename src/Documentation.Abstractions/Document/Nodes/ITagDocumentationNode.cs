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

	/// <summary>A website link reference.</summary>
	/// <remarks>This is typically the value of the <c>href</c> attribute.</remarks>
	Uri? Link { get; }

	/// <summary>A reference to a difference piece of code.</summary>
	/// <remarks>This is typically the value of the <c>cref</c> attribute.</remarks>
	string? CodeReference { get; }

	/// <summary>The referenced language keyword.</summary>
	/// <remarks>This is typically the value of the <c>langword</c> attribute.</remarks>
	string? LanguageKeyword { get; }

	/// <summary>The name of the referenced item.</summary>
	/// <remarks>This is typically the value of the <c>name</c> attribute.</remarks>
	string? NameReference { get; }

	/// <summary>The path to the referenced item.</summary>
	/// <remarks>This is typically the value of the <c>path</c> attribute.</remarks>
	string? PathReference { get; }

	/// <summary>The referenced file path.</summary>
	/// <remarks>This is typically the value of the <c>file</c> attribute.</remarks>
	string? FileReference { get; }
	#endregion
}

namespace OwlDomain.Documentation.Document;

/// <summary>
/// 	Represents a parser for documentation documents.
/// </summary>
public interface IDocumentationParser
{
	#region Methods
	/// <summary>Parses the documentation in the given <paramref name="document"/>.</summary>
	/// <param name="document">The XML documentation document to parse.</param>
	/// <param name="assembly">The assembly that the documentation <paramref name="document"/> is for.</param>
	/// <returns>The parsed documentation document.</returns>
	/// <exception cref="ArgumentException">
	/// 	Thrown if the given <paramref name="document"/> could not be parsed.
	/// 	Make sure to check the <see cref="Exception.InnerException"/> for more details.
	/// </exception>
	IAssemblyDocumentation Parse(XmlDocument document, Assembly? assembly = null);
	#endregion
}

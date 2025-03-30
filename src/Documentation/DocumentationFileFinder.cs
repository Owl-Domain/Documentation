using System.IO;

namespace OwlDomain.Documentation;

/// <summary>
/// 	Represents a finder for documentation files.
/// </summary>
public sealed class DocumentationFileFinder : IDocumentationFileFinder
{
	#region Methods
	/// <inheritdoc/>
	public bool TryFind(Assembly assembly, [NotNullWhen(true)] out string? path)
	{
		path = Path.ChangeExtension(assembly.Location, ".xml");

		return File.Exists(path);
	}
	#endregion
}

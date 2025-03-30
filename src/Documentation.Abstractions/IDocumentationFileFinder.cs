namespace OwlDomain.Documentation;

/// <summary>
/// 	Represents a finder for documentation files.
/// </summary>
public interface IDocumentationFileFinder
{
	#region Methods
	/// <summary>Tries to find the <paramref name="path"/> to the documentation file for the given <paramref name="assembly"/>.</summary>
	/// <param name="assembly">The assembly to try and find the documentation file for.</param>
	/// <param name="path">The path to the found documentation file, or <see langword="null"/> if no documentation file could be found.</param>
	/// <returns>
	/// 	<see langword="true"/> if the <paramref name="path"/> for the
	/// 	documentation file could be found, <see langword="false"/> otherwise.
	/// </returns>
	bool TryFind(Assembly assembly, [NotNullWhen(true)] out string? path);
	#endregion
}

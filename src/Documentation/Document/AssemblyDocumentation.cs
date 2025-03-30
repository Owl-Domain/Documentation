namespace OwlDomain.Documentation.Document;

/// <summary>
/// 	Represents a documentation document for an assembly.
/// </summary>
/// <param name="assemblyName">The name of the assembly that the documentation document is for.</param>
/// <param name="members">The members documented in the document.</param>
/// <param name="assembly">The assembly that the documentation document is for.</param>
public sealed class AssemblyDocumentation(
	AssemblyName assemblyName,
	IReadOnlyDictionary<string, IMemberDocumentation> members,
	Assembly? assembly = null)
	 : IAssemblyDocumentation
{
	#region Properties
	/// <inheritdoc/>
	public AssemblyName AssemblyName { get; } = assemblyName;

	/// <inheritdoc/>
	public Assembly? Assembly { get; } = assembly;

	/// <inheritdoc/>
	public IReadOnlyDictionary<string, IMemberDocumentation> Members { get; } = members;
	#endregion
}

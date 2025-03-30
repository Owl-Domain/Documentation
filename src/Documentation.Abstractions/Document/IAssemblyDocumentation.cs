namespace OwlDomain.Documentation.Document;

/// <summary>
/// 	Represents a documentation document for an assembly.
/// </summary>
public interface IAssemblyDocumentation
{
	#region Properties
	/// <summary>The name of the assembly that the documentation document is for.</summary>
	/// <remarks>
	/// 	This will be the name of the assembly indicated inside of the document,
	/// 	not the assembly that the documentation was loaded for.
	/// </remarks>
	AssemblyName AssemblyName { get; }

	/// <summary>The assembly that the documentation document is for.</summary>
	Assembly? Assembly { get; }

	/// <summary>The members documented in the document.</summary>
	IReadOnlyDictionary<string, IMemberDocumentation> Members { get; }
	#endregion
}

using System.IO;

namespace OwlDomain.Documentation.Tests;

[TestClass]
public sealed class DocumentationFileFinderTests
{
	#region Tests
	[TestMethod]
	public void TryFind_AssemblyWithDocumentation_ReturnsTrue()
	{
		// Arrange
		Assembly assembly = typeof(DocumentationFileFinderTests).Assembly;
		string expectedPath = Path.ChangeExtension(assembly.Location, ".xml");

		DocumentationFileFinder sut = new();

		// Act
		bool result = sut.TryFind(assembly, out string? resultPath);

		// Assert
		Assert.That
			.IsTrue(result)
			.AreEqual(resultPath, expectedPath);
	}
	#endregion
}

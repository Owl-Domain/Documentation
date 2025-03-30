namespace OwlDomain.Documentation.Document;

/// <summary>
/// 	Contains various extension methods related to XML nodes.
/// </summary>
public static class XmlExtensions
{
	#region Methods
	/// <summary>
	/// 	Selects a single child node from the given <paramref name="node"/>, or throws
	/// 	the <see cref="ArgumentException"/> if a single child node could not be found.
	/// </summary>
	/// <param name="node">The node to select the child node from.</param>
	/// <param name="xpath">The XPath expression to use to select the node.</param>
	/// <returns>The selected node.</returns>
	/// <exception cref="ArgumentException">Thrown if a single child node could not be selected with the given <paramref name="xpath"/> expression.</exception>
	public static XmlNode SelectRequiredSingleNode(this XmlNode node, string xpath)
	{
		XmlNode? foundNode = node.SelectSingleNode(xpath);

		if (foundNode is not null)
			return foundNode;

		throw new ArgumentException($"A single node couldn't be selected using the given xpath ({xpath}).", nameof(node));
	}
	#endregion
}

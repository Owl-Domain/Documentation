namespace OwlDomain.Documentation.Document;

/// <summary>
/// 	Represents a parser for documentation documents.
/// </summary>
public class DocumentationParser : IDocumentationParser
{
	#region Methods
	/// <inheritdoc/>
	public IAssemblyDocumentation Parse(XmlDocument document, Assembly? assembly = null)
	{
		try
		{
			XmlNode doc = document.SelectRequiredSingleNode("/doc");
			XmlNode assemblyNameNode = doc.SelectRequiredSingleNode("//assembly/name");

			AssemblyName assemblyName = new(assemblyNameNode.InnerText);

			Dictionary<string, IMemberDocumentation> members = [];

			XmlNodeList memberNodes = doc.SelectNodes("//members/member");
			foreach (XmlNode node in memberNodes)
			{
				IMemberDocumentation member = ParseMember(node);
				members.Add(member.Name, member);
			}

			return new AssemblyDocumentation(assemblyName, members, assembly);
		}
		catch (Exception exception)
		{
			throw new ArgumentException($"Failed to parse the given XML document as an assembly documentation document.", nameof(document), exception);
		}
	}
	private IMemberDocumentation ParseMember(XmlNode node)
	{
		string name = node.Attributes["name"].Value;

		IReadOnlyList<IDocumentationNode> documentationNodes = ParseChildNodes(node);
		DocumentationNodeCollection rootNode = new(documentationNodes);

		return new MemberDocumentation(name, rootNode);
	}
	#endregion

	#region Documentation node methods
	private IDocumentationNode ParseNode(XmlNode node)
	{
		if (node.NodeType is XmlNodeType.Text)
			return new TextDocumentationNode(node.Value);

		if (node is XmlElement element)
		{
			IReadOnlyDictionary<string, string> attributes = ParseAttributes(node);
			IReadOnlyList<IDocumentationNode> children = ParseChildNodes(node);

			if (element.IsEmpty)
			{
				if (children.Count > 0)
					throw new InvalidOperationException("Empty elements should not have any children.");

				return new UnknownTagDocumentationNode(node.Name, attributes, true);
			}
			else
				return new UnknownTagDocumentationNode(node.Name, attributes, children);
		}

		throw new ArgumentException($"Unknown XML node type ({node.NodeType}).", nameof(node));
	}
	private IReadOnlyDictionary<string, string> ParseAttributes(XmlNode node)
	{
		Dictionary<string, string> attributes = [];

		foreach (XmlAttribute attribute in node.Attributes)
			attributes.Add(attribute.Name, attribute.Value);

		return attributes;
	}
	private IReadOnlyList<IDocumentationNode> ParseChildNodes(XmlNode node)
	{
		List<IDocumentationNode> nodes = [];

		foreach (XmlNode child in node.ChildNodes)
		{
			IDocumentationNode documentationNode = ParseNode(child);
			nodes.Add(documentationNode);
		}

		return nodes;
	}
	#endregion
}

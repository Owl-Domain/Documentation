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

		if (node is not XmlElement element)
			throw new ArgumentException($"Unknown XML node type ({node.NodeType}).", nameof(node));

		IReadOnlyDictionary<string, string> attributes = ParseAttributes(node);
		IReadOnlyList<IDocumentationNode> children = ParseChildNodes(node);

		if (TryParseKnownTagNode(element, attributes, children, out IDocumentationNode? knownNode))
			return knownNode;

		return new UnknownTagDocumentationNode(node.Name, attributes, children, element.IsEmpty);
	}
	private bool TryParseKnownTagNode(
		XmlElement element,
		IReadOnlyDictionary<string, string> attributes,
		IReadOnlyList<IDocumentationNode> children,
		[NotNullWhen(true)] out IDocumentationNode? knownNode)
	{
		knownNode = null;

		knownNode = element.Name switch
		{
			"summary" => new SummaryTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"remarks" => new RemarksTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"returns" => new ReturnsTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"value" => new ValueTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"para" => new ParagraphTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"c" => new InlineCodeTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"code" => new CodeBlockTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"example" => new ExampleTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),

			"param" => new ParameterTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"paramref" => new ParameterReferenceTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"typeparam" => new TypeParameterTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"typeparamref" => new TypeParameterReferenceTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"exception" => new ExceptionTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"inheritdoc" => new InheritTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"include" => new IncludeTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"see" => new SeeTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"seealso" => new SeeAlsoTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),

			"list" => new ListTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"listheader" => new ListHeaderTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"item" => new ItemTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"term" => new TermTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"description" => new DescriptionTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),

			"b" => new BoldTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"i" => new ItalicTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"u" => new UnderlineTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"a" => new LinkTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),
			"br" => new LineBreakTagDocumentationNode(element.Name, attributes, children, element.IsEmpty),

			_ => null,
		};

		return knownNode is not null;
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

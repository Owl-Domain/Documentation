namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;b&gt;</c> tag.
/// </summary>
public interface IBoldTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;i&gt;</c> tag.
/// </summary>
public interface IItalicTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;u&gt;</c> tag.
/// </summary>
public interface IUnderlineTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;a&gt;</c> tag.
/// </summary>
public interface ILinkTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;br/&gt;</c> tag.
/// </summary>
public interface ILineBreakTagDocumentationNode : ITagDocumentationNode { }
namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;summary&gt;</c> tag.
/// </summary>
public interface ISummaryTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;remarks&gt;</c> tag.
/// </summary>
public interface IRemarksTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;returns&gt;</c> tag.
/// </summary>
public interface IReturnsTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;value&gt;</c> tag.
/// </summary>
public interface IValueTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;para&gt;</c> tag.
/// </summary>
public interface IParagraphTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;c&gt;</c> tag.
/// </summary>
public interface IInlineCodeTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;code&gt;</c> tag.
/// </summary>
public interface ICodeBlockTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;example&gt;</c> tag.
/// </summary>
public interface IExampleTagDocumentationNode : ITagDocumentationNode { }
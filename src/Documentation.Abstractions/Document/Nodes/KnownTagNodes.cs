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

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;param&gt;</c> tag.
/// </summary>
public interface IParameterTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;paramref&gt;</c> tag.
/// </summary>
public interface IParameterReferenceTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;typeparam&gt;</c> tag.
/// </summary>
public interface ITypeParameterTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;typeparamref&gt;</c> tag.
/// </summary>
public interface ITypeParameterReferenceTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;exception&gt;</c> tag.
/// </summary>
public interface IExceptionTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;inheritdoc&gt;</c> tag.
/// </summary>
public interface IInheritTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;include&gt;</c> tag.
/// </summary>
public interface IIncludeTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;see&gt;</c> tag.
/// </summary>
public interface ISeeTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;seealso&gt;</c> tag.
/// </summary>
public interface ISeeAlsoTagDocumentationNode : ITagDocumentationNode { }
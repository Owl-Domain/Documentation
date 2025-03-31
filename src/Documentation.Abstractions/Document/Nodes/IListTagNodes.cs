namespace OwlDomain.Documentation.Document.Nodes;

/// <summary>
/// 	Represents the different known types of list tags.
/// </summary>
public enum ListTagType : byte
{
	/// <summary>The list type is unknown.</summary>
	Unknown,

	/// <summary>The list is an unordered bullet point list.</summary>
	Bullet,

	/// <summary>The list is an ordered number list.</summary>
	Number,

	/// <summary>The list is a table.</summary>
	Table
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;list&gt;</c> tag.
/// </summary>
public interface IListTagDocumentationNode : ITagDocumentationNode
{
	#region Properties
	/// <summary>The raw value of the list type.</summary>
	/// <remarks>This is usually the value of the <c>type</c> attribute.</remarks>
	string? ListTypeRaw { get; }

	/// <summary>The type of the list.</summary>
	ListTagType ListType { get; }
	#endregion
}

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;listheader&gt;</c> tag.
/// </summary>
public interface IListHeaderTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;item&gt;</c> tag.
/// </summary>
public interface IItemTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;term&gt;</c> tag.
/// </summary>
public interface ITermTagDocumentationNode : ITagDocumentationNode { }

/// <summary>
/// 	Represents a documentation node that represents the <c>&lt;description&gt;</c> tag.
/// </summary>
public interface IDescriptionTagDocumentationNode : ITagDocumentationNode { }
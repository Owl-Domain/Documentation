namespace OwlDomain.Documentation.Tests;

/// <summary></summary>
public sealed class SimpleTestType
{
	#region Nested types
	/// <summary></summary>
	public sealed class NestedTestType { }
	#endregion

	#region Fields
	/// <summary></summary>
	public int SomeField;

	/// <summary></summary>
	public const int SomeConstant = 1;
	#endregion

	#region Properties
	/// <summary></summary>
	public int SomeProperty { get; }

	/// <summary></summary>
	public int this[int value] => value;
	#endregion

	#region Events
	/// <summary></summary>
	public event EventHandler? SomeEvent;
	#endregion

	#region Constructors
	/// <summary></summary>
	public SimpleTestType() { }

	/// <summary></summary>
	public SimpleTestType(int _) { }

	/// <summary></summary>
	static SimpleTestType() { }
	#endregion
}

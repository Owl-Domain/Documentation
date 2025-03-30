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

#pragma warning disable CA1822
	#region Methods
	/// <summary></summary>
	public void OutMethod(out int value) => value = 1;

	/// <summary></summary>
	public void InMethod(in int Get_WithConstructor_ReturnsExpectedId) { }

	/// <summary></summary>
	public void RefMethod(ref int _) { }

	/// <summary></summary>
	public void MethodWithParameter(int _) { }

	/// <summary></summary>
	public unsafe void MethodWithPointer(int* _) { }

	/// <summary></summary>
	public void ParameterlessMethod() { }
	#endregion
#pragma warning restore CA1822
}

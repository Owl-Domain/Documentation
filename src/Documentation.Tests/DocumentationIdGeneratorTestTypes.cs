using System.Numerics;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.EventHandlers;

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
	public void InMethod(in int _) { }

	/// <summary></summary>
	public void RefMethod(ref int _) { }

	/// <summary></summary>
	public void MethodWithParameter(int _) { }

	/// <summary></summary>
	public unsafe void MethodWithPointer(int* _) { }

	/// <summary></summary>
	public void ParameterlessMethod() { }

	/// <summary></summary>
	public void GenericMethod<T>() { }

	/// <summary></summary>
	public void GenericMethod<T1, T2>() { }

	/// <summary></summary>
	public void MethodWithGenericParameter(List<int> _) { }

	/// <summary></summary>
	public void MethodWithArray(int[] _) { }

	/// <summary></summary>
	public void MethodWith2dArray(int[,] _) { }
	#endregion
#pragma warning restore CA1822

	#region Operators
	/// <summary></summary>
	public static implicit operator int(SimpleTestType _) => 1;

	/// <summary></summary>
	public static explicit operator byte(SimpleTestType _) => 1;

	/// <summary></summary>
	public static int operator +(SimpleTestType _1, int _2) => 1;

	/// <summary></summary>
	public static int operator checked +(SimpleTestType _1, int _2) => 1;

	/// <summary></summary>
	public static bool operator true(SimpleTestType _) => true;

	/// <summary></summary>
	public static bool operator false(SimpleTestType _) => false;
	#endregion
}

/// <summary></summary>
public sealed class GenericTestType<T> { }

/// <summary></summary>
public sealed class GenericTestType<T1, T2> { }
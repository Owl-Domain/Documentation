namespace OwlDomain.Documentation.Tests;

public sealed class SimpleTestType
{
	public sealed class NestedTestType
	{

	}

	public int SomeField;
	public const int SomeConstant = 1;

	public int SomeProperty { get; }
	public int this[int value] => value;

	public event EventHandler? SomeEvent;
}

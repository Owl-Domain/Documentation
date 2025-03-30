namespace OwlDomain.Documentation.Tests;

[TestClass]
public sealed class DocumentationIdGeneratorTests
{
	#region Get(Type) tests
	[TestMethod]
	public void Get_WithSimpleClassType_ReturnsExpectedId()
	{
		// Arrange
		Type type = typeof(SimpleTestType);
		string expected = $"T:{type.FullName}";

		DocumentationIdGenerator sut = new();

		// Act
		string result = sut.Get(type);

		// Assert
		Assert.That.AreEqual(result, expected);
	}

	[TestMethod]
	public void Get_WithNestedClassType_ReturnsExpectedId()
	{
		// Arrange
		Type type = typeof(SimpleTestType.NestedTestType);
		string expected = $"T:{type.DeclaringType?.FullName}.{type.Name}";

		DocumentationIdGenerator sut = new();

		// Act
		string result = sut.Get(type);

		// Assert
		Assert.That.AreEqual(result, expected);
	}

	[DataRow(typeof(byte), "T:System.Byte"), DataRow(typeof(sbyte), "T:System.SByte")]
	[DataRow(typeof(ushort), "T:System.UInt16"), DataRow(typeof(short), "T:System.Int16")]
	[DataRow(typeof(uint), "T:System.UInt32"), DataRow(typeof(int), "T:System.Int32")]
	[DataRow(typeof(ulong), "T:System.UInt64"), DataRow(typeof(long), "T:System.Int64")]
	[DataRow(typeof(float), "T:System.Single"), DataRow(typeof(double), "T:System.Double")]
	[DataRow(typeof(char), "T:System.Char"), DataRow(typeof(string), "T:System.String")]
	[DataRow(typeof(object), "T:System.Object"), DataRow(typeof(void), "T:System.Void")]
	[TestMethod]
	public void Get_WithIntrinsicType_ReturnsExpectedId(Type type, string expected)
	{
		// Arrange
		DocumentationIdGenerator sut = new();

		// Act
		string result = sut.Get(type);

		// Assert
		Assert.That.AreEqual(result, expected);
	}
	#endregion

	#region Get(FieldInfo) tests
	[TestMethod]
	public void Get_WithField_ReturnsExpectedId()
	{
		// Arrange
		Type type = typeof(SimpleTestType);
		FieldInfo? field = type.GetField(nameof(SimpleTestType.SomeField));
		string expected = $"F:{type.FullName}.{field?.Name}";

		DocumentationIdGenerator sut = new();

		// Arrange assert
		Assert.IsConclusiveIf.IsNotNull(field);

		// Act
		string result = sut.Get(field);

		// Assert
		Assert.That.AreEqual(result, expected);
	}

	[TestMethod]
	public void Get_WithConstant_ReturnsExpectedId()
	{
		// Arrange
		Type type = typeof(SimpleTestType);
		FieldInfo? constant = type.GetField(nameof(SimpleTestType.SomeConstant));
		string expected = $"F:{type.FullName}.{constant?.Name}";

		DocumentationIdGenerator sut = new();

		// Arrange assert
		Assert.IsConclusiveIf.IsNotNull(constant);

		// Act
		string result = sut.Get(constant);

		// Assert
		Assert.That.AreEqual(result, expected);
	}
	#endregion

	#region Get(PropertyInfo) tests
	[TestMethod]
	public void Get_WithProperty_ReturnsExpectedId()
	{
		// Arrange
		Type type = typeof(SimpleTestType);
		PropertyInfo? property = type.GetProperty(nameof(SimpleTestType.SomeProperty));
		string expected = $"P:{type.FullName}.{property?.Name}";

		DocumentationIdGenerator sut = new();

		// Arrange assert
		Assert.IsConclusiveIf.IsNotNull(property);

		// Act
		string result = sut.Get(property);

		// Assert
		Assert.That.AreEqual(result, expected);
	}

	[TestMethod]
	public void Get_WithIndexer_ReturnsExpectedId()
	{
		// Arrange
		Type type = typeof(SimpleTestType);
		PropertyInfo? indexer = type.GetProperties().Single(p => p.GetIndexParameters().Length > 0);
		string expected = $"P:{type.FullName}.Item(System.Int32)";

		DocumentationIdGenerator sut = new();

		// Arrange assert
		Assert.IsConclusiveIf.IsNotNull(indexer);

		// Act
		string result = sut.Get(indexer);

		// Assert
		Assert.That.AreEqual(result, expected);
	}
	#endregion

	#region Get(EventInfo) tests
	[TestMethod]
	public void Get_WithEvent_ReturnsExpectedId()
	{
		// Arrange
		Type type = typeof(SimpleTestType);
		EventInfo? @event = type.GetEvent(nameof(SimpleTestType.SomeEvent));
		string expected = $"E:{type.FullName}.{@event?.Name}";

		DocumentationIdGenerator sut = new();

		// Arrange assert
		Assert.IsConclusiveIf.IsNotNull(@event);

		// Act
		string result = sut.Get(@event);

		// Assert
		Assert.That.AreEqual(result, expected);
	}
	#endregion

	#region GetForNamespace tests
	[DataRow("Simple", "N:Simple")]
	[DataRow("Nested.Namespace", "N:Nested.Namespace")]
	[TestMethod]
	public void GetForNamespace_WithNamespace_ReturnsExpectedId(string @namespace, string expected)
	{
		// Arrange
		DocumentationIdGenerator sut = new();

		// Act
		string result = sut.GetForNamespace(@namespace);

		// Assert
		Assert.That.AreEqual(result, expected);
	}

	[TestMethod]
	public void GetForNamespace_WithWhitespace_ThrowsArgumentException()
	{
		// Arrange
		const string value = "name space";
		const string expectedParameterName = "namespace";

		DocumentationIdGenerator sut = new();

		// Act
		void Act() => sut.GetForNamespace(value);

		// Assert
		Assert.That
			.ThrowsExactException(Act, out ArgumentException exception)
			.AreEqual(exception.ParamName, expectedParameterName);
	}
	#endregion

	#region GetForError tests
	[TestMethod]
	public void GetForError_WithError_ReturnsExpectedId()
	{
		// Arrange
		const string error = "error message";
		const string expected = "!:error message";

		DocumentationIdGenerator sut = new();

		// Act
		string result = sut.GetForError(error);

		// Assert
		Assert.That.AreEqual(result, expected);
	}
	#endregion
}

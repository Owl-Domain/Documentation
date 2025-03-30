namespace OwlDomain.Documentation;

/// <summary>
/// 	Represents a generator for documentation comment ids.
/// </summary>
public sealed class DocumentationIdGenerator : IDocumentationIdGenerator
{
	#region Methods
	/// <inheritdoc/>
	public string Get(Type type)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc/>
	public string Get(FieldInfo field)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc/>
	public string Get(PropertyInfo property)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc/>
	public string Get(MethodInfo method)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc/>
	public string Get(EventInfo @event)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc/>
	public string GetForNamespace(string @namespace)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc/>
	public string GetForError(string error)
	{
		throw new NotImplementedException();
	}
	#endregion
}

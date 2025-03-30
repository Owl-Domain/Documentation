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
		StringBuilder builder = new("T:");
		AppendType(builder, type);

		return builder.ToString();
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
		if (@namespace.Any(char.IsWhiteSpace))
			throw new ArgumentException($"The given namespace ({@namespace}) contains whitespace characters.", nameof(@namespace));

		return $"N:{@namespace}";
	}

	/// <inheritdoc/>
	public string GetForError(string error)
	{
		// Note(Nightowl): Are errors allowed to contain white space?

		return $"!:{error}";
	}
	#endregion

	#region Helpers
	private void AppendType(StringBuilder builder, Type type)
	{
		if (type.DeclaringType is not null)
		{
			AppendType(builder, type.DeclaringType);
			builder.Append('.');
		}
		else if (type.Namespace is not null)
		{
			builder.Append(type.Namespace);
			builder.Append('.');
		}

		builder.Append(type.Name);
	}
	#endregion
}

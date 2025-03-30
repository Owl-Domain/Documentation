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
		StringBuilder builder = new("F:");
		AppendType(builder, field.DeclaringType);

		builder.Append('.');
		AppendName(builder, field.Name);

		return builder.ToString();
	}

	/// <inheritdoc/>
	public string Get(PropertyInfo property)
	{
		StringBuilder builder = new("P:");
		AppendType(builder, property.DeclaringType);

		builder.Append('.');
		AppendName(builder, property.Name);

		// Note(Nightowl): Check for indexer;
		ParameterInfo[] parameters = property.GetIndexParameters();

		if (parameters.Length > 0)
			AppendParameters(builder, parameters);

		return builder.ToString();
	}

	/// <inheritdoc/>
	public string Get(MethodInfo method)
	{
		StringBuilder builder = new("M:");
		AppendType(builder, method.DeclaringType);

		builder.Append('.');
		AppendName(builder, method.Name);

		ParameterInfo[] parameters = method.GetParameters();

		if (parameters.Length > 0)
			AppendParameters(builder, parameters);

		return builder.ToString();
	}

	/// <inheritdoc/>
	public string Get(ConstructorInfo constructor)
	{
		StringBuilder builder = new("M:");
		AppendType(builder, constructor.DeclaringType);

		builder.Append('.');
		AppendName(builder, constructor.Name);

		ParameterInfo[] parameters = constructor.GetParameters();

		if (parameters.Length > 0)
			AppendParameters(builder, parameters);

		return builder.ToString();
	}

	/// <inheritdoc/>
	public string Get(EventInfo @event)
	{
		StringBuilder builder = new("E:");
		AppendType(builder, @event.DeclaringType);

		builder.Append('.');
		AppendName(builder, @event.Name);

		return builder.ToString();
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

		AppendName(builder, type.Name);
	}
	private void AppendParameter(StringBuilder builder, ParameterInfo parameter)
	{
		AppendType(builder, parameter.ParameterType);
	}
	private void AppendParameters(StringBuilder builder, IEnumerable<ParameterInfo> parameters)
	{
		builder.Append('(');

		bool hadFirst = false;
		foreach (ParameterInfo parameter in parameters)
		{
			if (hadFirst)
				builder.Append(',');
			else
				hadFirst = true;

			AppendParameter(builder, parameter);
		}

		builder.Append(')');
	}
	private void AppendName(StringBuilder builder, string name)
	{
		if (name.Contains('.') is false)
		{
			builder.Append(name);
			return;
		}

		foreach (char ch in name)
			builder.Append(ch is '.' ? '#' : ch);
	}
	#endregion
}

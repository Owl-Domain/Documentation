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
	public string Get(MethodBase method)
	{
		StringBuilder builder = new("M:");
		AppendType(builder, method.DeclaringType);

		builder.Append('.');
		AppendName(builder, method.Name);

		if (method.IsGenericMethod)
		{
			Type[] genericArguments = method.GetGenericArguments();

			builder
			.Append("``")
			.Append(genericArguments.Length);
		}

		ParameterInfo[] parameters = method.GetParameters();

		if (parameters.Length > 0)
			AppendParameters(builder, parameters);

		return builder.ToString();
	}

	/// <inheritdoc/>
	public string Get(MethodInfo method) => Get(method as MethodBase);

	/// <inheritdoc/>
	public string Get(ConstructorInfo constructor) => Get(constructor as MethodBase);

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
		if (TryAppendConstructedGeneric(builder, type))
			return;

		if (TryAppendSpecialType(builder, type))
			return;

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
	private bool TryAppendConstructedGeneric(StringBuilder builder, Type type)
	{
		if (type.IsConstructedGenericType is false)
			return false;

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

		AppendName(builder, type.Name.AsSpan(0, type.Name.Length - 2));

		Type[] arguments = type.GetGenericArguments();
		AppendGenericArguments(builder, arguments);

		return true;
	}
	private bool TryAppendSpecialType(StringBuilder builder, Type type)
	{
		if (type.IsByRef)
		{
			Type? elementType = type.GetElementType();
			Debug.Assert(elementType is not null);

			AppendType(builder, elementType);
			builder.Append('@');

			return true;
		}

		if (type.IsPointer)
		{
			Type? elementType = type.GetElementType();
			Debug.Assert(elementType is not null);

			AppendType(builder, elementType);
			builder.Append('*');

			return true;
		}

		return false;
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
	private void AppendGenericArguments(StringBuilder builder, Type[] arguments)
	{
		builder.Append('{');

		bool hadFirst = false;
		foreach (Type argument in arguments)
		{
			if (hadFirst)
				builder.Append(',');
			else
				hadFirst = true;

			AppendType(builder, argument);
		}

		builder.Append('}');
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
	private void AppendName(StringBuilder builder, ReadOnlySpan<char> name)
	{
		foreach (char ch in name)
			builder.Append(ch is '.' ? '#' : ch);
	}
	#endregion
}

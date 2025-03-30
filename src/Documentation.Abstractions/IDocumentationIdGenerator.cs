namespace OwlDomain.Documentation;

/// <summary>
/// 	Represents a generator for documentation comment ids.
/// </summary>
public interface IDocumentationIdGenerator
{
	#region Methods
	/// <summary>Gets a documentation comment id for the given <paramref name="type"/>.</summary>
	/// <param name="type">The type to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="type"/>.</returns>
	string Get(Type type);

	/// <summary>Gets a documentation comment id for the given <paramref name="member"/>.</summary>
	/// <param name="member">The member to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="member"/>.</returns>
	string Get(MemberInfo member);

	/// <summary>Gets a documentation comment id for the given <paramref name="field"/>.</summary>
	/// <param name="field">The field to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="field"/>.</returns>
	string Get(FieldInfo field);

	/// <summary>Gets a documentation comment id for the given <paramref name="property"/>.</summary>
	/// <param name="property">The property to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="property"/>.</returns>
	string Get(PropertyInfo property);

	/// <summary>Gets a documentation comment id for the given <paramref name="method"/>.</summary>
	/// <param name="method">The method to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="method"/>.</returns>
	string Get(MethodBase method);

	/// <summary>Gets a documentation comment id for the given <paramref name="method"/>.</summary>
	/// <param name="method">The method to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="method"/>.</returns>
	string Get(MethodInfo method);

	/// <summary>Gets a documentation comment id for the given <paramref name="constructor"/>.</summary>
	/// <param name="constructor">The constructor to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="constructor"/>.</returns>
	string Get(ConstructorInfo constructor);

	/// <summary>Gets a documentation comment id for the given <paramref name="event"/>.</summary>
	/// <param name="event">The event to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="event"/>.</returns>
	string Get(EventInfo @event);

	/// <summary>Gets a documentation comment id for the given <paramref name="namespace"/>.</summary>
	/// <param name="namespace">The namespace to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="namespace"/>.</returns>
	/// <exception cref="ArgumentException">Thrown if the given <paramref name="namespace"/> contains white space characters.</exception>
	string GetForNamespace(string @namespace);

	/// <summary>Gets a documentation comment id for the given <paramref name="error"/> message.</summary>
	/// <param name="error">The error message to get the documentation comment id for.</param>
	/// <returns>The documentation comment id for the given <paramref name="error"/> message.</returns>
	string GetForError(string error);
	#endregion
}

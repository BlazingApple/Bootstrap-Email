namespace BlazingApple.BootstrapEmail.Services;

/// <summary>Compile an HTML string laden with Bootstrap classes into email-safe HTML.</summary>
public interface IBootstrapEmailBuilder
{
	/// <summary>
	/// Compile standard html with bootstrap classes to be email-safe.
	/// </summary>
	/// <param name="htmlEmailBody">The html string <em>with bootstrap classes</em> to be compiled</param>
	/// <returns>Email safe html string.</returns>
	string Compile(string htmlEmailBody);
}
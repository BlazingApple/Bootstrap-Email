namespace BlazingApple.BootstrapEmail.Services;

/// <summary>Compile an HTML string laden with Bootstrap classes into email-safe HTML.</summary>
public class BootstrapEmailBuilder : IBootstrapEmailBuilder
{
	/// <summary>DI Constructor.</summary>
	public BootstrapEmailBuilder()
	{

	}

	/// <inheritdoc/>
	public string Compile(string htmlEmailBody)
	{
		return htmlEmailBody;
	}
}

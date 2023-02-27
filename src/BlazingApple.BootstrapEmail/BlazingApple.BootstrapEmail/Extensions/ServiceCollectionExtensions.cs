using BlazingApple.BootstrapEmail.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingApple.BootstrapEmail;
public static class ServiceCollectionExtensions
{
	/// <summary>
	/// Add the services required for translating Blazor components to email-safe HTML.
	/// </summary>
	/// <param name="services"><see cref="IServiceCollection"/></param>
	/// <returns>Fluent API, <see cref="IServiceCollection"/></returns>
	public static IServiceCollection AddBootstrapEmailer(this IServiceCollection services)
	{
		services.AddScoped<IBootstrapEmailBuilder, BootstrapEmailBuilder>();
		return services;
	}
}

using System.Net.Http;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// HttpClientBuilderExtensions
/// </summary>
public static class HttpClientBuilderExtensions
{
    /// <summary>
    /// Configures the HTTP client.
    /// </summary>
    /// <typeparam name="TDep1">The type of the dep1.</typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="configureClient">The configure client.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to configure the client.</returns>
    public static IHttpClientBuilder? ConfigureHttpClient<TDep1>(this IHttpClientBuilder builder, Action<TDep1, HttpClient> configureClient) 
        where TDep1 : class
        => builder.ConfigureHttpClient((sp, client) => configureClient?.Invoke(sp.GetRequiredService<TDep1>(), client));

    /// <summary>
    /// Configures the HTTP client.
    /// </summary>
    /// <typeparam name="TDep1">The type of the dep1.</typeparam>
    /// <typeparam name="TDep2">The type of the dep2.</typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="configureClient">The configure client.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to configure the client.</returns>
    public static IHttpClientBuilder ConfigureHttpClient<TDep1, TDep2>(this IHttpClientBuilder builder, Action<TDep1, TDep2, HttpClient> configureClient)
        where TDep1 : class
        where TDep2 : class
        => builder.ConfigureHttpClient((sp, client) => configureClient?.Invoke(
            sp.GetRequiredService<TDep1>(),
            sp.GetRequiredService<TDep2>(),
            client));

    /// <summary>
    /// Configures the HTTP client.
    /// </summary>
    /// <typeparam name="TDep1">The type of the dep1.</typeparam>
    /// <typeparam name="TDep2">The type of the dep2.</typeparam>
    /// <typeparam name="TDep3">The type of the dep3.</typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="configureClient">The configure client.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to configure the client.</returns>
    public static IHttpClientBuilder ConfigureHttpClient<TDep1, TDep2, TDep3>(this IHttpClientBuilder builder, Action<TDep1, TDep2, TDep3, HttpClient> configureClient)
        where TDep1 : class
        where TDep2 : class
        where TDep3 : class
        => builder.ConfigureHttpClient((sp, client) => configureClient?.Invoke(
            sp.GetRequiredService<TDep1>(),
            sp.GetRequiredService<TDep2>(),
            sp.GetRequiredService<TDep3>(),
            client));

    /// <summary>
    /// Configures the HTTP client.
    /// </summary>
    /// <typeparam name="TDep1">The type of the dep1.</typeparam>
    /// <typeparam name="TDep2">The type of the dep2.</typeparam>
    /// <typeparam name="TDep3">The type of the dep3.</typeparam>
    /// <typeparam name="TDep4">The type of the dep4.</typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="configureClient">The configure client.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to configure the client.</returns>
    public static IHttpClientBuilder ConfigureHttpClient<TDep1, TDep2, TDep3, TDep4>(this IHttpClientBuilder builder, Action<TDep1, TDep2, TDep3, TDep4, HttpClient> configureClient)
        where TDep1 : class
        where TDep2 : class
        where TDep3 : class
        where TDep4 : class
        => builder.ConfigureHttpClient((sp, client) => configureClient?.Invoke(
            sp.GetRequiredService<TDep1>(),
            sp.GetRequiredService<TDep2>(),
            sp.GetRequiredService<TDep3>(),
            sp.GetRequiredService<TDep4>(),
            client));

    /// <summary>
    /// Configures the HTTP client.
    /// </summary>
    /// <typeparam name="TDep1">The type of the dep1.</typeparam>
    /// <typeparam name="TDep2">The type of the dep2.</typeparam>
    /// <typeparam name="TDep3">The type of the dep3.</typeparam>
    /// <typeparam name="TDep4">The type of the dep4.</typeparam>
    /// <typeparam name="TDep5">The type of the dep5.</typeparam>
    /// <param name="builder">The builder.</param>
    /// <param name="configureClient">The configure client.</param>
    /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to configure the client.</returns>
    public static IHttpClientBuilder ConfigureHttpClient<TDep1, TDep2, TDep3, TDep4, TDep5>(this IHttpClientBuilder builder, Action<TDep1, TDep2, TDep3, TDep4, TDep5, HttpClient> configureClient)
        where TDep1 : class
        where TDep2 : class
        where TDep3 : class
        where TDep4 : class
        where TDep5 : class
        => builder.ConfigureHttpClient((sp, client) => configureClient?.Invoke(
            sp.GetRequiredService<TDep1>(),
            sp.GetRequiredService<TDep2>(),
            sp.GetRequiredService<TDep3>(),
            sp.GetRequiredService<TDep4>(),
            sp.GetRequiredService<TDep5>(),
            client));
}

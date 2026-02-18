namespace CacheService.Configuration;

/// <summary>
/// Configuration for <see cref="ICacheService" />.
/// </summary>
public class CacheServiceConfiguration
{
    /// <summary>
    /// Gets or sets the <see cref="CacheServiceOptions" /> to use by default in <see cref="ICacheService" /> GetOrSetAsync method.
    /// </summary>
    public CacheServiceOptions DefaultOptions { get; set; } = new CacheServiceOptions();

    /// <summary>
    /// Gets if you want to use <see cref="Microsoft.Extensions.Caching.Memory.IMemoryCache" /> inside <see cref="ICacheService" />.
    /// </summary>
     [Obsolete("Use DefaultOptions.UseMemoryCache instead.")]
    public bool UseMemoryCache => DefaultOptions.UseMemoryCache;

    /// <summary>
    /// Gets if you want to use <see cref="Microsoft.Extensions.Caching.Distributed.IDistributedCache" /> inside <see cref="ICacheService" />.
    /// </summary>
    [Obsolete("Use DefaultOptions.UseDistributedCache instead.")]
    public bool UseDistributedCache => DefaultOptions.UseDistributedCache;

    /// <summary>
    /// Gets or sets how you want to use the background process to automatically update your cache values.
    /// </summary>
    /// <remarks>Default value is <see cref="BackgroundJobMode.HostedService" />.</remarks>
    public BackgroundJobMode BackgroundJobMode { get; set; } = BackgroundJobMode.HostedService;

    /// <summary>
    /// Gets or sets the background process execution interval.
    /// </summary>
    /// <remarks>Default value is One minute.</remarks>
    public TimeSpan BackgroundJobInterval { get; set; } = TimeSpan.FromMinutes(1);

    /// <summary>
    /// Gets or sets if the background job should ignore exceptions.
    /// </summary>
    /// <remarks>Default value is false.</remarks>
    public bool BackgroundJobIgnoreExceptions { get; set; } = false;
}

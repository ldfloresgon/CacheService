namespace CacheService;

/// <summary>
/// Provides the cache options for an entry in <see cref="ICacheService" />.
/// </summary>
public class CacheServiceOptions
{
    /// <summary>
    /// Cache options for <see cref="Microsoft.Extensions.Caching.Distributed.IDistributedCache"/> registry.
    /// </summary>
    public CacheOptions Distributed { get; set; } = new();

    /// <summary>
    /// Cache options for <see cref="Microsoft.Extensions.Caching.Memory.IMemoryCache" /> registry.
    /// </summary>
    public CacheOptions Memory { get; set; } = new();

    /// <summary>
    /// Force read value from value getter and update all caches.
    /// </summary>
    public bool ForceRefresh { get; set; } = false;

    /// <summary>
    /// Gets or sets if you want to use <see cref="Microsoft.Extensions.Caching.Memory.IMemoryCache" /> inside <see cref="ICacheService" />.
    /// </summary>
    /// <remarks>Default value is true.</remarks>
    public bool UseMemoryCache { get; set; } = true;

    /// <summary>
    /// Gets or sets if you want to use <see cref="Microsoft.Extensions.Caching.Distributed.IDistributedCache" /> inside <see cref="ICacheService" />.
    /// </summary>
    /// // <remarks>Default value is <see cref="true" />.</remarks>
    public bool UseDistributedCache { get; set; } = true;
}

namespace GCLab;

using Microsoft.Extensions.Caching.Memory;
using System.Runtime.Caching;

// =====================================================
// 2) Cache estático sem política de expiração
// =====================================================
static class GlobalCache
{

    MemoryCache cache = new MemoryCache(new MemoryCacheOptions());

    private static readonly List<byte[]> _cache = new();
    public static void Add(byte[] data) => _cache.Add(data);     
}

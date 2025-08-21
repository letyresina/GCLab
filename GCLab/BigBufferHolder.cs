using Microsoft.Extensions.Caching.Memory;
namespace GCLab;
// =====================================================
// 2) LOH + cache estático sem política de expiração
// =====================================================
static class BigBufferHolder
{
    private static readonly MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
    public static byte[] Run()
    {
        var data = new byte[1000]; 
        _cache.Set("big-buffer", data); // armazena no cache
        return data;
    }
}
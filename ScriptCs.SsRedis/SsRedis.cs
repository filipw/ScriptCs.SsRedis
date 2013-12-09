using ScriptCs.Contracts;
using ServiceStack.Redis;

namespace ScriptCs.SsRedis
{
    public class SsRedis : IScriptPackContext
    {
        public SsRedis()
        {
        }

        public IRedisClient Host()
        {
            var client = new RedisClient();
            return client;
        }

        public IRedisClient Host(string host)
        {
            var client = new RedisClient(host);
            return client;
        }

        public IRedisClient Host(string[] hosts)
        {
            var manager = new PooledRedisClientManager(hosts);
            return manager.GetClient();
        }
    }
}
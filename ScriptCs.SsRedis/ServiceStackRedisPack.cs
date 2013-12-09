using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptCs.Contracts;

namespace ScriptCs.SsRedis
{
    public class ServiceStackRedisPack : IScriptPack
    {
        public void Initialize(IScriptPackSession session)
        {
            session.ImportNamespace("ScriptCs.SsRedis");
            session.ImportNamespace("ServiceStack.Redis");
            session.ImportNamespace("ServiceStack.Redis.Generic");
            session.ImportNamespace("ServiceStack.Redis.Messaging");
            session.ImportNamespace("ServiceStack.Text");
            session.ImportNamespace("ServiceStack.Text.Json");
        }

        public IScriptPackContext GetContext()
        {
            return new SsRedis();
        }

        public void Terminate()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Couchbase.Configuration.Client;
using Couchbase;

namespace CouchBase_Lab360.App_Start
{
    public class CouchbaseConfig
    {
        public static void setup()
        {
            var Config = new ClientConfiguration
            {
                Servers = new List<Uri>
                {
                    new Uri("couchbase://127.0.0.1")
                },
                UseSsl = false,
                BucketConfigs = new Dictionary<string, BucketConfiguration>
                {
                    {"Customer360", new BucketConfiguration

                        {
                            BucketName = "Customer360",
                            Password = "Tdurgaprasad59",
                            UseSsl = false

                        }
                    }
                }
            };
            ClusterHelper.Initialize(Config);
        }

        public static void cleanup()
        {
            ClusterHelper.Close();
        }

    }
}
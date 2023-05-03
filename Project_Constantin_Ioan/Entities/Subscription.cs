using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Constantin_Ioan.Entities
{
    [Serializable]
    public class Subscription
    {
        public long SubscriptionId { get; set; }
        public List<Client> Client{ get; set; }
        public List<ExtraOption> ExtraOptions { get; set; }
        public Subscription()
        {

            Client = new List<Client>();
            ExtraOptions = new List<ExtraOption>();
        }
        public Subscription(List<ExtraOption> extraOptions)
        {
            ExtraOptions = extraOptions;
        }
        public Subscription(List<Client> client)
        {
            Client = client;
        }
        public Subscription(List<Client> client, List<ExtraOption> extraOptions)
        {
            Client = client;
            ExtraOptions = extraOptions;
        }

    }
}

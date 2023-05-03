using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Constantin_Ioan.Entities
{
    [Serializable]
    public class ExtraOption
    {
        public long ExtraOptionId { get; set; }
        public string ExtraOptionName { get; set; }
        public string Price { get; set; }
        public DateTime Created { get; set; }
        public string Benefits { get; set; }
        public ExtraOption() { }
        public ExtraOption(string extraOptionName, string price, DateTime created, string benefits)
        {
            ExtraOptionName = extraOptionName;
            Price = price;
            Created = created;
            Benefits = benefits;
        }
        public ExtraOption(long extraOptionId,string extraOptionName, string price, DateTime created, string benefits):this(extraOptionName,price,created,benefits)
        {
            ExtraOptionId = extraOptionId;
        }
    }
}

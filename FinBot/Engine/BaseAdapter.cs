using System.Xml.Linq;
using Syn.Bot.Siml;
using Syn.Bot.Siml.Interfaces;

namespace FinBot.Engine
{
    public abstract class BaseAdapter : IAdapter
    {
        public bool IsRecursive => true;

        private string Name
        {
            get { return GetType().Name.Replace("Adapter", string.Empty); }
        }

        public XName TagName
        {
            get
            {
                XNamespace ns = "http://finbot.com/namespace#finbot";
                return ns + Name;
            }
        }

        public abstract string Evaluate(Context context);
    }
}
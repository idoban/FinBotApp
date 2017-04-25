using System.Collections.Generic;
using System.Linq;
using Syn.Bot.Siml.Interfaces;

namespace FinBot.Engine
{
    public interface IAdaptersRepository
    {
        IAdapter[] GetAdapters();
    }

    public class AdaptersRepository : IAdaptersRepository
    {
        private readonly IAdapter[] _adapters;

        public AdaptersRepository(IEnumerable<IAdapter> adapters)
        {
            _adapters = adapters.ToArray();
        }
        public IAdapter[] GetAdapters()
        {
            return _adapters;
        }
    }
}
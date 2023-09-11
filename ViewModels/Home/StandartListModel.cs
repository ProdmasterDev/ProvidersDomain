using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.ViewModels.Home
{
    public class StandartListModel
    {
        public List<IGrouping<string, StandartModel>> Standarts { get; set; } = new();
        public bool CollapseCategories { get; set; } = true;
    }
}

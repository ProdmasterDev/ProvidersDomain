using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.ViewModels.Home
{
    public class StandartModel
    {
        public long Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Категория")]
        public string CategoryName { get; set; }
        [DisplayName("Ед. изм.")]
        public string UnitName { get; set; }
    }
}

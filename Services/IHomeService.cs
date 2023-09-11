using ProvidersDomain.Models;
using ProvidersDomain.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.Services
{
    public interface IHomeService
    {
        public Task<StandartListModel> GetStandartListModel();
        public Task<StandartListModel> GetStandartListModel(string searchString);
        public Task<Standart> GetStandart(long id);
    }
}

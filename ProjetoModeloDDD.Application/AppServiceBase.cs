using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<Tentity> : IDisposable, IAppServiceBase<Tentity> where Tentity : class
    {
        private readonly IServiceBase<Tentity> _serviceBase;

        public AppServiceBase(IServiceBase<Tentity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public void Add(Tentity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public Tentity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(Tentity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void updade(Tentity obj)
        {
            _serviceBase.updade(obj);
        }
    }
}

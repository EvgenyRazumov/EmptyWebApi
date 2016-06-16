using Core.Entities;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class CountryService : ICountryService
    {
        private readonly IAppUnitOfWork _uow;
        private readonly IGenericRepository<Country> _countryRepository;

        public CountryService(IAppUnitOfWork uow)
        {
            _uow = uow;
            _countryRepository = _uow.GetRepository<Country>();
        }

        public void Create(Country entity)
        {
            _countryRepository.Create(entity);
            _uow.Save();
        }

        public IList<Country> GetAll()
        {
            return _countryRepository.GetAll().ToList();
        }

        public void Update(Country entity)
        {
            _countryRepository.Update(entity);
            _uow.Save();
        }
    }
}

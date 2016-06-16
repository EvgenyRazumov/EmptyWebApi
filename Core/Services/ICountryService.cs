using Core.Entities;
using System.Collections.Generic;

namespace Core.Services
{
    public interface ICountryService
    {
        IList<Country> GetAll();

        void Create(Country entity);

        void Update(Country entity);
    }
}

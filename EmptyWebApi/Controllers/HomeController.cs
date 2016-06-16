using Core.Services;
using System.Linq;
using System.Web.Http;

namespace EmptyWebApi.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        private readonly ICountryService _countryService;

        public HomeController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        [Route("getall")]
        public IHttpActionResult GetAll()
        {
            return this.Ok(_countryService.GetAll());
        }

        [HttpGet]
        [Route("create")]
        public IHttpActionResult Create()
        {
            _countryService.Create(new Core.Entities.Country
            {
                Name = "Belarus"
            });

            return this.Ok();
        }

        [HttpGet]
        [Route("update")]
        public IHttpActionResult Update()
        {
            var country = _countryService.GetAll().First();
            country.Name = "Russia";
            _countryService.Update(country);

            return this.Ok();
        }
    }
}

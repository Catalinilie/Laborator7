using System;
using System.Collections.Generic;
using BusinessLayer;
using DataLayer;
using lab7.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IRepository _repository;

        public CitiesController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<City> Get(int id)
        {
            return Ok(this._repository.GetById(new Guid()));
        }

       /* [HttpGet("{id}", Name = "GetByIdPOI")]
        public ActionResult<City> Get(Guid id,Guid idPOI)
        {
            return Ok(this._repository.GetById(id).GetPOIById(idPOI));
        }*/

        [HttpPost]
        public ActionResult<City> Post([FromBody] CityModel cityModel)
        {
            if (cityModel == null)
            {
                return BadRequest();
            }

            City city = new City(cityModel.Name,cityModel.Description,cityModel.Latitude,cityModel.Longitude);
            this._repository.Create(city);

            return CreatedAtRoute("GetById", new { id = city.Id }, city);
        }
    }
}
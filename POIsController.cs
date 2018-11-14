using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using lab7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POIsController : ControllerBase
    {
        private readonly IPOIRepository _repository;

        public POIsController(IPOIRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<POI>> Get()
        {
            return Ok(this._repository.GetPOIs());
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<POI> Get(Guid id)
        {
            return Ok(this._repository.GetById(id));
        }

        [HttpPost]
        public ActionResult<POI> Post([FromBody] POIModel createPOIModel)
        {
            if (createPOIModel == null)
            {
                return BadRequest();
            }

            POI poi = new POI(createPOIModel.Name, createPOIModel.Description);
            this._repository.Create(poi);

            return CreatedAtRoute("GetById", new { id = poi.Id }, poi);
        }
        
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] POIModel createPOIModel)
        {
            if (createPOIModel == null)
            {
                return;
            }

            POI poi = new POI(id, createPOIModel.Name, createPOIModel.Description);
            this._repository.Edit(id, poi);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            POI poi = this._repository.GetById(id);
            this._repository.Delete(poi);
        }

    }
}
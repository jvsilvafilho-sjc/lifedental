using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace app.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customers>> Get()
        {
            return new Customers[] {
                new Customers() {
                                Id = 1,
                                Name = "Nicolas Diogo Cardoso",
                                Street = "Acesso Um",
                                City = "Porto Alegre",
                                State = "RS",
                                Credit_Limit = 475
                },                    
                new Customers() {
                                Id = 2,
                                Name = "Cecilia Olivia Rodrigues",
                                Street = "Rua Sizuka Usuy",
                                City = "Cianorte",
                                State = "PR",
                                Credit_Limit = 3170
                                                   
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Customers> Get(int id) => new Customers[] {
                new Customers() {
                                Id = 1,
                                Name = "Nicolas Diogo Cardoso",
                                Street = "Acesso Um",
                                City = "Porto Alegre",
                                State = "RS",
                                Credit_Limit = 475
                },
                new Customers() {
                                Id = 2,
                                Name = "Cecilia Olivia Rodrigues",
                                Street = "Rua Sizuka Usuy",
                                City = "Cianorte",
                                State = "PR",
                                Credit_Limit = 3170

                }
            }.FirstOrDefault(x => x.Id == id);

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        
        
        private List<Tutorial> _tutorials = new List<Tutorial>
        {
            new Tutorial(1, "Aprende integrales en 5 minutos", 2020, "Integrales desde 0", new Category(1,"Matematica",1,"Matematica para universitarios")),
            new Tutorial(2, "Conectores logicos para textos academicos", 2019, "Proximamente",new Category(2,"Lenguaje",1,"Producción de textos academicos"))
        };
        
        // GET: api/Tutorial
        [HttpGet(Name = "GetTutorial")]
        public IEnumerable<Tutorial> Get()
        {
            return _tutorials;
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "Getx")]
        public Tutorial Get(int id)
        {
            Tutorial? selectedTutorial = null;
            
            foreach (var tutorial in _tutorials)
            {
                if (tutorial.Id == id)
                    selectedTutorial = tutorial;
            }
            
            return selectedTutorial;
        }

        // POST: api/Tutorial
        [HttpPost]
        public IActionResult Post([FromBody] Tutorial tutorial)
        {
            bool isIdUnique = true;
            foreach (var tutorials_item in _tutorials)
            {
                if (tutorial.Id == tutorials_item.Id)
                    isIdUnique = false;
            }

            if (isIdUnique)
            {
                return StatusCode(201);
            }
            else
            {
                return StatusCode(500);
            }

        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tutorial tutorial)
        {
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

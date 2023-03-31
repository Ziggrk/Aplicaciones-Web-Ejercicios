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
    public class CategoryController : ControllerBase
    {

        private List<Category> _categories = new List<Category>
        {
            new Category(1, "Matematica", 1, "Matematica para universitarios"),
            new Category(2, "Lenguaje", 1, "Producción de textos academicos")
        };
        
        // GET: api/Category
        [HttpGet(Name = "GetCategory")]
        public IEnumerable<Category> Get()
        {
            return _categories;
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public Category Get(int id)
        {
            return _categories.Find(category => category.Id == id) ;
        }

        // POST: api/Category
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            bool isIdUnique = true;
            foreach (var categories_item in _categories)
            {
                if (category.Id == categories_item.Id)
                    isIdUnique = false;
            }

            if (isIdUnique)
            {
                _categories.Add(category);
                return StatusCode(201);
            }
            else
            {
                return StatusCode(400);
            }
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
            int indexSearched = _categories.FindIndex( itemCategory => itemCategory.Id == id);
            _categories[indexSearched] = category;
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int indexSearched = _categories.FindIndex( x => x.Id == id);
            if (indexSearched != -1)
                _categories.RemoveAt(indexSearched);
            else return;
        }
    }
}

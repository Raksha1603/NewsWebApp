using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsWebApp.Models;
using Microsoft.EntityFrameworkCore;
using NewsWebApp.Models.Repository;
using NewsWebApp.Models.DataManager;

namespace NewsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class NewsCategoryController : ControllerBase
    {
        private readonly IdRepository<News_Category> db;

        public NewsCategoryController(IdRepository<News_Category> context)
        {
            db = context;
        }


        [HttpGet]

        public IActionResult Get()
        {
            IEnumerable<News_Category> news = db.GetAll();
            return Ok(news);
        }


        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            News_Category news = db.Get(id);

            if (news == null)
            {
                return NotFound("The category Is not Found");
            }

            return Ok(news);
        }

        [HttpPost]
        public IActionResult Post([FromBody] News_Category news)
        {
            if (news == null)
            {
                return BadRequest("No Data Inputed");
            }

            db.Add(news);
            return CreatedAtRoute(
                "Get",
                new { ID = news.CatID },
                news);
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] News_Category news)
        {
            if (news == null)
            {
                return BadRequest("Category does not exist");
            }
            News_Category newstoupdate = db.Get(id);
            if (newstoupdate == null)
            {
                return NotFound("The category Id could not be found");
            }

            db.Update(newstoupdate, news);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            News_Category newscat = db.Get(id);
            if (newscat == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            db.Delete(newscat);
            return NoContent();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WebApplicationCereals.Db;
using WebApplicationCereals.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCereals.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CerealsController : ControllerBase
	{
		CerealsDbContext context;

		public CerealsController() : base()
		{
			context = new(); // ou new CerealsDbContext();
		}
		// GET: api/<CerealsController>
		[HttpGet]
		public IEnumerable<Cereal> Get()
		{
			return context.Cereals.ToList();
		}

		// GET api/<CerealsController>/5
		[HttpGet("{id}")]
		public Cereal Get(int id)
		{
			return context.Cereals.Find(id);
		}

		// POST api/<CerealsController>
		[HttpPost]
		public void Post([FromBody] Cereal value)
		{
			context.Cereals.Add(value);
			context.SaveChanges();
		}

		// PUT api/<CerealsController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
			Cereal? c = context.Cereals.Find(id);
			if(c is Cereal)
			{
				c.Name = value;
				context.SaveChanges();
			}
		}

		// DELETE api/<CerealsController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			//Cereal? c = context.Cereals.Find(id);

			if (context.Cereals.Find(id) is Cereal cereal)
			{
				context.Cereals.Remove(cereal);
				context.SaveChanges();
			}
			
		}
	}
}

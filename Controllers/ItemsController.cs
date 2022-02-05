using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;

namespace Catalog.Controllers
{
	[ApiController]
	[Route("[controller]")] // route same as controller name (/items)
	[Produces("application/json")]
	public class ItemsController : ControllerBase {
		private readonly InMemItemsRepository repository;

		public ItemsController() {
			repository = new InMemItemsRepository();
		}

		
		[HttpGet]
		public IEnumerable<Item> GetItems(){
			var items = repository.GetItems();
			return items;
		}

		// GET /items/{id}
		[HttpGet("{id}")]
		public Item GetItem(Guid id){
			var item = repository.GetItem(id);
			return item;
		}
	}
}
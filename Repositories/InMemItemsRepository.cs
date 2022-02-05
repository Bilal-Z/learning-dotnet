using Catalog.Entities;

namespace Catalog.Repositories
{
	public class InMemItemsRepository {
		private readonly List<Item> items = new()
		{
			new Item {Id= Guid.NewGuid(), Name="Portal Gun", Price = 9, CreatedDate = DateTimeOffset.UtcNow},
			new Item {Id= Guid.NewGuid(), Name="Time Machine", Price = 9, CreatedDate = DateTimeOffset.UtcNow},
			new Item {Id= Guid.NewGuid(), Name="Mech Suit", Price = 9, CreatedDate = DateTimeOffset.UtcNow}
		};

		public IEnumerable<Item> GetItems() {
			return items;
		}

		public Item GetItem(Guid id) {
			return items.Where(item => item.Id == id).SingleOrDefault();
		}

	}
}
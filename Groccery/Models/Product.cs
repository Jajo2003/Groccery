namespace Groccery.Models
{
	public class Product
	{
		public int Id { get; set; }
		public required string Name { get; set; }

		public int Capacity { get; set; }

		public decimal Price { get; set; }

	}
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace dotnet_vite_vuejs.Model
{
	[Table("SanPham")]
	public class Product
	{
		public Product()
		{
		
		}
		[Key]
		public int ProductId { get; set; }
		[Required]
		[StringLength(50)]
		public string Name { get; set; }
		[Required]
		public string Provide { get; set; }
    }
	public class ProductContext : DbContext
	{
		public DbSet<Product> product { set; get; }
		private string connectionString = @"hostname=cmsblog123.mysql.database.azure.comusername=binhnguyenpassword=M@roen4eessl-mode=require";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(connectionString);
        }
    }

}


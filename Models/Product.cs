using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore; // Для DbContext
using Microsoft.EntityFrameworkCore.SqlServer; // Для подключения к SQL Server
using System;

namespace SyncfusionWebApplication1.Models
{
    
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Product()
        {
            Name = ""; // Или другое значение по умолчанию
        }
    }
}

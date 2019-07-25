﻿using ECommerceProject.Models; //DbSet için eklendi.
using Microsoft.EntityFrameworkCore; //DbContext için eklendi.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProject
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            // DB Bağlantısı ve DB Instance'ını ilgilendiren ince ayarlar
            dbContextOptionsBuilder.UseSqlServer("Server=127.0.0.1 ;Database=ECommerce; User Id=sa; Password = 123;"); //internetten string kopyalandı                                                                           
            /* Yukardaki satır yazıldıktan sonra Nuget Package Manager Console açarak 'add-migration Users'
            yazarak ardından 'update-database' yazıyoruz. Böylece veritabanı otomatik oluşuyor. */

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Veritabanını otomatik olarak oluşturur. Buraya özel kurallar yazılır.
            //Database şeması uygulanırken kullanılacak kural setleri burada tanımlanır.
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
    
//Her veritabanının bir DbContext i bulunmalıdır.
// Sql naming conventions a bakabilirsin.
    
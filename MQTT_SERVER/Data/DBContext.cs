using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MQTT_SERVER.hepler;
using MQTT_SERVER.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQTT_SERVER.Data
{
    public class DBContext : DbContext
    {
        public DbSet<RawDatas> RawDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.4.0.9;Database=ComputerVision;MultipleActiveResultSets=true;User Id=sa;Password=shc@1234");
        }
    }
}

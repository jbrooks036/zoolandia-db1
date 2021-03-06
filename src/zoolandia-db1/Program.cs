﻿// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Data.Entity;
// using Microsoft.Data.Entity;
// using System.Core.dll;

namespace zoolandia_db1
{
    public class Program
    {
        public void Main(string[] args)
        {
            // seed the database
        }

        public class Animal
        {
            public Animal(string animalType)
            {

            }
            public int AnimalId { get; set; }
            public string AnimalName { get; set; }
            public float AnimalWeight { get; set; }
        }

        public class AnimalContext : DbContext
        {
            // IDbSet, IQueryable
            public virtual DbSet<Animal> Animals { get; set; }
        }

    }
}

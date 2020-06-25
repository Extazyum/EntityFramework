using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    class DbContextCaster : DbContext
    {


            public DbSet<SpellCaster> SpellCasters { get; set; }
            public DbSet<MagicSpell> MagicSpells { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=RPG.db");
        }

    }


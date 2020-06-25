using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            ICollection<MagicSpell> listSpells = new List<MagicSpell>();
            var mS = new MagicSpell();
            mS.Damage = 10;
            mS.Name = "Fireball";
            listSpells.Add(mS);
            SpellCaster sC = new SpellCaster();
            sC.Name = "Anthonidas";
            sC.Level = 1;
            sC.Spells = listSpells;

            using (var db = new DbContextCaster())
            {
                db.MagicSpells.Add(mS);
                db.SpellCasters.Add(sC);
                db.SaveChanges();
            }

            using (var db = new DbContextCaster())
            {
                var spells = db.MagicSpells.ToList();
                var casters = db.SpellCasters.ToList();
                Console.WriteLine(string.Join("-",spells));
            }


        }
    }
}

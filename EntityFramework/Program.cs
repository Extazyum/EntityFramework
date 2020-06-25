using System;
using System.Collections;
using System.Collections.Generic;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ICollection<MagicSpell> listSpells = new List<MagicSpell>() ;
           MagicSpell mS = new MagicSpell();
           mS.Damage = 10;
           mS.Name = "Fireball";
           listSpells.Add(mS);
           SpellCaster sC = new  SpellCaster();
           sC.Name = "Anthonidas";
           sC.Level = 1;
           sC.Spells = listSpells;

           using (var db = new DbContextCaster())
           {
                db.MagicSpells.Add(mS);
                db.SpellCasters.Add(sC);
                db.SaveChanges();
           } 

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework
{

    class SpellCaster
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Level { get; set; }
        public ICollection<MagicSpell> Spells { get; set; } 
    }
}

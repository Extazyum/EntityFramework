using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework
{

    class MagicSpell
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Damage { get; set; }
    }
}

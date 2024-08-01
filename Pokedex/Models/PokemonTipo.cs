using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

    [Table("PokemonTipo")]
    public class PokemonTipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Numero { get; set; }

        [Key, Column(Order = 1)]
        public int RegiaoId { get; set; }
        [ForeignKey("RegiaoId")]
        public Regiao Regiao { get; set; }

        [Required]
        public int GenroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        
    }

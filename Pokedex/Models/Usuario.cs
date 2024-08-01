using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Pokedex.Models;

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        
        public string UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public IdentityUser ContaUsuario { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [Required]
        [Column(TypeName = "double(5,2)")]
        public double Altura { get; set; }

        [Required]
        [Column(TypeName = "double(7,3)")]
        public double Peso { get; set; }

        [StringLength(200)]
        public string Imagem { get; set; }

        [StringLength(400)]
        public string Animacao { get; set; }

        public ICollection<PokemonTipo> Tipos { get; set; }

        [Required]
        [StringLength(25)]
        public string Cor { get; set; }

        public ICollection<PokemonTipo> Pokemons { get; set; }
    }

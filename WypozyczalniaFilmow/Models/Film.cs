﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WypozyczalniaFilmow.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title must exist")]
        public string Tytul { get; set; }
        public string Rezyser { get; set; }
        [StringLength(1000)]
        public string Opis { get; set; }
        public decimal Cena { get; set; }
        public DateTime DataDodania { get; set; }

        [ForeignKey("Kategoria")]
        public int KategoriaId { get; set; }

        public Kategoria Kategoria { get; set; }
    }
}

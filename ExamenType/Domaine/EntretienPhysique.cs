﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class EntretienPhysique:Entretien
    {
        public int EntretienPhysiqueId { get; set; }
        /*[ForeignKey("Calendrier")]
        private int? CalendrierId { get; set; }*/
        [DataType(DataType.Date)]
        public DateTime DateEntretien { get; set; }
    }
}

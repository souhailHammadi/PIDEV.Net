using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int teamId { get; set; }
     
        public virtual ProjectManager prManager{ get; set; }
        public int? prManagerId { get; set; }


        
        public int? rHmanagerId { get; set; }
        public virtual RHmanager rHmanager{ get; set; }
    
        public virtual AdminEntreprise adminEnt{ get; set; }
        public int? adminEntId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DawgzWorldWeb.Data
{
    public class DawgHouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DHID { get; set; }

        [Display(Name ="DawgHouse Id")]
        public string DHName { get; set; }

       
        [ForeignKey("PDID")]
        public PresiDawgs PresiDawgsId { get; set; }
    }
}

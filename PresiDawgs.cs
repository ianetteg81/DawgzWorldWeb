using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DawgzWorldWeb.Data
{
    public class PresiDawgs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PDID { get; set; }

        [Display(Name = "PresdiDawg Id")]
        public string PDName { get; set; }


        [ForeignKey("DHID")]
        public DawgHouse DawgHouseID { get; set; }



    }
}

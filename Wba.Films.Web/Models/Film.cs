using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wba.Films.Web.Models
{
    public class Film
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Titel is vereist")]
        [StringLength(60, MinimumLength =3,ErrorMessage ="Minimaal 3, maximaal 60 tekens")]
        public string Titel { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Uitgiftedatum is vereist")]
        public DateTime Uitgiftedatum { get; set; }

        [Display(Name ="Soort film", Prompt = "voer hier het genre in")]
        [StringLength(30, ErrorMessage ="Genre is maximaal 30 tekens lang")]
        [Required(ErrorMessage = "Genre is vereist")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$",ErrorMessage ="Enkel letters en spaties toegelaten")]
        public string Genre { get; set; }

        [Range(1,100,ErrorMessage ="Kies een waarde tussen 1 en 100")]
        [Required(ErrorMessage = "Prijs is vereist")]
        [DataType(DataType.Currency)]
        public decimal Prijs { get; set; }

        [StringLength(5, ErrorMessage ="Rating is maximaal 5 tekens lang")]
        [Required(ErrorMessage ="Rating is vereist")]
        public string Rating { get; set; }
    }
}

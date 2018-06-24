using System.ComponentModel.DataAnnotations;

namespace Sequences.Models
{
    public class SequenceGenerateModel
    {
        [Required(ErrorMessage = "Number must be a positive, whole number.")]
        public int Number { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Sequences.Models
{
    public class SequenceGenerateModel
    {
        [Required(ErrorMessage = "Number must be a positive, whole number.")]
        [PositiveIntegerAttribute]
        public int Number { get; set; }
    }
}
namespace Sequences.Models
{
    public class SequenceGenerateResultModel
    {
        public string[][] Results { get; set; }

        public SequenceGenerateResultModel(string[][] results)
        {
            Results = results;
        }
    }
}
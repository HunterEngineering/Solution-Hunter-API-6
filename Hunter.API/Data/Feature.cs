using System.ComponentModel.DataAnnotations.Schema;

namespace Hunter.API.Data
{
    public class Feature : EntityBase
    {
        public Feature()
        {
        }

        public string Title { get; set; }
        public string Description { get; set; }

        // Many Features are owned by ONE Individual
        [ForeignKey(nameof(IndividualId))]
        public int IndividualId { get; set; }
        public Individual Individual { get; set; }
    }
}

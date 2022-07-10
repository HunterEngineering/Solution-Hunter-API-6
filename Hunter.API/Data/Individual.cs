using System.ComponentModel.DataAnnotations.Schema;

namespace Hunter.API.Data
{
    public class Individual : EntityBase
    {
        public Individual()
        {
        }

        public double Fitness { get; set; }
        public int Generations { get; set; }
        public int PopulationPosition { get; set; }
#nullable disable

        // An Individual belongs to ONE Population
        [ForeignKey(nameof(PopulationId))]
        public int PopulationId { get; set; }
        public Population Population { get; set; }

        // ONE Individual has MANY Features
        public virtual IList<Feature> Features { get; set; }
    }
}

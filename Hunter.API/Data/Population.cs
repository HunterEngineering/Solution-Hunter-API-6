using System.ComponentModel.DataAnnotations.Schema;

namespace Hunter.API.Data
{
    public class Population : EntityBase
    {
        public Population()
        {
        }

        public int Evolution { get; set; }
        public int Era { get; set; }
        public bool isActive { get; set; }
        public string initialEra { get; set; }

        // A Population is owned by ONE Project
        [ForeignKey(nameof(ProjectId))]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        // ONE Population has MANY Individuals
        public virtual IList<Individual> Individuals { get; set; }
    }
}

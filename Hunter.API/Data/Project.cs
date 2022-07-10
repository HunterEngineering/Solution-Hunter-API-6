using System.ComponentModel.DataAnnotations.Schema;

namespace Hunter.API.Data
{
    public class Project : EntityBase
    {
        public Project()
        {
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Designer { get; set; }
        public string Runner { get; set; }

        // ONE project is owned by ONE Company
        [ForeignKey(nameof(CompanyId))]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        // ONE project with MANY populations
        public virtual IList<Population> Populations { get; set; }
    }
}

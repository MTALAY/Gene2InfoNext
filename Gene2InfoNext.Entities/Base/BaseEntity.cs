using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gene2InfoNext.Entities.Base
{
    public class BaseEntity : IEntity
    {
        public DateTime? ModifiedDateTime { get; set; }
        public decimal? ModifiedUser { get; set; }
        public virtual DateTime? CreatedDateTime { get; set; }
        public virtual decimal? CreatedUser { get; set; }
        public string Description1 { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? CompanyId { get; set; }
        public string Code { get; set; }
        public int? Deleted { get; set; }
        public decimal RecordId { get; set; }
        public int? System { get; set; }
    }
}

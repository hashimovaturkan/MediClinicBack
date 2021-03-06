using MediClinic.Domain.Models.Entities.Membership;
using System.Collections.Generic;

namespace MediClinic.Domain.Models.Entities
{
    public class BlogPostComment: BaseEntity
    {
        public string Comment { get; set; }
        public int BlogPostId { get; set; }
        public virtual BlogPost BlogPost { get; set; }
        public int? ParentId { get; set; }
        public virtual BlogPostComment Parent { get; set; }
        public virtual ICollection<BlogPostComment> Children { get; set; }
        public int MediClinicUserId { get; set; }
        public virtual MediClinicUser MediClinicUser { get; set; }
    }
}

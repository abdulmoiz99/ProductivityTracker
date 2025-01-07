using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductivityTracker.Data.Entities.Base
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;


        [MaxLength(255)]
        public string IPAddress { get; set; }

        [MaxLength(255)]
        public string ModifiedByIPAddress { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; } = true;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Uid { get; set; }

        public BaseEntity()
        {
            Uid = Guid.NewGuid();
        }
    }
}

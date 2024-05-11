namespace EsemkaVote.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VotingCandidate")]
    public partial class VotingCandidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VotingCandidate()
        {
            VotingDetails = new HashSet<VotingDetail>();
        }

        public int Id { get; set; }

        public int VotingHeaderId { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual VotingHeader VotingHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VotingDetail> VotingDetails { get; set; }
    }
}

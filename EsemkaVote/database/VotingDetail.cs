namespace EsemkaVote.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VotingDetail")]
    public partial class VotingDetail
    {
        public int Id { get; set; }

        public int VotedCandidateId { get; set; }

        public int EmployeeId { get; set; }

        [StringLength(255)]
        public string Reason { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual VotingCandidate VotingCandidate { get; set; }
    }
}

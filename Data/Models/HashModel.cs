using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy_VerificationOfCertificates.Data.Models
{
    public class HashModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Hash { get; set; }

        public HashModel(string Hash) 
        { 
            this.Hash = Hash;
        }
    }
}

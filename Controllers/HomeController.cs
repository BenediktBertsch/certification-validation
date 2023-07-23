using CaseStudy_VerificationOfCertificates.Data;
using CaseStudy_VerificationOfCertificates.Data.Models;
using Microsoft.AspNetCore.Mvc;
namespace CaseStudy_VerificationOfCertificates.Controllers
{
    public class HashController : ControllerBase
    {
        ApplicationDbContext _db;

        public HashController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Save new hash to DB
        public void InsertHash(string hash)
        {
            _db.Add(new HashModel(hash));
            _db.SaveChanges();
        }

        // Check if hash exists
        public bool CheckHash(string Hash)
        {
            return _db.Hashes.Any(a => a.Hash == Hash);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext;
using Models;

namespace Repository //Repository k DAl or getway lekha jay
{
    
    public class OrganizationRepository
    {
        OnlineExamDb db = new OnlineExamDb();
        public bool Add(Organization organization)
        {

            db.Organizations.Add(organization);
            return db.SaveChanges() > 0;
        }
    }
}

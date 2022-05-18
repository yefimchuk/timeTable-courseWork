using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class DataModelInitializer : DropCreateDatabaseIfModelChanges<TimeTableContext>
    {
        protected override void Seed(TimeTableContext context)
        {
            context.SaveChanges();
        }

    }
}

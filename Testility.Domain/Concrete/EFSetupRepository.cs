using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testility.Domain.Abstract;

namespace Testility.Domain.Concrete
{
    public class EFSetupRepository : ISetupRepository
    {
        private string testingPushingMadafaka;


        public EFSetupRepository()
        {
            this.testingPushingMadafaka = "Pchnij w tę łódź jeża lub óśm skrzyń fig!";
        }
    }
}

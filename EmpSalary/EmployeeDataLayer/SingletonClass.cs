using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataLayer
{
    public sealed  class  Singleton
    {
        Singleton()
        {
        }
        private static readonly object padlock = new object();
        private static EmpEntities instance = null;
        public static EmpEntities Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new EmpEntities();
                            
                        }
                    }
                }
                return instance;
            }
        }
    }
}

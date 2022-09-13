using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    
    public class EmpBusiness
    {
        EmpDataAccess da = new EmpDataAccess();
        public DataSet GetData(string query)
        { 
            DataSet ds=new DataSet();
            ds=da.GetData(query);
            return ds;  
        }
    }
}

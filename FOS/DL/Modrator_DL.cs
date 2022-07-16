using FOS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.DL
{
    class Modrator_DL
    {
        DBConnection _dbCon;

        public Modrator_DL()
        {
            _dbCon = new DBConnection();
        }

        public bool addFoodin_DB(AddItem_DTO aditemDTO)
        {
            try
            {
                _dbCon.Con.Open();
                string queryString = "INSERT INTO MenuItem VALUES(@TypeName,@Name,@Price);";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@TypeName", aditemDTO.Type);
                com.Parameters.AddWithValue("@Name", aditemDTO.Name);
                com.Parameters.AddWithValue("@Price", aditemDTO.Price);

                int RowEffected= com.ExecuteNonQuery();
                return false;
                
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            finally
            {
                _dbCon.Con.Close();
            }
        }
    }
}

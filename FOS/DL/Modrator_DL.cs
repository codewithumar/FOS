using FOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
                return true;
                
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
        public DataTable getMenuItemsfrom_db ()
        {
            DataTable dt = new DataTable();
            
            try
            {
                _dbCon.Con.Open();
                string queryString = "SELECT TypeName,Name,Price FROM MenuItem;";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                _dbCon.Con.Close();
            }
        }
        public bool addtotalbillInDB(GenrateOrderBill_DTO gob_dto)
        {
            try
            {
                _dbCon.Con.Open();
                string queryString = "INSERT INTO Order VALUES(username,ItemName,TotalPrice,status,Quantity) SELECT @TypeName ,@TotalPrice, @status, @Quantity, (SELECT username FROM myUser WHERE username=@username);";
                SqlCommand com = new SqlCommand(queryString, _dbCon.Con);
                com.Parameters.AddWithValue("@TypeName", gob_dto.ItemName);
                com.Parameters.AddWithValue("@status", gob_dto.Status);
                com.Parameters.AddWithValue("@quantity", gob_dto.Quantity);
                com.Parameters.AddWithValue("@bill", gob_dto.Totalbill);
                com.Parameters.AddWithValue("@username", gob_dto.Username);


                int RowEffected = com.ExecuteNonQuery();
                return true;

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

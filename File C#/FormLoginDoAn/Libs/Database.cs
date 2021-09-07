using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLoginDoAn.Libs
{
    class Database
    {
        private Database() { }
        private static Database data; 
        public static Database Data 
        {
            get
            {
                if (data == null)
                {
                    data = new Database(); 
                }
                return Database.data;
            }

            private set 
            {
                Database.data = value;
            }
        }

        

        
        public SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=PhongTro;Integrated Security=True");

        SqlCommand command = new SqlCommand();

        public DataTable ExcuteToDataTable(string cmdText, CommandType type = CommandType.Text, SqlParameter[] prms = null)
        {
            command.CommandText = cmdText;
            command.CommandType = type;
            command.Parameters.Clear();
            if (prms != null)
            {
                foreach (SqlParameter p in prms)
                {
                    if (p != null)
                    {
                        command.Parameters.Add(p);
                    }
                }
            }
            command.Connection = con;
            DataTable dttb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dttb);
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Không thể thực thi SQL!", ex);
            }
            return dttb;
        }

        public void ExecuteNonQuery(string cmdText, CommandType type = CommandType.Text, SqlParameter[] prms = null)
        {
            command.CommandText = cmdText;
            command.CommandType = type;
            command.Parameters.Clear();
            if (prms != null)
            {
                foreach (SqlParameter p in prms)
                {
                    if (p != null)
                    {
                        command.Parameters.Add(p);
                    }
                }
            }
            command.Connection = con;
            con.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Không thể thực thi SQL!", ex);
            }
            con.Close();
        }



       
        public DataTable Showdata(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand(sql, con);

                SqlDataAdapter adap = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                adap.Fill(dt);


                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

    }
}

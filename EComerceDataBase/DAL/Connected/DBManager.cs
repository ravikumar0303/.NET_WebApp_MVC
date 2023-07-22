/*namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;


  public static string conString=@"server=192.168.10.150;port=3306;user=dac57; password=welcome;database=dac57_campus";       
    public  static List<Department> GetAllDepartments(){
            List<Department> allDepartments=new List<Department>();
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            string query = "SELECT * FROM departments";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();        
                cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string location = reader["location"].ToString();
                    Department dept=new Department{
                                                    Id = id,
                                                    Name = name,
                                                    Location = location
                    };
                    allDepartments.Add(dept);
                }
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }

            return allDepartments;
    }
    public static Department GetDeparmentDetails(int id){
        Department dept = null;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "SELECT * FROM departments WHERE id=" + id;
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string location = reader["location"].ToString();
                dept = new Department
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return dept;
    }

}*/
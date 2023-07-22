namespace DAL.DisConnected;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;
public class DBManager{

    public static string conString=@"server=192.168.10.150;port=3306;user=dac57; password=welcome;database=dac57_campus";       
    public  static List<Department> GetAllDepartments(){
        List<Department> allDepartments=new List<Department>();

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            DataSet ds=new DataSet();  //empty data set
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;
            string query = "SELECT * FROM departments";
            cmd.CommandText=query;
            //disconnected Data Access logic
            MySqlDataAdapter da=new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);  
            DataTable dt=ds.Tables[0];
            DataRowCollection rows=dt.Rows;
            foreach( DataRow row in rows)
            {
                int id = int.Parse(row["id"].ToString());
                string name = row["name"].ToString();
                string location = row["location"].ToString();
                Department dept = new Department
                {
                    ID = id,
                    Name = name,
                    Location = location
                };
                allDepartments.Add(dept);
            }

        }
        catch(Exception ee){
                Console.WriteLine(ee.Message);
        }
        return allDepartments;
    }
}
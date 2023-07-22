//using Testing;
/*using DAL.DisConnected;*/
using HR;
//using BOL;
List<Department> departments= DBManager.GetAllDepartments();
foreach ( Department dept in departments){
    Console.WriteLine(dept.Name + "  " + dept.Location);

}

Department dpt=new Department(){

   Name="DBT1",
   Location="Goa"

};

 Console.WriteLine("fsdgsd\n\\hgiehwg");
 Console.WriteLine(@"fsdgsd\\nhgiehwg");

// DbTestManager.Insert(dpt);

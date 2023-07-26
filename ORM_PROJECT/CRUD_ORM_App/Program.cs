// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using BOL;
using DAL;
Console.WriteLine("Welcome to IET Acts DATA Management System  !!");

IDBManager dbm = new DBManager();

bool status = true;
// Console based Menu driven User Interface
while (status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Insert  new record");
    Console.WriteLine("3. Update existing record");
    Console.WriteLine("4. Delete existing record");
    Console.WriteLine("5. Exit");

    switch (int.Parse(Console.ReadLine()))
    {
        //Display Departments
        case 1:
            {
                List<Department> allDepartments = dbm.GetAll();

                foreach (var dept in allDepartments)
                {
                    Console.WriteLine(" Deptno: {0}, Dname: {1}, Loc: {2}, pwd:{3},StartedON:{4}",
                                        dept.Deptno, dept.Dname, dept.Loc,dept.pwd,dept.StartedON);
                }
            }
            break;

        //Insert new  Department
        case 2:
            var newDept = new Department()
            {
               Deptno = 23,
                Dname = "Research",
                Loc = "Chennai",
                pwd ="REac@we",
                StartedON ="12/25/2001"

            };
            dbm.Insert(newDept);
            break;

        // Update existing Department
        case 3:
            {
                var updateDepartment = new Department()
                {
                    Deptno = 115,
                    Dname = "Research",
                    Loc = "up",
                    pwd = "REac@we",
                    StartedON = "12/25/2001"
                };
                dbm.Update(updateDepartment);
            }
            break;

        // Delete existing Department
        case 4:
            dbm.Delete(23);
            break;

        //Exit from loop
        case 5:
            status = false;
            Console.WriteLine("Thanku for Visiting \n !! Have A grate Day   !!!");
            break;
    }
}




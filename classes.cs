using System;

class Employee
{
    public static string orgName = "NCR";
    public static int orgId = 101;
}

struct Employees
{
    public int EmpId;
    public string EmpName;
    public void details(int EmpId,string EmpName) {
        Console.WriteLine("Employee Name and ID are: " + EmpId, EmpName);
    }
}
class Program
{
    static void Main()
    {
        Employee e1 = new Employee();      
        Employees e2 = new Employees();
        e2.EmpId = 101;
        e2.EmpName = "Harika";
        e2.details(e2.EmpId,e2.EmpName);
	    Console.WriteLine("Organisation Name: " + Employee.orgName);
	    Console.WriteLine("Organisation Id: " + Employee.orgId);
	    Console.WriteLine("Month of joining the organization: " + MonthOfJoining.February);
	}
    enum MonthOfJoining
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
using System;

//Make Manager an Extension of Employee
public class Manager : Employee {

    private string department;

    private string region;

    public Manager(string firstName, string lastName, string id, string department, string region) 
        : base(firstName, lastName, id, EmployeeType.Manager) {
        this.department = department;
        this.region = region;
    }

     //Department Method to get and to set.
    public string getDepartment() {return department;}
    public void setDepartment(string department){this.department = department;}

     //Department Method to get and to set.
    public string getRegion() {return region;}
    public void setRegion(string region){this.region = region;}

    

    
}
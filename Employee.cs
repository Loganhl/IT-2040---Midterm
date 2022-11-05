using System;

     public enum EmployeeType
        {
            Sales,
            Manager,
            Production,
        } //This will serve as our own custom variable.
    public class Employee
    {
        private string firstName;
        private string lastName;

        private string id;

        private EmployeeType empType;
        
        public Employee(string firstName, string lastName, string id, EmployeeType empType){
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.empType = empType;

        }

        public void Person()
    {
        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("ID: {0:C}", id);
        Console.WriteLine("Type: {0:C}", empType.ToString());
    }

    //First Name Method to get and to set.
    public string getFirst() {return firstName;}
    public void setFirst(string firstName){this.firstName = firstName;}

    //Last Name Method to get and to set.
    public string getLast() {return lastName;}
    public void setLast(string lastName){this.firstName = lastName;}

    //EmpType Method to get and to set.
    public EmployeeType getempType() {return empType;}
    public void setempType(EmployeeType empType){this.empType = empType;}

    //Method to return id value.
    public string getID(){return id;}

    }
using System;
public enum SalesLevel 
    { 
        Platinum, 
        Diamond, 
        Gold, 
        Silver, 
        Bronze 
    } //This will serve as our own custom variable.

//Make SalesPerson an Extension of Employee
public class SalesPerson : Employee {
    private string department;
    private float sales;
    public SalesPerson(string firstName, string lastName, string id, string department, float sales) 
    //calls employee constructor with : base
        : base(firstName, lastName, id, EmployeeType.Sales) {
        this.department = department;
        this.sales = sales;
    }
    public void updateSales(float newSales) {sales += newSales;}
    public SalesLevel GetSalesLevel() 
    {
        if(sales < 10000)
            return SalesLevel.Bronze;
        else if(sales >= 10000 && sales <= 19999.99)
            return SalesLevel.Silver;
        else if(sales >= 20000 && sales <= 29999.99)
            return SalesLevel.Gold;
        else if(sales >= 30000 && sales <= 39999.99)
            return SalesLevel.Diamond;
        else
            return SalesLevel.Platinum;
    }

    //Method to get and set Department
    public string getDepartment() {return department;}
    public void setDepartment(string department) {this.department = department;}

    //Method to Return Sales
    public float getSales() {return sales;}

    //Method to Set Sales
    public void setSales(float sales) {this.sales = sales;}

}
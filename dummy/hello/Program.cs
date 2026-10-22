class Class {
    public static void Main(String[] args){
      Console.WriteLine("Main Method");
    
    Customer aCustomer=new Customer("Emil", 72, 500.0);
    aCustomer.Deposit (500.0);
    aCustomer.Withdraw (200.0);
    Console.WriteLine(aCustomer.GetBalance ());
    }
}
class Customer {
    string name;
    int id;
    double balance;
    public Customer (string name, int id) {
        this.balance=0;
        this.name=name;
        this.id=id;
    }

    public Customer (string name, int id, double balance) {
        this.balance=balance;
        this.name=name;
        this.id=id;
    }
    public void Deposit (double amount) {
        this.balance=amount+balance;
    }
    public void Withdraw (double amount) {
        if (balance>=amount) {
            balance-=amount;
        }
    }
    public double GetBalance (){
        return this.balance;
    }
}
class CustomerDatabase {
    public Customer[] customers;
    new customers[10];
}

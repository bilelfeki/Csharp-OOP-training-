Console.WriteLine("Hello, World!");
var account1 =new BankAccout("bilel",23) ;  
var account2 =new BankAccout("bilel feki",25) ; 
Console.WriteLine(account1.Balance); 
try{
    account1.MakeDeposit(-20,DateTime.Now,"hello") ; 
}
catch(Exception e){
    Console.WriteLine(e);

}
Console.WriteLine(account1.Balance);

Console.WriteLine(account2.Id);

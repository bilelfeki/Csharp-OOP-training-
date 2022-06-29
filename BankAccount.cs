
public class BankAccout{
    public  string Id {get;set;}
    public string Owner {get;set ; }
    private List<Transaction> Transactions= new List<Transaction>() ;

    public decimal Balance {
        get {
            decimal balance=0 ; 
            foreach(var trans in Transactions){
                balance+=trans.Amount ;
            }
            return balance ;
        } 
    }
    private static long number=1000000000;

    
    public BankAccout(string Owner,decimal Balance ){
        this.Id= number.ToString() ; 
        number++ ; 
        this.Owner=Owner ; 

        MakeDeposit(Balance,DateTime.Now,"your first deposit") ; 

    }

    public void MakeDeposit(decimal amount , DateTime date, string note){
        if( amount <=0){
            throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive");
        }
        var Transaction = new Transaction(amount,date,note) ; 
        Transactions.Add(Transaction) ; 
    }
    
    public void MakeWithdrawal(decimal amount, DateTime date, string note){
        if( amount <=0){
            throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive");
        }
        if(this.Balance< amount){
            throw new InvalidOperationException(nameof(amount),"your solde is not sufficent") ; 
        }
        var Transaction = new Transaction(-amount,date,note) ; 
        Transactions.Add(Transaction) ; 

    }
}
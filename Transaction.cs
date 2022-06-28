public class Transaction{
    public decimal Amount {get;}
    public DateTime Date {get ;}
    public string Notes {get;}

    public Transaction(decimal Amount,DateTime Date,string Notes){
        this.Notes=Notes ; 
        this.Date=Date; 
        this.Amount=Amount ; 
    }

}
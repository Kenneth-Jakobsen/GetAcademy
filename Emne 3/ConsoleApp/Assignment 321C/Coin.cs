namespace Assignment_321C;

 class Coin
 {
     private int _value;
     private int _amount;

   public void GetSum()
   {
       Console.WriteLine($"You have {_value * _amount}Kr");
   }

   public bool SetCoin()
   {
       Console.WriteLine("Enter Coin: ");
       var input = int.Parse(Console.ReadLine());
       if (input is 1 or 5 or 10 or 20)
       {
           _value = input;
           return true;
       }
       return false;
   }

   public void SetAmount()
   {
       Console.WriteLine("Enter Amount:");
       _amount = int.Parse(Console.ReadLine());
   }
   
}
namespace Practice__Static_class__Methods__and_Constructor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(BuisnessInfo.BuisnessName);
			DailyTransactions.Transactions.Add(new Transaction("Suits",50000));
			DailyTransactions.Transactions.Add(new Transaction("Eggs", 500000));
			DailyTransactions.Transactions.Add(new Transaction("Knives", 250));
			DailyTransactions.Transactions.Add(new Transaction("Gas", 1500));
			DailyTransactions.Transactions.Add(new Transaction("Brake pads", 5555));
			DailyTransactions.DisplayAllInfo();
		}
	}
}
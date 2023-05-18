using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Static_class__Methods__and_Constructor
{
	internal class DailyTransactions
	{
		static List<Transaction> _transactions;
		
		static DailyTransactions()
		{
			_transactions = new List<Transaction>();
		}

		internal static List<Transaction> Transactions { get => _transactions; set => _transactions = value; }

		static void AddTransaction(Transaction transaction)
		{
			_transactions.Add(transaction);
		}
		
		static double CalculateTotal()
		{
			double total = 0;
			foreach (Transaction transaction in _transactions)
			{
				total += transaction.Amount;
			}
			total += total * 0.05;
			return total;
		}

		static public void DisplayAllInfo()
		{
			foreach (Transaction transaction in _transactions)
			{
				Console.WriteLine(transaction);
			}
			Console.WriteLine($"Tax:{BuisnessInfo.TaxAmount}%");
			Console.WriteLine($"Total:${CalculateTotal()}");
		}
	}
}

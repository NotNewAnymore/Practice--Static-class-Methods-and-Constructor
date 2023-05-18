using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Static_class__Methods__and_Constructor
{
	internal class Transaction
	{
		DateTime _now = DateTime.Now;
		string _name;
		double _amount;

		public Transaction(string name, double amount)
		{
			_name = name;
			_amount = amount;
		}
		public string Name { get => _name; }
		public double Amount { get => _amount; }

		public override string ToString()
		{
			return $"Name: {_name}, time {_now}, amount ${_amount}.";
		}
	}
}

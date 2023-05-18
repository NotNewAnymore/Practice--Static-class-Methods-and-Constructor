using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__Static_class__Methods__and_Constructor
{
	static internal class BuisnessInfo
	{
		private static string buisnessName;
		private static double taxAmount;

		public static string BuisnessName { get => buisnessName; set => buisnessName = value; }
		public static double TaxAmount { get => taxAmount; set => taxAmount = value; }

		static BuisnessInfo()
		{
			BuisnessName = "Chuck Norris charm school for young gentlemen";
			TaxAmount = 0.05;
		}
	}
}

/*
    When to use dictionary over list.
	
	Find() method of the list class loops through each object in the list untill a match is found. So, If you want 
	to lookup a value using a key dictionary is better for performance over list. So, use dictionary when you know
	the collection will be primarly used for lookups.
	
	
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Country country1 = new Country(){ Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
			Country country2 = new Country(){ Code = "IND", Name = "INDIA", Capital = "New Delhi" };
			Country country3 = new Country(){ Code = "USA", Name = "United State", Capital = "Washington D. C." };
			Country country4 = new Country(){ Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
			Country country5 = new Country(){ Code = "CAN", Name = "CANADA", Capital = "Ottawa" };
			
			List<Country> listCountries = new List<Country>();
			
			/*
			listCountries.Add(country1);
			listCountries.Add(country2);
			listCountries.Add(country3);
			listCountries.Add(country4);
			listCountries.Add(country5);
			*/
			
			Dictionary<string, Country> dict = new Dictionary<string, Country>();
			
			dict.Add(country1.Code, country1);
			dict.Add(country2.Code, country2);
			dict.Add(country3.Code, country3);
			dict.Add(country4.Code, country4);
			dict.Add(country5.Code, country5);
			
			string userInput = string.Empty;
			
			do
			{
				Console.WriteLine("Please enter a country code");
				string strCountryCode = Console.ReadLine().ToString();
				
				//Country country = listCountries.Find(c => c.Code == strCountryCode.ToUpper());
				
				Country country = dict.ContainsKey(strCountryCode.ToUpper()) ? dict[strCountryCode.ToUpper()] : null;
				
				if(country != null)
				{
					Console.WriteLine("Code = {0}, Name = {1}, Capital = {2}", country.Code, country.Name, country.Capital);
				}
				else
				{
					Console.WriteLine("No Data Found");
				}
				
				string userSelection = string.Empty;
				
				do
				{
					Console.WriteLine("Do you want to continue - YES or NO?");
					userInput = Console.ReadLine().ToUpper();
				}
				while(userInput.ToUpper() != "YES" && userInput.ToUpper() != "NO");
			}
			while(userInput.ToUpper() == "YES");
			
			Console.WriteLine("Loop Ended");
		}
    }
	
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }
}

/*
	Output :
		Please enter a country code
    ind
    Code = IND, Name = INDIA, Capital = New Delhi
    Do you want to continue - YES or NO?
    yes
    Please enter a country code
    aus
    Code = AUS, Name = AUSTRALIA, Capital = Canberra
    Do you want to continue - YES or NO?
    no
    Loop Ended
*/

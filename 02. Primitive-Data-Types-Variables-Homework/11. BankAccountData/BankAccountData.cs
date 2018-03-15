using System;
/*Problem 11. Bank Account Data
-------------------------------------------------------------------------------------------------------------------
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/ 

class BankAccountData
{
	static void Main()
	{
		string firstName = "John";
		string middleName = "Simpson";
		string lastName = "Doe";
		long balance = 9223372036854775807;
		string bankName = "The Royal Bank of Scotland";
		string iban = "GB99 RBOS 1234 5612 3456 78";
		long creditCard1 = 4539469451234784;
		long creditCard2 = 4485755563812168;
		long creditCard3 = 4929955479357183;
		Console.WriteLine("Holder name: {0}", firstName + " " + middleName + " " + lastName);
		Console.WriteLine("Available amount of money: {0}", balance);
		Console.WriteLine("Bank name: {0}", bankName);
		Console.WriteLine("IBAN: {0}", iban);
		Console.WriteLine("First credit card number, associated with the bank account: {0}", creditCard1);
		Console.WriteLine("Second credit card number, associated with the bank account: {0}", creditCard2);
		Console.WriteLine("Third credit card number, associated with the bank account: {0}", creditCard3);
	}
}
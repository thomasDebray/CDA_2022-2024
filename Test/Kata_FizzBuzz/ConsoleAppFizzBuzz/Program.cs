static string FizzBuzz(int debut,int fin)
{
	string result = "";
	for (int i = debut; i <= fin; i++)
	{
		result += FizzBuzzPourUnNombre(i)+"\n";
	}
	return result;

	static string FizzBuzzPourUnNombre(int i)
	{
		string result;
		if (i % 3 == 0 && i % 5 == 0)
		{
			result = "FizzBuzz";
		}
		else if (i % 5 == 0)
		{
			result = "Buzz";
		}
		else if (i % 3 == 0)
		{
			result = "Fizz";
		}
		else
		{
			result = i.ToString();
		}

		return result;
	}
}

Console.WriteLine(FizzBuzz(1,100));


namespace ClassLibraryFizzBuzz
{
	public static class FizzBuzz
	{
		private const int PremiereValeur = 3;
		private const int SecondeValeur = 5;

		public static string FizzBuzzPourUnNombre(int nombre)
		{
			if (nombre % PremiereValeur == 0 && nombre % SecondeValeur == 0)
			{
				return "FizzBuzz";
			}

			if (nombre % PremiereValeur == 0)
			{
				return "Fizz";
			}

			if (nombre % SecondeValeur == 0)
			{
				return "Buzz";
			}

			return nombre.ToString();
		}

		public static string FizzBuzzInterval(int debut, int fin)
		{
			string result = "";
			for (int i = debut; i <= fin; i++)
			{
				result += FizzBuzzPourUnNombre(i) + "\n";
			}
			return result;
		}

	}
}
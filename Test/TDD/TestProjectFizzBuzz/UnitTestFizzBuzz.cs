
namespace TestProjectFizzBuzz
{
	[TestClass]
	public class UnitTestFizzBuzz
	{
		[TestMethod]
		public void Given_nombre_When_FizzBuzzPourUnNombre_Then_Return_Nombre_String()
		{
			//Arrange
			string retour;
			int nombre = 1;
			//Act
			retour = ClassLibraryFizzBuzz.FizzBuzz.FizzBuzzPourUnNombre(nombre);
			//Assert
			Assert.AreEqual("1", retour);
		}

		[TestMethod]
		public void Given_nombre_3_When_FizzBuzzPourUnNombre_Then_Return_Fizz_String()
		{
			//Arrange
			string retour;
			int nombre = 3;
			//Act
			retour = ClassLibraryFizzBuzz.FizzBuzz.FizzBuzzPourUnNombre(nombre);
			//Assert
			Assert.AreEqual("Fizz", retour);
		}

		[TestMethod]
		public void Given_nombre_6_When_FizzBuzzPourUnNombre_Then_Return_Fizz_String()
		{
			//Arrange
			string retour;
			int nombre = 6;
			//Act
			retour = ClassLibraryFizzBuzz.FizzBuzz.FizzBuzzPourUnNombre(nombre);
			//Assert
			Assert.AreEqual("Fizz", retour);
		}

		[TestMethod]
		public void Given_nombre_5_When_FizzBuzzPourUnNombre_Then_Return_Buzz_String()
		{
			//Arrange
			string retour;
			int nombre = 5;
			//Act
			retour = ClassLibraryFizzBuzz.FizzBuzz.FizzBuzzPourUnNombre(nombre);
			//Assert
			Assert.AreEqual("Buzz", retour);
		}

		[TestMethod]
		public void Given_nombre_10_When_FizzBuzzPourUnNombre_Then_Return_Buzz_String()
		{
			//Arrange
			string retour;
			int nombre = 10;
			//Act
			retour = ClassLibraryFizzBuzz.FizzBuzz.FizzBuzzPourUnNombre(nombre);
			//Assert
			Assert.AreEqual("Buzz", retour);
		}

		[TestMethod]
		public void Given_nombre_15_When_FizzBuzzPourUnNombre_Then_Return_FizzBuzz_String()
		{
			//Arrange
			string retour;
			int nombre = 15;
			//Act
			retour = ClassLibraryFizzBuzz.FizzBuzz.FizzBuzzPourUnNombre(nombre);
			//Assert
			Assert.AreEqual("FizzBuzz", retour);
		}
	}
}
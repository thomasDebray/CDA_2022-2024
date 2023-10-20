using BarnabeTest;

namespace TestProjectBarnabe
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Given_nombreInferieurA1_sous_When_NombreDeMagasin_then_exeptionArgumentOutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(()=>Barnabe.NombreDeMagasin(-5));
		}

		[TestMethod]
		public void Given_nombrePositif50_sous_When_NombreDeMagasin_then_return5()
		{
			Assert.AreEqual(5, Barnabe.NombreDeMagasin(50));
		}

		[TestMethod]
		public void Given_nombre2_sous_When_NombreDeMagasin_Then_return1()
		{
			//Arrange
			double sous = 2;
			//Act
			int nbMagasin = Barnabe.NombreDeMagasin(sous);
			//Assert
			Assert.AreEqual(1, nbMagasin);
		}

		[TestMethod]
		public void Given_nombreComprisEntre0et2_sous_When_NombreDeMagasin_Then_return1()
		{
			//Arrange
			double sous = 1.25;
			//Act
			int nbMagasin = Barnabe.NombreDeMagasin(sous);
			//Assert
			Assert.AreEqual(1, nbMagasin);
		}
	}
}
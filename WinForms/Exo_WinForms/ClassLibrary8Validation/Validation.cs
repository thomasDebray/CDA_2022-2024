using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary8Validation
{
	public static class Validation
	{
		public static bool LoginOk(string login, string password)
		{
			return LoginValide(login)&&PasswordValide(password)&&login == password;
		}
		public static bool LoginValide(string login)
		{
			Regex maRegex = new Regex(@"^[A-Za-z0-9]{1,29}$");
			return maRegex.IsMatch(login);
		}
		public static bool PasswordValide(string password)
		{
			Regex maRegex = new Regex(@"^[A-Za-z0-9]{1,29}$");
			return maRegex.IsMatch (password);
		}
	}
}

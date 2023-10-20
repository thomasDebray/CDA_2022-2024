using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public interface ICommand
    {
        public bool Executer();

        public bool Annuler();

        public string GetString();
    }
}

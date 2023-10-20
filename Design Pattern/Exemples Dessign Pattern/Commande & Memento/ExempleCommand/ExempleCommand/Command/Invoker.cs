using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class Invoker
    {
        private Stack<ICommand> commands; // LES COMMANDES QUI POURRONT ETRE ANNULES
        private Stack<ICommand> redo; // LES COMMANDES QUI POURRONT ETRE REPETER

        #region accesseurs mutateurs
        public ICommand[] Commands { get => commands.ToArray(); } // POUR VOIR
        public ICommand[] Redo { get => redo.ToArray(); } // POUR VOIR
        #endregion
        #region event
        public event OnCommandListChangeHandler OnCommandListChange;
        public event OnRedoListChangeHandler OnRedoListChange;
        public delegate void OnCommandListChangeHandler(Invoker sender);
        public delegate void OnRedoListChangeHandler(Invoker sender);
        #endregion

        public Invoker() {
            commands = new Stack<ICommand>();
            redo = new Stack<ICommand>();
        }

        public bool ExecuterCommande(ICommand c)
        {
            if (c.Executer())
            {
                if (redo.Count > 0)
                {
                    redo.Clear();
                    RedoListChangeAlert();
                }
                
                commands.Push(c);
                CommandListChangeAlert();
                return true;
            }
            return false;
        }

        private void RedoListChangeAlert()
        {
            if (OnRedoListChange != null)
            {
                OnRedoListChange(this);
            }
        }

        private void CommandListChangeAlert()
        {
            if (OnCommandListChange != null)
            {
                OnCommandListChange(this);
            }
        }


        public bool AnnulerDerniereAction()
        {
            if (commands.Count == 0)
                return false;
            ICommand c = commands.Pop();
            if (c.Annuler())
            {
                redo.Push(c);
                RedoListChangeAlert();
                CommandListChangeAlert();
                return true;
            } else
            {
                commands.Push(c);
                return false;
            }
        }

        public bool RefaireDerniereActionAnnulee()
        {
            if (redo.Count == 0)
                return false;
            ICommand c = redo.Pop();
            if (c.Executer())
            {
                commands.Push(c);
                RedoListChangeAlert();
                CommandListChangeAlert();
                return true;
            }
            else
            {
                redo.Push(c);
                return false;
            }
        }
    }
}

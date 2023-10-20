using ExempleCommand.Cartes;

namespace ExempleCommand
{

    // LE PERSONNAGE JOUERA LE ROLE DE RECEIVER
    public class Personnage
    {
        // LA POSITION DU JOUEUR EST DETERMINEE PAR SES COORDONEED
        private int x;
        private int y;
        private Carte carte;


        #region events

        public event OnPositionChangeHandler OnPositionChange;
        public delegate void OnPositionChangeHandler(Personnage sender);
        #endregion
        #region accesseur mutateurs
        public int X { get => x; private set {
                if (value != x)
                {
                    x = value;
                    if (OnPositionChange != null)
                    {
                        OnPositionChange(this);
                    }
                }               

            } }
        public int Y
        {
            get => y; private set
            {
                if (value != y)
                {
                    y = value;
                    if (OnPositionChange != null)
                    {
                        OnPositionChange(this);
                    }
                }
            }
        }
        #endregion
        public Personnage(int _x, int _y, Carte _carte)
        {
            this.x = _x;
            this.y = _y;
            this.carte = _carte;
        }

        #region deplacement
        public bool DeplacerAGauche(int nbPx)
        {
            int nextPos = x - nbPx;
            if (nextPos < 0)
                return false;
            this.X = nextPos;
            return true;
        }

        public bool DeplacerEnHaut(int nbPx)
        {
            int nextPos = y - nbPx;
            if (nextPos < 0)
                return false;
            this.Y = nextPos;
            return true;
        }

        public bool DeplacerADroite(int nbPx)
        {
            int nextPos = x + nbPx;
            if (nextPos > carte.W - 1)
                return false;
            this.X = nextPos;
            return true;
        }

        public bool DeplacerEnBas(int nbPx)
        {
            int nextPos = y + nbPx;
            if (nextPos > carte.H-1)
                return false;
            this.Y = nextPos;
            return true;
        }
        #endregion
    }
}
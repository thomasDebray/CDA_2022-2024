using ExempleCommand;
using ExempleCommand.Cartes;
using ExempleCommand.Command;
using System.ComponentModel.Design;

namespace ExemplePatternCommand
{
    public partial class Form1 : Form
    {
        private Personnage charlie;
        private Carte carte;
        private Invoker invoker;
        public Form1()
        {
            InitializeComponent();
            carte = new Carte(8, 8);
            charlie = new Personnage(4, 4, carte);
            invoker = new Invoker();
            UpdateCharliePositionLabel();
            charlie.OnPositionChange += (sender) =>
            {
                panelDessin.Refresh();
                UpdateCharliePositionLabel();
            };
            invoker.OnRedoListChange += sender =>
            {
                RefreshRepeterList();
            };
            invoker.OnCommandListChange += sender =>
            {
                RefreshAnnulerList();
            };

        }

        private void Invoker_OnRedoListChange(Invoker sender)
        {
            throw new NotImplementedException();
        }

        private void UpdateCharliePositionLabel()
        {
            labelPositionCharlieX.Text = charlie.X.ToString();
            labelPositionCharlieY.Text = charlie.Y.ToString();
        }
        private void panelDessiner_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 10);
            Image img = Image.FromFile("Charlie.png");
            Graphics g = e.Graphics;
            int width = panelDessin.Width / carte.W;
            int height = panelDessin.Height / carte.H;
            for (int i = 0; i < carte.H; i++)
            {
                for (int j = 0; j < carte.W; j++)
                {
                    Color color = ((i + j) % 2 == 0 ? Color.FromArgb(100, 255, 255, 255) : Color.FromArgb(100, 0, 0, 0));
                    g.FillRectangle(new SolidBrush(color), j * width, i * height, width, height);
                }
            }
            g.DrawImage(img, new Rectangle(charlie.X * width, charlie.Y * height, width, height));
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            ICommand command = null;
            int val = Convert.ToInt32(numericNbPas.Value);
            if (radioButtonLeft.Checked)
            {
                command = new CommandAllerAGauche(val, charlie);
            }
            else if (radioButtonRight.Checked)
            {
                command = new CommandAllerADroite(val, charlie);
            }
            else if (radioButtonUp.Checked)
            {
                command = new CommandAllerEnHaut(val, charlie);
            }
            else if (radioButtonBot.Checked)
            {
                command = new CommandAllerEnBas(val, charlie);
            }
            invoker.ExecuterCommande(command);

        }



        private void RefreshAnnulerList()
        {
            listBoxAnnuler.Items.Clear();
            foreach (ICommand c in invoker.Commands)
            {
                listBoxAnnuler.Items.Add(c.GetString());
            }
        }

        private void RefreshRepeterList()
        {
            listBoxRepeter.Items.Clear();
            foreach (ICommand c in invoker.Redo)
            {
                listBoxRepeter.Items.Add(c.GetString());
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            invoker.AnnulerDerniereAction();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            invoker.RefaireDerniereActionAnnulee();
        }
    }
}
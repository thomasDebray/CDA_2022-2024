namespace ExempleMediateurPourThomas
{
    public class Mediator
    {
        private List<Formateur> sesFormateurs;
        private List<Etudiant> sesEtudiants;

        public Mediator()
        {
            sesFormateurs = new List<Formateur>();
            sesEtudiants = new List<Etudiant>();
        }

        public void AddFormateur(Formateur person)
        {
            sesFormateurs.Add(person);
        }

        public void AddEtudiant(Etudiant person)
        {
            sesEtudiants.Add(person);
        }

        public void SaluerEleve(Formateur f)
        {
            foreach (Etudiant e in sesEtudiants)
            {
                e.RepondreBonjour(f);
            }
        }
    }
}
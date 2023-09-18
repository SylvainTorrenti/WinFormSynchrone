using System.Diagnostics;

namespace WinFormSynchrone
{
    public partial class frmMain : Form
    {
        private List<int> _listNb = new List<int>();
        Random random = new Random();
        Stopwatch sw = new Stopwatch();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btSynchro_Click(object sender, EventArgs e)
        {
            //Vide la liste
            _listNb.Clear();
            //Reinitialise le data source
            lbNumber.DataSource = null;
            //Reinitialise le label qui indique le temps
            lbTime.Text = string.Empty;
            //Redemare le compteur de temps
            sw.Restart();
            //appel la fonction FillList
            FillList();
            //Stop le compteur de temps
            sw.Stop();
            //Inclue le temps passé dans la label
            lbTime.Text = string.Format("Temps écoulé : {0} ms", sw.ElapsedMilliseconds);
            //Classe la liste
            _listNb.Sort();
            //Ajoute la liste comme datasource de la list box
            lbNumber.DataSource= _listNb;

        }
        private void FillList()
        {
            //Tant que la liste ne contient 100 nombre
            while (_listNb.Count < 100)
            {
                //Tire un chiffre au hasard entre 1 et 100
                int nb = random.Next(1, 101);
                //Fait une pause de 10 ms à chaque nombre tiré
                Thread.Sleep(10);
                //Si la liste ne contient pas le nombre tiré
                if (!_listNb.Contains(nb))
                {
                    //Ajoute le nombre à la liste
                    _listNb.Add(nb);
                    //Fait une pause de 10 ms à chaque nombre ajouté
                    Thread.Sleep(10);
                }
            }
        }
    }
}
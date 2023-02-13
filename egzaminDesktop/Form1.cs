namespace egzaminDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string alfabetM = "qwertyuiopasdfghjklzxcvbnm";
        string alfabetW = "QWERTYUIOPASDFGHJKLZXCVBNM";
        string Cyfry = "1234567890";
        string znakiS = "!@#$%^&*()_+-=";
        string caleHaslo = " ";

        /// <summary>
        /// Funkcja generuje has³o
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generujHaslo(object sender, EventArgs e)
        {
            caleHaslo = " ";
            
            Random random = new Random();
            
            int liczbaZnakow = Convert.ToInt16(ileZnakow.Text);
            
            List<int> wolneMiejsca = new List<int>(liczbaZnakow);
            for(int i = 0; i < wolneMiejsca.Capacity; i++)
                wolneMiejsca.Add(i);
            
            char[] haslo = new char[liczbaZnakow];
            
            int rodzaj = 0;
            for (int i = 0; i < wolneMiejsca.Capacity; i++)
            { 
                int miejsce;
                switch (rodzaj)
                {
                    case 0:
                        miejsce = wolneMiejsca.ElementAt(random.Next(0, wolneMiejsca.Count));
                        wolneMiejsca.Remove(miejsce);
                        haslo[miejsce] = alfabetM[random.Next(0, 25)];
                        break;
                    case 1:
                        if (maleIwielkie.Checked)
                        {
                            miejsce = wolneMiejsca.ElementAt(random.Next(0, wolneMiejsca.Count));
                            wolneMiejsca.Remove(miejsce);
                            haslo[miejsce] = alfabetW[random.Next(0, 25)];
                        }
                        else i--;
                        break;
                    case 2:
                        if (cyfry.Checked)
                        {
                            miejsce = wolneMiejsca.ElementAt(random.Next(0, wolneMiejsca.Count));
                            wolneMiejsca.Remove(miejsce);
                            haslo[miejsce] = Cyfry[random.Next(0, 10)];
                        }
                        else i--;
                        break;
                    case 3:
                        if (znakiSpecjalne.Checked)
                        {
                            miejsce = wolneMiejsca.ElementAt(random.Next(0, wolneMiejsca.Count));
                            wolneMiejsca.Remove(miejsce);
                            haslo[miejsce] = znakiS[random.Next(0, 14)];
                        }
                        else
                            i--;
                        break;
                }
                rodzaj = (rodzaj + 1) % 4;
            }
            
            for (int i = 0; i < haslo.Length; i++)
                caleHaslo +=haslo[i];
            MessageBox.Show(caleHaslo);
            
        }


        /// <summary>
        /// Funkcja wyœwietla dane pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zatwierdz(object sender, EventArgs e)
        {
            MessageBox.Show("Dane pracownika: " + imie.Text + " " + nazwisko.Text + " " + stanowisko.Text + " Has³o: " + caleHaslo);
        }
    }
}
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

        //*************************
        //nazwa funkcji: generujHaslo
        //opis funkcji: funkcja generuje has³o
        //parametry:    sender - podstawowy element forms
        //              e - podstawowy element forms
        //zwracany typ i opis: zwraca void
        //autor: Krzysztof Krówka
        //*************************
        private void generujHaslo(object sender, EventArgs e)
        {
            caleHaslo = " ";
            Random random = new Random();
            int liczbaZnakow = Convert.ToInt16(ileZnakow.Text);
            char[] haslo = new char[liczbaZnakow];
            for (int i = 0; i < haslo.Length; i++)
                haslo[i] =alfabetM[random.Next(0,25)];
            
            if(maleIwielkie.Checked)
                haslo[0] = alfabetW[random.Next(0, 25)];
            
            if(cyfry.Checked && haslo.Length > 1)
                haslo[1] = Cyfry[random.Next(0, 10)];

            if (znakiSpecjalne.Checked && haslo.Length>2)
                haslo[2] = znakiS[random.Next(0, 14)];

            
            for (int i = 0; i < haslo.Length; i++)
                caleHaslo +=haslo[i];
            MessageBox.Show(caleHaslo);
            
        }


        //*************************
        //nazwa funkcji: zatwierdz
        //opis funkcji: funkcja wyœwietla dane pracownika
        //parametry:    sender - podstawowy element forms
        //              e - podstawowy element forms
        //zwracany typ i opis: zwraca void
        //autor: Krzysztof Krówka
        //*************************
        private void zatwierdz(object sender, EventArgs e)
        {
            MessageBox.Show("Dane pracownika: " + imie.Text + " " + nazwisko.Text + " " + stanowisko.Text + " Has³o: " + caleHaslo);
        }
    }
}
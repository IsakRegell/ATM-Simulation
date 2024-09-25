namespace ATM_Simulation
{
    internal class Bankkonto
    {
        private int kontonummer;
        private int pinkod;
        private int saldo;


        public Bankkonto(int kontonummer, int pinkod)
        {
            this.kontonummer = kontonummer;
            this.pinkod = pinkod;
            this.saldo = 0;
        }

        public void Deposit(int money)
        {
            this.saldo = this.saldo + money; 
        }


        public void Draw(int money)
        {
            this.saldo = this.saldo - money;
        }

        public int CheckBalance()
        {
            return this.saldo;
        }

        public Boolean Loggin(int pinkod)
        {
            return this.pinkod == pinkod;
        }

        public int Kontonummer
        {
            get { return kontonummer; }
            set { kontonummer = value; }
        }


        public int Pinkod
        {
            get { return pinkod; }
            set { pinkod = value; }
        }


        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }



    }

  

}





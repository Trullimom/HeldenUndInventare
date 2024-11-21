namespace HelndeUndInventare{
    internal class Trank : Gegenstand
    {
        Random rnd = new Random();
        private int heilungsmenge;

        public Trank(string n, int g) : base(n, g)
        { 
            this.heilungsmenge = rnd.Next(1,10);
        }

        public int Heilungsmenge{
            get { return heilungsmenge; }
        }

        public override void Benutzen(){
            Console.WriteLine($"Du trinkst {this.Name} und heilst dich um {this.Heilungsmenge}.");
            
        }
    }
}
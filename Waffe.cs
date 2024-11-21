namespace HelndeUndInventare{
    internal class Waffe : Gegenstand
    {
        Random rnd = new Random();
        
        private int schaden;

        public Waffe(string n, int g) : base(n, g)
        {
            this.schaden = rnd.Next(1,10);
        }

        public int Schaden{
            get { return schaden; }
        }

        public override void Benutzen(){
            Console.WriteLine($"Du greifst mit {this.Name} an und verursacht {this.Schaden}.");
            
        }
    }    
}
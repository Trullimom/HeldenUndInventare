namespace HelndeUndInventare{
    internal class Gegenstand{
        private string name;
        private int gewicht;

        public Gegenstand(string n, int g) {
            this.name = n;  
            this.gewicht = g;  
        }

        public string Name {
            get { return name;}
            set { name = value;}
        }

        public virtual void Benutzen(){
            Console.WriteLine($"Du benutzt den Gegnestand");            
        }
    }
}
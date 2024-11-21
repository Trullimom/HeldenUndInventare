namespace HelndeUndInventare
{
    internal class Held
    {
        private string name;
        private int lebenspunkte;
        private Inventar invent = new Inventar();
        public Held(string n, int lp)
        {
            this.name = n;
            this.lebenspunkte = lp;
        }
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public Inventar Invent
        {
            get { return invent; }
        }
        public int Lebenspunkte
        {
            get { return lebenspunkte; }
            set { lebenspunkte = value;}
        }

        public void AddItem(Gegenstand g)
        {
            invent.Hinzufuegen(g);
        }
        public void GreifAn(Held ziel, int waffenIndex)
        {
            if (waffenIndex < invent.waffenList.Count())
            {      
                Gegenstand gs = invent.waffenList[waffenIndex];
                gs.Benutzen();
                invent.Entfernen(gs);              
                ziel.Lebenspunkte -= ((Waffe)gs).Schaden;
                LpAnzeigen(ziel);
            }
            else
            {
                Console.WriteLine($"Ungültige Auswahl");
            }                                          
        }

        public void Heilen(int index)
        {
                  
            if (index < invent.trankList.Count())
            {
                Gegenstand gs = invent.trankList[index];
                gs.Benutzen();
                invent.Entfernen(gs);                
                this.Lebenspunkte += ((Trank)gs).Heilungsmenge;
                LpAnzeigen(this);
            }
            else
            {
                Console.WriteLine($"Ungültige Auswahl");
            }
        }

        public void LpAnzeigen(Held h){
            if(h.Lebenspunkte  < 0){
                h.Lebenspunkte = 0;
            }
            Console.WriteLine($"{h.Name} hat {h.Lebenspunkte} Lebenspunkte");
            
        }
    }
}
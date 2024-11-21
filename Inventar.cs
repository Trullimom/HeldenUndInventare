namespace HelndeUndInventare{
    internal class Inventar
    {
        public List<Gegenstand> waffenList = new List<Gegenstand>();
        public List<Gegenstand> trankList = new List<Gegenstand>();
        public void Hinzufuegen(Gegenstand g)
        {
            if(g is Waffe){
                waffenList.Add(g);
            }else if(g is Trank){
                trankList.Add(g);
            }
        }

        public void Entfernen(Gegenstand g)
        {
            if(g is Waffe){
                waffenList.Remove(g);
            }else if(g is Trank){
                trankList.Remove(g);
            }
        }

        public void WaffenmenuAnzeigen()
        {            
            for(int i = 0 ; i < waffenList.Count(); i++){
                Console.WriteLine($"{i+1}. {waffenList[i].Name}");               
            }
        }

        public void TrankmenuAnzeigen()
        {
            for (int i = 0; i < trankList.Count(); i++)
                {
                    Console.WriteLine($"{i+1}. {trankList[i].Name}");            
                }
        }
    }
}
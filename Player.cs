namespace firstConsoleApp_basketballStats
{
    internal class Player
    {
        public Player()
        {

        }
           
        public string? Name { get; set; }
        public int ShotsAttempted { get; set; }

        public int ShotsMade { get; set; }

        public double percentage { get { return (Convert.ToDouble(ShotsMade) / Convert.ToDouble(ShotsAttempted)); } }

       // public bool Save()
        //{ return true; 
        //}

        /*public List<Player> Retrieve()
        { return new List<Player>(); 
        }
        */

    }
}
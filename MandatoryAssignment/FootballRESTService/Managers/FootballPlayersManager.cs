using MandatoryAssignment;

namespace FootballRESTService.Managers
{
    public class FootballPlayersManager
    {
        private static int _nextId = 1;
        private static List<FootballPlayer> _players = new List<FootballPlayer>()
        {
            new FootballPlayer(){Id = _nextId++, Name = "Victor", Age = 25, ShirtNumber = 1 },
            new FootballPlayer(){Id = _nextId++, Name = "Martin", Age = 29, ShirtNumber = 11 },
            new FootballPlayer(){Id = _nextId++, Name = "Andreas", Age = 26, ShirtNumber = 8 },
            new FootballPlayer(){Id = _nextId++, Name = "Frederik", Age = 24, ShirtNumber = 4 }
        };

        public List<FootballPlayer> GetAll()
        {
            return _players;
        }
        public FootballPlayer GetById(int id)
        {
            return _players.Find(player => player.Id == id);
        }
        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.Id = _nextId++;
            _players.Add(newPlayer);
            return newPlayer;
        }
        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = GetById(id);
            if (player == null) return null;
            _players.Remove(player);
            return player;
        }
        public FootballPlayer Update(int id, FootballPlayer update)
        {
            FootballPlayer player = GetById(id);
            if (player == null) return null;
            player.Name = update.Name;
            player.ShirtNumber = update.ShirtNumber;
            player.Age = update.Age;
            return player;
        }
    }
}

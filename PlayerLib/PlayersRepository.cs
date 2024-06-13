using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLib
{
    public class PlayersRepository
    {
        private int _nextId = 6;
        private List<Player> _players = new List<Player>
        {
            new Player { Id = 1, FirstName = "Marcus", LastName = "Rashford", Number = 10, Position = "Forward" },
            new Player { Id = 2, FirstName = "Bruno", LastName = "Fernandes", Number = 8, Position = "Midfielder" },
            new Player { Id = 3, FirstName = "Harry", LastName = "Maguire", Number = 5, Position = "Defender" },
            new Player { Id = 4, FirstName = "Andre", LastName = "Onana", Number = 24, Position = "Goalkeeper" },
            new Player { Id = 5, FirstName = "Rasmus", LastName = "Hæjlund", Number = 11, Position = "Forward" }

        };

        public IEnumerable<Player> GetAllPlayers()
        {
            return _players;
        }

        public Player GetPlayerById(int id)
        {
            return _players.FirstOrDefault(p => p.Id == id);
        }

        public void AddPlayer(Player player)
        {
            player.Id = _nextId++;
            _players.Add(player);
        }

        public void UpdatePlayer(Player player)
        {
            var existingPlayer = _players.FirstOrDefault(p => p.Id == player.Id);
            if (existingPlayer != null)
            {
                existingPlayer.FirstName = player.FirstName;
                existingPlayer.LastName = player.LastName;
                existingPlayer.Number = player.Number;
                existingPlayer.Position = player.Position;
            }
        }

        public void DeletePlayer(int id)
        {
            var player = _players.FirstOrDefault(p => p.Id == id);
            if (player != null)
            {
                _players.Remove(player);
            }
        }

    }
}

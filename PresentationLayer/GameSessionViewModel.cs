using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {
        #region FIELDS

        private Player _player;
        private List<string> _messages;
        private Map _map;

        #endregion
        #region PROPERTIES
        public Map Map
        {
            get { return _map; }
            set
            {
                _map = value;
                OnPropertyChanged(nameof(Map));
            }
        }

        /// <summary>
        /// return the list of strings with new lines between each message
        /// </summary>
        public string MessageDisplay
        {
            get { return string.Join("\n\n", _messages); }
        }

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        #endregion
        #region CONSTRUCTORS

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> startUpMessage, Map map)
        {
            Player = player;
            _messages = startUpMessage;

            Map = map;
            Map.CurrentLocation = _map.MapLocations.FirstOrDefault(l => l.Id == _map.CurrentLocationId);
        }

        #endregion
        #region METHODS
        /// <summary>
        /// Method to move player back one in map
        /// </summary>
        internal void MoveToPreviousIsle()
        {
            if (Map.CurrentLocationId > 0)
            {
                _map.CurrentLocationId -= 1;
                Map.CurrentLocation = _map.MapLocations.FirstOrDefault(l => l.Id == _map.CurrentLocationId);
            }
        }
        /// <summary>
        /// Method to move player to the next map location
        /// </summary>
        public void MoveToNextIsle()
        {
            //take the maps current location Id and compare it to the location array length
            if (Map.CurrentLocationId < _map.MapLocations.Length - 1)
            {
                _map.CurrentLocationId += 1;
                Map.CurrentLocation = _map.MapLocations.FirstOrDefault(l => l.Id == _map.CurrentLocationId);
            }
        }

        #endregion

    }
}

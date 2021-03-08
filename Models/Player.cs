using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame;

namespace TBQuestGame.Models
{
    /// <summary>
    /// Player class with inheritance from character class
    /// </summary>
    public class Player: Character
    {
        #region FIELDS
        //attributes of player
        private int _health;
        private int _lives;
        private int _currency;

        #endregion

        #region PROPERTIES
        public int Currency
        {
            get { return _currency; }
            set 
            { 
                _currency = value;
                OnPropertyChanged(nameof(Currency));
            }
        }

        public int Lives
        {
            get { return _lives; }
            set 
            { 
                _lives = value;
                OnPropertyChanged(nameof(Lives));
            }
        }

        public int Health
        {
            get { return _health; }
            set 
            {
                _health = value;
                if (_health > 100)
                {
                    _health = 100;
                }
                else if (_health <= 0)
                {
                    _lives--;
                }
                OnPropertyChanged(nameof(Health));
            }
        }
        #endregion
        #region CONSTRUCTORS

        #endregion
        #region METHODS

        public override string DefaultPlayerGreeting()
        {
            return $"Hello my name is {_name} and I am looking for materials.";
        }

        #endregion
    }
}

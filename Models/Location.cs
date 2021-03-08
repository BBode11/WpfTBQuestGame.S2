using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Location
    {
        #region FIELDS
        private int _id;
        private string _name;
        private string _description;
        private int _modifyHealth;
        //private int _modifyLives;
        //private bool _accessible;

        

        private string _message;
        //add accessible for checkout?

        #endregion

        #region PROPERTIES
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        } 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int ModifyHealth
        {
            get { return _modifyHealth; }
            set { _modifyHealth = value; }
        }
        //public int ModifyLives
        //{
        //    get { return _modifyLives; }
        //    set { _modifyLives = value; }
        //}
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        //public bool Accessible
        //{
        //    get { return _accessible; }
        //    set { _accessible = value; }
        //}


        #endregion

        #region CONSTRUCTORS

        #endregion
    }
}

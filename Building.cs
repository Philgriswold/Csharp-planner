using System;
using System.Collections.Generic;

namespace Planner
{

    class Building
    {
        private string _designer = "Phil";

        private DateTime _dateConstructed;

        private string _address;

        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return this.Width * this.Depth * (3 * this.Stories);
            }
        }
        public Building(string address)
        {
            {
                _address = address;
            }

        }
        public string Description
        {
            get
            {
                return $"{_address}, designed by {_designer}, constructed on {_dateConstructed}, owned by {_owner}, {Volume}";
            }
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyerName)
        {
            _owner = buyerName;
        }
        public void addBuilding()
        {

        }


    }
}
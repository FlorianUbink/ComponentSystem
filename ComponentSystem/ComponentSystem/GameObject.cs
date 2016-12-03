using ComponentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentSystem
{
    public class GameObject
    {
        #region Fields
        public Bag myBag;
        #endregion

        public GameObject(int objectid)
        {
            myBag = new Bag(); // Creates new instance of Bag
            myBag.objectid = objectid; // adds objectid to Bag property
        }

        public void Distroy()
        {
            myBag = null; // removes Bag
        }
    }
}

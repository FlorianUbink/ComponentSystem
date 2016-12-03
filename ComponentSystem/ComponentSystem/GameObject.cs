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
        Bag myBag;
        #endregion

        public GameObject(int objectid)
        {
            myBag = new Bag();
            myBag.objectid = objectid;
        }

        public void Distroy()
        {
            myBag = null;
        }
    }
}

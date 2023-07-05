using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrain
{
    class World
    {
        Point StartPosition;
        List<DrawbleObject> positionObject = new List<DrawbleObject>();


        public void AddObject(DrawbleObject t)
        {
            positionObject.Add(t);
        }
    }
}

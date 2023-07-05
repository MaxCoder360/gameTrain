using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrain
{

    public class BaseAnimationState
    {
        protected Point coords; // coordinates for your collider

        protected Image skin;
        protected BaseAnimationState(Point p, Image skin)
        {
            coords = p;
            this.skin = skin;
        }
    }
}

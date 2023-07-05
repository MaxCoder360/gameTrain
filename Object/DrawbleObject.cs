using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrain
{
    public abstract class DrawbleObject
    {
        protected Point position;
        protected Size size;
        protected bool movable;
        protected Point movementSpeed;
        protected Image image;
        //public Animation animation = new Animation();

        public abstract BaseAnimationState Update();

        public Point GetPosition()
        {
            return position;
        }

        public bool IsMovable()
        {
            return movable;
        }
    }

    
}

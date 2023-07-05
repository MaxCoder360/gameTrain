using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrain
{
    public class Player : DrawbleObject
    {

        public Player(Point position, Size size, Image image = null)
        {
            this.position = position;
            this.size = size;
            //this.image = image;
        }

        public override BaseAnimationState Update()
        {
            throw new NotImplementedException();
        }
    }
}

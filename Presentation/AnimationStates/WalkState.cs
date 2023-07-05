using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrain.Presentation.AnimationStates
{
    class WalkState : BaseAnimationState
    {
        public WalkState(Point p, Image skin) : base(p, skin) { }
    }
}

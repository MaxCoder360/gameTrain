using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrain
{
    /*public enum AnimationStates
    {
        idle, run, walk, jump
    }*/

    class Animation
    {
        private List<NPC> npcs;
        public static Animation anime
        {
            get => anime;
            private set { anime = new Animation(); }
        }

        private Animation() { }

        /*public void update(List<NPC> data) // is called from Timer Bulat
        {
            BaseAnimationState state;
            foreach (npc in data)
                state = npc.update();

            switch(state)
            {
                case is RunState:
                    drawRunState(state as RunState);
            }
        }*/

        private void drawRunState(RunState state)
        {
            // myBuffer...
        }
    }
}

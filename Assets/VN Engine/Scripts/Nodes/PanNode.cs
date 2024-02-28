using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace VNEngine
{
    // Not used in real code. Merely a template to copy and paste from when creating new nodes.
    public class PanNode : Node
    {
        public Vector3 desiredPosition;
        // Called initially when the node is run, put most of your logic here
        public override void Run_Node()
        {
            Actor[] actors = ActorManager.actors_on_scene.ToArray();
            for(int i = 0; i < actors.Length; i++)
            {
                actors[i].desired_position += desiredPosition;
            }
            // if there's no need to  wait for other operations/coroutines, call finish node at the end of this method
            Finish_Node();
        }


        // What happens when the user clicks on the dialogue text or presses spacebar? Either nothing should happen, or you call Finish_Node to move onto the next node
        public override void Button_Pressed()
        {
            //Finish_Node();
        }


        // Do any necessary cleanup here, like stopping coroutines that could still be running and interfere with future nodes
        public override void Finish_Node()
        {
            StopAllCoroutines();

            base.Finish_Node();
        }
    }
}
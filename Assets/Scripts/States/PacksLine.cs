using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
namespace States
{
    public class PacksLine : BaseState
    {
       
        public override void Initialize()
        {
           
           
        } 
        
        
        public override void Resume(StateExitValue results)
        {
            
        }
        public override void Suspend()
        {
            HideUI();

        }

        public override StateExitValue Cleanup()
        {
            DestroyUI();
            return null;
        }

        public override void HandleUIEvent(GameObject source, object eventData)
        {
            
           // if (source == GetPacksLine_GUI_Component.Back.gameObject)
           // {
           //     manager.PopState();
           // }
           //
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class StartMenu : BaseState
    {
        Menus.StartMenu_GUI GUI_Component;
        public override void Initialize()
        {
            GUI_Component = SpawnUI<Menus.StartMenu_GUI>(StringConstants.StartMenu_Prefab);

        }


        public override void Resume(StateExitValue results)
        {
            ShowUI();
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

             if (source ==GUI_Component.Play.gameObject)
             {
                manager.PushState(new ChooseGirls());
             }
            
        }
    }
}
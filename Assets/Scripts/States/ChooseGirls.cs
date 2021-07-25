using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class ChooseGirls : BaseState
    {
        Menus.ChooseGirls_GUI GUI_Component;
        public override void Initialize()
        {
            GUI_Component = SpawnUI<Menus.ChooseGirls_GUI>(StringConstants.ChosseGirlsMenu_Prefab);

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
            Debug.Log(source.GetComponent<ConfigGirls>().Name);
            if (source == GUI_Component.Btn1.gameObject)
             {
                Debug.Log("Btn");
             }
            manager.PushState(new MagazineState(source.GetComponent<ConfigGirls>().Name));
        }
    }
}

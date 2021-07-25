using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class PaletteChoose : BaseState
    {
        Menus.PaletteChoose_GUI GUI_Component;
        public override void Initialize()
        {
            GUI_Component = SpawnUI<Menus.PaletteChoose_GUI>(StringConstants.PaletteMenu_Prefab);

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

            if (source == GUI_Component.Pl1.gameObject)
            {
                Debug.Log("Pl1");
            }
            if (source == GUI_Component.Pl2.gameObject)
            {
                Debug.Log("Pl2");
            }
            if (source == GUI_Component.Pl3.gameObject)
            {
                Debug.Log("Pl3");
            }
            if (source == GUI_Component.Pl4.gameObject)
            {
                Debug.Log("Pl4");
            }
            if (source == GUI_Component.Pl5.gameObject)
            {
                Debug.Log("Pl5");
            }
            if (source == GUI_Component.Pl6.gameObject)
            {
                Debug.Log("Pl6");
            }
            if (source == GUI_Component.Pl7.gameObject)
            {
                Debug.Log("Pl7");
            }
            if (source == GUI_Component.Pl8.gameObject)
            {
                Debug.Log("Pl8");
            }

        }
    }
}

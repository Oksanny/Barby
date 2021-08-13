using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class PaletteChoose : BaseState
    {
        Menus.PaletteChoose_GUI GUI_Component;
        Girls currentGirls;
        int numberModel;
        int nexPart = 0;
        public PaletteChoose(Girls girl, int chooseModel)
        {
            currentGirls = girl;
            numberModel = chooseModel;
        }
        public override void Initialize()
        {
            GUI_Component = SpawnUI<Menus.PaletteChoose_GUI>(StringConstants.PaletteMenu_Prefab);
            GUI_Component.StartAssets();
            GUI_Component.SetPrevieModel(numberModel);
            GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart+1).ToString()));
            CommonData.prefabs.StartCoroutine(StartVideo());

        }
        IEnumerator StartVideo()
        {
            yield return new WaitForSeconds(1);
            GUI_Component.PrevieModel.gameObject.SetActive(false);
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
                nexPart++;
                if(nexPart<4)
                {
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }

                }
                
            }
            if (source == GUI_Component.Pl2.gameObject)
            {
                Debug.Log("Pl2");
                nexPart++;
                if (nexPart < 4)
                {
                    
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }
                }
                else
                {
                    GUI_Component.StopClip();
                }
            }
            if (source == GUI_Component.Pl3.gameObject)
            {
                Debug.Log("Pl3");
                nexPart++;
                if (nexPart < 4)
                {
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }
                }
                
            }
            if (source == GUI_Component.Pl4.gameObject)
            {
                Debug.Log("Pl4");
                nexPart++;
                if (nexPart < 4)
                {
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }
                }
                
            }
            if (source == GUI_Component.Pl5.gameObject)
            {
                nexPart++;
                if (nexPart < 4)
                {
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }
                }
                
                Debug.Log("Pl5");
            }
            if (source == GUI_Component.Pl6.gameObject)
            {
                nexPart++;
                if (nexPart < 4)
                {
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }
                }
                
                Debug.Log("Pl6");
            }
            if (source == GUI_Component.Pl7.gameObject)
            {
                nexPart++;
                if (nexPart < 4)
                {
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }
                }
                
                Debug.Log("Pl7");
            }
            if (source == GUI_Component.Pl8.gameObject)
            {
                nexPart++;
                if (nexPart < 4)
                {
                    GUI_Component.MoveCloth(nexPart - 1);
                    if (nexPart == 3)
                    {
                        GUI_Component.StopClip();
                    }
                    else
                    {
                        GUI_Component.SetVideoClip((numberModel.ToString() + (nexPart + 1).ToString()));
                    }
                }
                
                Debug.Log("Pl8");
            }
            if (source == GUI_Component.Back.gameObject)
            {
                manager.SwapState(new MagazineState(currentGirls));
            }
            
        }
    }
}

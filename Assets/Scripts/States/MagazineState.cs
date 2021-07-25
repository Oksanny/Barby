using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace States
{
    public class MagazineState : BaseState
    {
        Menus.Magazine_GUI GUI_Component;
        bool isStartMagazine;
        bool isPlaingStartMagazine;
        bool isPlayingHi;
        bool isStart;
        bool isEnd;
        bool finderDown;
        bool isPressed;
        bool isEndAnimation;
        Vector2 startPosition;
        int pixelDistToDetectt = 30;
        List<int> Points = new List<int>();
        bool isPlayAnimation;
        Girls NameGirls;
        public MagazineState(Girls name)
        {
            NameGirls = name;
        }
        public override void Initialize()
        {
            GUI_Component = SpawnUI<Menus.Magazine_GUI>(StringConstants.MagazinetMenu_Prefab);
            GUI_Component.vid.loopPointReached += CheckOver;
            GUI_Component.StartVideoAssets();
            GUI_Component.vid.clip = GUI_Component.assetVideoClip[NameGirls];
            GUI_Component.vid.Play();
            Points.Add(0);

        }
        public void CheckOver(UnityEngine.Video.VideoPlayer vp)
        {
            Debug.Log("Video Is Over");
            isPlayingHi = true;
        }
        public override void Update()
        {
            if (GUI_Component.animControllerBack.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && isEndAnimation)
            {
                Debug.Log("The End");
               // manager.PushState(new PaletteChoose());
                isEndAnimation = false;
            }
                if (GUI_Component.animController.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && isStart)
            {  //If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
                EndAnimation();
                isStart = false;
            }
            if (GUI_Component.animController.GetCurrentAnimatorStateInfo(0).normalizedTime < 1 && GUI_Component.animController.GetCurrentAnimatorStateInfo(0).normalizedTime > 0)
            {  //If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
               // Debug.Log("playing");
                isStart = true;
            }
           if (!finderDown && Input.GetMouseButtonDown(0))
           {
               startPosition = Input.mousePosition;
               finderDown = true;
                isPressed = false;
           }
           if (finderDown )
           {
                if(Mathf.Abs( Input.mousePosition.x - startPosition.x)< pixelDistToDetectt && Input.GetMouseButtonUp(0) && !isEndAnimation)
                {
                    Debug.Log("Press");
                    if(isPressed&& Points[Points.Count - 1] > 0)
                    {
                        Debug.Log("CHOOSE " + Points[Points.Count - 1]);
                        isEndAnimation = true;
                        GUI_Component.animController.SetTrigger("End");
                        GUI_Component.animControllerBack.SetTrigger("Back_2");
                        GUI_Component.animControllerGirl.SetTrigger("Girl_1");
                        CommonData.prefabs.StartCoroutine(StartNexState());

                    }
                   
                    // manager.PushState(new PaletteChoose());
                    finderDown = false;
                   
                }
              
                if (Mathf.Abs(Input.mousePosition.x - startPosition.x) > pixelDistToDetectt && Input.GetMouseButtonUp(0)&&!isEndAnimation)
                {
                  //  Debug.Log("Swipe");
                    if (Input.mousePosition.x - startPosition.x <0 && isPlaingStartMagazine)
                    {
                        finderDown = false;
                        //Debug.Log("Left");
                        if (Points[Points.Count - 1] < 4 && !isStart && isPlaingStartMagazine)
                        {
                            Points.Add(Points[Points.Count - 1] + 1);
                          //  Debug.Log(Points[Points.Count - 2] + "  " + Points[Points.Count - 1]);
                            PlayAnimation(Points[Points.Count - 2].ToString() + Points[Points.Count - 1].ToString());
                            Points.RemoveAt(0);
                           //   PrintList();
                        }

                    }
                    if (Input.mousePosition.x -startPosition.x >0 && isPlaingStartMagazine)
                    {
                        finderDown = false;
                        //  Debug.Log("Right");
                        if (Points[Points.Count - 1] > 0 && !isStart)
                        {
                            Points.Add(Points[Points.Count - 1] - 1);
                          //  Debug.Log(Points[Points.Count - 2] + "  " + Points[Points.Count - 1]);
                            PlayAnimation(Points[Points.Count - 2].ToString() + Points[Points.Count - 1].ToString());
                            Points.RemoveAt(0);
                           //  PrintList();
                        }


                    }
                    finderDown = false;
                }
                  
            }
        }
        void EndAnimation()
        {
            Debug.Log("not playing");
            if(isStartMagazine)
            {
                isPlaingStartMagazine = true;
                isStartMagazine = false;
            }
        }
        void PrintList()
        {
            string str = "[";
            foreach (var item in Points)
            {
                str += item.ToString() + ", ";
            }
            str += "]";
            Debug.Log(str);
        }
        void PlayAnimation(string trigger)
        {
            GUI_Component.animController.SetTrigger(trigger);
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
        IEnumerator StartNexState()
        {
            yield return new WaitForSeconds(4);
            manager.PushState(new PaletteChoose());
        }
        public override void HandleUIEvent(GameObject source, object eventData)
        {
            Debug.Log("Btn1");
            if (source == GUI_Component.ChooseModel.gameObject&&isPlayingHi&&!isPlaingStartMagazine && !isEndAnimation)
             {
               
                Debug.Log("Btn2");
                isStartMagazine = true;
                GUI_Component.animController.SetTrigger("Start");
                GUI_Component.animControllerBack.SetTrigger("Back_1");
                GUI_Component.animControllerGirl.SetTrigger("Start");
                //source.SetActive(false);
            }
           if (source == GUI_Component.ChooseModel.gameObject && !isEndAnimation)
           {
                isPressed = true;
                
            }
            if (source == GUI_Component.Back.gameObject )
            {
                manager.PopState();

            }

        }
    }
}
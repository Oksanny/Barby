using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public enum Girls
{
    Mimi,
    Kika,
    Tali,
    Rene

}
namespace Menus
{
    public class ChooseGirls_GUI : BaseMenu
    {
        public GUIButton Btn1;
        public GUIButton Btn2;
        public GUIButton Btn3;
        public GUIButton Btn4;
        public void Back()
        {
            Debug.Log("Back");
        }
        public void Forwardk()
        {
            Debug.Log("Forwardk");
        }
        public void Swipe()
        {
            Debug.Log("Swipe");

        }
        public void SwipeScrolling()
        {
            Debug.Log("SwipeScrollin");
            Btn1.gameObject.GetComponent<VideoPlayer>().Stop();
            Btn2.gameObject.GetComponent<VideoPlayer>().Stop();
            Btn3.gameObject.GetComponent<VideoPlayer>().Stop();
            Btn4.gameObject.GetComponent<VideoPlayer>().Stop();
        }
        public void Selecter(GameObject charecter)
        {
            Debug.Log(charecter.name);
            Btn1.gameObject.GetComponent<VideoPlayer>().Stop();
            Btn2.gameObject.GetComponent<VideoPlayer>().Stop();
            Btn3.gameObject.GetComponent<VideoPlayer>().Stop();
            Btn4.gameObject.GetComponent<VideoPlayer>().Stop();
            charecter.gameObject.GetComponent<VideoPlayer>().Play();
        }
    }
}

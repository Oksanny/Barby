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
        public GUIButton BackButton;
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
            Btn1.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn2.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn3.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn4.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn1.gameObject.GetComponent<AudioSource>().Stop();
            Btn2.gameObject.GetComponent<AudioSource>().Stop();
            Btn3.gameObject.GetComponent<AudioSource>().Stop();
            Btn4.gameObject.GetComponent<AudioSource>().Stop();
        }
        public void Selecter(GameObject charecter)
        {
            Debug.Log(charecter.name);
            Btn1.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn2.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn3.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn4.gameObject.GetComponent<Animator>().SetTrigger("Idle");
            Btn1.gameObject.GetComponent<AudioSource>().Stop();
            Btn2.gameObject.GetComponent<AudioSource>().Stop();
            Btn3.gameObject.GetComponent<AudioSource>().Stop();
            Btn4.gameObject.GetComponent<AudioSource>().Stop();
            charecter.gameObject.GetComponent<Animator>().SetTrigger("Go");
            charecter.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}

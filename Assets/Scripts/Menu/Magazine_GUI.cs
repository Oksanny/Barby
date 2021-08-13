using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace Menus{
    public class Magazine_GUI : BaseMenu
    {
        public Animator animControllerGirls;
        public Animator animControllerMagazineParent;
        public Dictionary<Girls, GameObject> assetGirls;





        public GameObjectGirls[] Girls;
        public VideoPlayer vid;
       
       
        public Animator animController;
        public Animator animControllerBack;
        public Animator animControllerGirl;
        public GUIButton StartMagazine;
        public GUIButton ChooseModel;
        public GUIButton Back;
        public void StartVideoAssets()
        {
            assetGirls = new Dictionary<Girls, GameObject>();
            foreach (GameObjectGirls entry in Girls)
            {
                assetGirls[entry.name] = entry.girl;
            }
        }
    }
    
}
[System.Serializable]
public struct GameObjectGirls
{
    public GameObjectGirls(Girls name, GameObject girl)
    {
        this.name = name;
        this.girl = girl;
    }
    public Girls name;
    public GameObject girl;
}

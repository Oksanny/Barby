using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace Menus{
    public class Magazine_GUI : BaseMenu
    {
        public VideoClipGirls[] Clips;

        public Dictionary<Girls, VideoClip> assetVideoClip;
        public VideoPlayer vid;
       
       
        public Animator animController;
        public Animator animControllerBack;
        public Animator animControllerGirl;
        public GUIButton StartMagazine;
        public GUIButton ChooseModel;
        public GUIButton Back;
        public void StartVideoAssets()
        {
            assetVideoClip = new Dictionary<Girls, VideoClip>();
            foreach (VideoClipGirls entry in Clips)
            {
                assetVideoClip[entry.name] = entry.clip;
            }
        }
    }
    
}
[System.Serializable]
public struct VideoClipGirls
{
    public VideoClipGirls(Girls name, VideoClip clip)
    {
        this.name = name;
        this.clip = clip;
    }
    public Girls name;
    public VideoClip clip;
}

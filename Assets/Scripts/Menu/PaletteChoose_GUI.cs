using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
namespace Menus
{
    public class PaletteChoose_GUI : BaseMenu
    {
        public List<Animator> ClothsAnim;
        public List<Sprite> ClothsTexture;
        public VideoPlayer ModelVideo;
        public GUIButton Pl1;
        public GUIButton Pl2;
        public GUIButton Pl3;
        public GUIButton Pl4;
        public GUIButton Pl5;
        public GUIButton Pl6;
        public GUIButton Pl7;
        public GUIButton Pl8;
        public GUIButton Back;
        public Image PrevieModel;
        public SpritePalette[] Sprts;
        public VideoClipModel[] Clips;
        public Dictionary<int, Sprite> assetSprts;
        public Dictionary<string, VideoClip> assetSClips;
        public void StartAssets()
        {
            
            assetSprts = new Dictionary<int, Sprite>();
            foreach (SpritePalette entry in Sprts)
            {
                assetSprts[entry.number] = entry.txt;
            }
            assetSClips = new Dictionary<string, VideoClip>();
            foreach (VideoClipModel entry in Clips)
            {
                assetSClips[entry.name] = entry.clip;
            }
        }
        public void SetPrevieModel(int number)
        {
            PrevieModel.sprite = assetSprts[number];
        }
        public void SetVideoClip(string name)
        {
            Debug.Log(name);
            ModelVideo.clip = assetSClips[name];
            ModelVideo.Play();
        }
        public void StopClip()
        {
            
            ModelVideo.Stop();
        }
        public void MoveCloth(int number)
        {
            ClothsAnim[number].gameObject.GetComponentInChildren<Image>().sprite = ClothsTexture[number];
            ClothsAnim[number].SetTrigger("Move");

        }
    }
    
}
[System.Serializable]
public struct VideoClipModel
{
    public VideoClipModel(string name, VideoClip clip)
    {
        this.name = name;
        this.clip = clip;
    }
    public string name;
    public VideoClip clip;
}

    [System.Serializable]
public struct SpritePalette
{
    public SpritePalette(int number, Sprite sp)
    {
        this.number = number;
        this.txt = sp;
    }
    public int  number;
    public Sprite txt;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainManager : MonoBehaviour
{
  
    [HideInInspector]
    public States.StateManager stateManager = new States.StateManager();
    // Use this for initialization
    void Start()
    {
       
        StartGame();
      
    }

    // Update is called once per frame
    void Update()
    {
        stateManager.Update();
    }
    void FixedUpdate()
    {
        stateManager.FixedUpdate();
    }
    
    void StartGame()
    {

        CommonData.prefabs = FindObjectOfType<PrefabList>();
        CommonData.canvasHolder = GameObject.Find("CanvasHolder");
       
        CommonData.mainManager = this;
        CommonData.stateManager = stateManager;

         stateManager.PushState(new States.StartMenu());
       // stateManager.PushState(new States.PaletteChoose(Girls.Tali ,4));
    }
}
    


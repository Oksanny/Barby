using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Test : MonoBehaviour
{
    public VideoPlayer magazine;
    public GameObject magazineObj;
    public GameObject girlObj;
    public bool move = false;
    public bool move2 = false;
    public Transform target;
    public Transform target2;
    public Transform pointA;
    float speed = 10;
    public GameObject image;
    public GameObject Fason10Obj;
    public VideoPlayer Fason10Video;
    public GameObject pallet;
    public GameObject cloth_01;
    public GameObject cloth_02;
    public GameObject cloth_03;
    public VideoPlayer TaliMes;
    public VideoPlayer TaliMesNote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            Debug.Log("move");
            float step = speed;
            pointA.position = Vector3.MoveTowards(pointA.position, target.position, step);
            if (image.transform.localScale.x <= 0.74f)
            {
                image.transform.localScale += new Vector3(0.0015f, 0.0015f, 0.0015f);
            

            }
            else
            {
                move = false;
            }
            if (pointA.position.x == target.position.x)
            {

                
                Fason10();
            }
        }
        if (move2)
        {
            float step = speed;
            pointA.position = Vector3.MoveTowards(pointA.position, target2.position, step);
            if (image.transform.localScale.x >= 0.5f)
            {
                image.transform.localScale -= new Vector3(0.0015f, 0.0015f, 0.0015f);


            }
            else
            {
                State3();
                move = false;
            }
            if (pointA.position.x == target.position.x)
            {


                Fason10();
            }
        }
    }
    public void State3()
    {
        TaliMesNote.Play();
        TaliMes.Play();
    }
    public void Fason10()
    {
        pallet.SetActive(true);
        Fason10Video.Play();
    }
    public void LoadMainScene()
    {
        Application.LoadLevel("Main");
    }
    public void LoadCatalogScene()
    {
        Application.LoadLevel("Catalog");
    }
    public void PlayMagazine()
    {
        magazine.Play();
       // magazine.frameRate <100
      //  magazineObj.SetActive(true);
    }
    public void MoveStage2()
    {
        girlObj.SetActive(false);
        magazineObj.SetActive(false);
        move = true;
    }
    public void MoveStage3()
    {
        pallet.SetActive(false);

        cloth_01.SetActive(false);
        cloth_02.SetActive(false);
        cloth_03.SetActive(false);
        Fason10Obj.SetActive(false);
        move2 = true;
    }
}

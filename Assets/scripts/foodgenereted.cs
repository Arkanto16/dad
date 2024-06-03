using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodgenereted : MonoBehaviour
{
    public GameObject foodPrefab;
    public float Xsize = 5.6f;
    public float Zsize = 5.6f;
    public Vector3 curPos;
    public GameObject curFood;

    void AddNewFood()
    {
        RandemPos();
        curFood = GameObject.Instantiate(foodPrefab,curPos, Quaternion.identity) as GameObject;
    }
     void RandemPos()
    {
        curPos=new Vector3 (Random.Range(Xsize*-1, Xsize),0.25f,Random.Range(Zsize*-1, Zsize));
    }

    void Update()
    {
        if(!curFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}

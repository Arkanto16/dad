using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 6f;
    public float ZSize = 6f;
    public GameObject foodPrefab;
    public Vector3 curPos;
    public GameObject curFood;


 

    void AddNewFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    }

    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), 0.25f, Random.Range(ZSize * -1, ZSize));
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

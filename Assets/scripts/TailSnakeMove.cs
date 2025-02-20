using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailSnakeMove : MonoBehaviour
{
    public float Speed;
    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public SnakeMainMove mainSnake;
    public int indx;
    void Start()
    {
        
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMainMove>();
        Speed = mainSnake.Speed;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        indx = mainSnake.tailObjects.IndexOf(gameObject);

    }

   
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if(indx > 2)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            
        }
    }
}

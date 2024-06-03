
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TailMovment : MonoBehaviour
{
    public float Speed;

    public Vector3 tailTarget;
    public GameObject tailTargetObj;

    public int indx;

    public snakeMoving mainSnake;

    void Start()
    {

        mainSnake = GameObject.FindGameObjectWithTag("snakeMain").GetComponent<snakeMoving>();
        Speed = mainSnake.Speed+1.5f;
        tailTargetObj = mainSnake.taillobjects[mainSnake.taillobjects.Count-2];
        indx = mainSnake.taillobjects.IndexOf(gameObject);
    }

    void Update()
    {
        tailTarget=tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("snakeMain"))
        {
            if (indx > 2)
            {
                //Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}

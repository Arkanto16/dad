using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("snakeMain"))
        {
            other.GetComponent<snakeMoving>().AddTail();
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Borders : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("snakeMain"))
        {
            other.gameObject.transform.eulerAngles += new Vector3(0.0f, 110.0f, 0.0f);

            HeartSystem.health -= 1;

            if(HeartSystem.health <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
        
    }
}

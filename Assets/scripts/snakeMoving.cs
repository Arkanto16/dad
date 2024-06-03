using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snakeMoving : MonoBehaviour
{
    public float Speed;
    public int score=0;
    [SerializeField] Text scoreText;

    public float RotationSpeed;

    public List<GameObject> taillobjects = new List<GameObject> ();

    public float z_offset = -0.5f;

    public GameObject TailPrefab;
    void Start()
    {
        taillobjects.Add (gameObject);

    }
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up*-1 * RotationSpeed * Time.deltaTime);
    }

    public void AddTail()
    {
        score++;
        Vector3 newTailPos = taillobjects[taillobjects.Count-1].transform.position;
        newTailPos.z -= z_offset;
        taillobjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public or private reference
    //data type (int, float, bool, string)
    //every variable has a name
    //optional value assigned
    public float speed = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        //take the current position and assign a start position (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {               //new Vector3(1, 0, 0)
        transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}

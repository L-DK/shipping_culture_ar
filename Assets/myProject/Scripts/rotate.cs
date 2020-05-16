using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag=="obj")
        {
            if (variable.isRotate)
            {
                transform.Rotate(Vector3.down * Time.deltaTime * 100);
            }

        }
        if (gameObject.name=="one")
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 30);
        }
        if (gameObject.name == "two")
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 30);
        }

    }
}

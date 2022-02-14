using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    bool InputState = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            InputState = true;
        }else if (Input.GetKeyUp("space"))
        {
            InputState = false;
        }
        if (InputState)
        {
            this.gameObject.transform.Rotate(3.0f, 0.0f, 0.0f, Space.Self);
        }
    }
}

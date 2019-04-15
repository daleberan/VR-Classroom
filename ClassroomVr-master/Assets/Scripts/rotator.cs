using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
   
    void Update()
    {

        transform.Rotate(new Vector3(0f, 30, 0f) * Time.deltaTime);

    }
}

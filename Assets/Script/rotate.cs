using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(5f, 5f, 5f) * Time.deltaTime);
    }
}

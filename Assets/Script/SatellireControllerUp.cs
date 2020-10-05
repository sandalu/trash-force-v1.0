using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatellireControllerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 1f), 90f * Time.deltaTime);
        this.transform.RotateAround(this.transform.parent.position, this.transform.parent.up, 5f * Time.deltaTime);
    }
}

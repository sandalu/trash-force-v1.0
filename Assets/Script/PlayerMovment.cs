using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public KeyCode MoveUp;
    public KeyCode MoveDown;
    public CharacterController controller;
    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y= Input.GetAxis("Vertical");
        

        Vector3 move = transform.right * x + transform.forward * y ;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(MoveUp))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(MoveDown))
            transform.Translate(-Vector3.up * speed * Time.deltaTime);

        this.transform.RotateAround(this.transform.parent.position, this.transform.parent.up, 0.0005f * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        // get input
        Vector3 movement = GetInput();

        // move object
        MoveObject(GetInput());

        
    }

    private Vector2 GetInput()
    {
        // get input
        if (Input.GetKey(upKey))
        {
            // ke atas
            return Vector2.up * speed;
            ;
        }
        else if (Input.GetKey(downKey))
        {
            // ke bawah
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST: " + movement);
        Debug.Log("Speed: " + speed);
        rig.velocity = movement;
    }
}

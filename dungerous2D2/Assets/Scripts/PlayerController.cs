using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRig;
    [SerializeField] float speed;
    private int horizontal;
    private int vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { vertical += 1;}
        if (Input.GetKey(KeyCode.S)) { vertical -= 1; }
        if (Input.GetKey(KeyCode.D)) { horizontal += 1; }
        if (Input.GetKey(KeyCode.A)) { horizontal -= 1; }
        playerRig.velocity = new Vector2(horizontal * speed, vertical * speed);
        horizontal = 0;
        vertical = 0;
    }
}

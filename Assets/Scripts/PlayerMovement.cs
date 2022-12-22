using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public JoystickMovement movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    public Transform bulletSpawn;
    public Object bullet4x4;

    // Start is called before the first frame update   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);

            //transform.rotation = Quaternion.LookRotation(Vector3.forward, movementJoystick.joystickVec);
            fire();

        }
        else
        {
            rb.velocity = Vector2.zero;
        }

    }

    private void fire()
    {
        Instantiate(bullet4x4, bulletSpawn.transform.position, transform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Player Collider Trigerred");
        print("Game Over");
        Destroy(gameObject);
    }
}

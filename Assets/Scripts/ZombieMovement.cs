using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] private Transform lookTarget;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = (lookTarget.position - transform.position);

        float angle = Mathf.Atan2(diff.y, diff.x);

        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg + 180);

        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.Self);
    }
}

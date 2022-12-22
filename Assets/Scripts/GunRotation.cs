using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    [SerializeField] private Transform lookTarget;
    [SerializeField] private int rotationSpeed;

    void Update()
    {
        Vector3 diff = lookTarget.position - transform.position;

        float angle = Mathf.Atan2(diff.y, diff.x);

        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg + 90);
    }
}

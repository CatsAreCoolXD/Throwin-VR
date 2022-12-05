using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVelocityBoost : MonoBehaviour
{
    public Vector3 velocityBoost;
    private Rigidbody rb;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        rb = other.gameObject.GetComponent<Rigidbody>();
        other.gameObject.transform.position = transform.position;
        rb.velocity = velocityBoost;
    }
}

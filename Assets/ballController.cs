using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public float speed;

    void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direc = new Vector3(horizontal, 0, vertical);

        GetComponent<Rigidbody>().AddForce(direc * speed);
    }

    void OnTriggerEnter (Collider collider) {
	if (collider.tag == "pickUp") {
	    Destroy(collider.gameObject);
	}
    } 
}

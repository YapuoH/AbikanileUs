using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMov : MonoBehaviour {

    Vector3 mousePosition;
	
	void Update () {

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        transform.up = (mousePosition - transform.position);

	}
}

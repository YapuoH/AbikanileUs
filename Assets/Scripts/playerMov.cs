using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour {

    public float accelerator;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float posX = transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * accelerator;       
        transform.position = new Vector3(Mathf.Clamp(posX, -7.5f, 7.5f), -4, 0);
        
    }
}

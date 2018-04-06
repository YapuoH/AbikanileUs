using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour {

    public RawImage img;
    public float speed;

	// Update is called once per frame
	void Update () {

        Rect r = img.uvRect;
        r.y += speed;
        img.uvRect = r;
    }
}

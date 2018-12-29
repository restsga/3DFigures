using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {

    public float speed_xz;
    public float speed_y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1) {
            Touch touch = Input.GetTouch(0);
            this.transform.Rotate(0,touch.deltaPosition.x * speed_xz,0,Space.World);
            //this.transform.Rotate(0, touch.deltaPosition.y * speed_y, 0, Space.World);
        }
    }
}

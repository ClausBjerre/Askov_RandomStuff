using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseAndLowerPort : MonoBehaviour {

    public Vector2 highAndLowLimit = new Vector2(3f, 0f);
    float currentMouseDelta;
    float lerpedValue;
    Vector3 portStartPos;

	// Use this for initialization
	void Start ()
    {
        portStartPos = transform.position;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentMouseDelta += Input.mouseScrollDelta.y * 0.1f;
        currentMouseDelta = Mathf.Clamp(currentMouseDelta, highAndLowLimit.y, highAndLowLimit.x);
        lerpedValue = Mathf.InverseLerp(highAndLowLimit.y, highAndLowLimit.x, currentMouseDelta);
        Vector3 portPos = new Vector3(0f, currentMouseDelta, 0f) + portStartPos;
        transform.position = portPos;
        
	}
}

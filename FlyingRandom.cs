using UnityEngine;
using System.Collections;

public class FlyingRandom : MonoBehaviour {

     float horizontalSpeed;
     float verticalSpeed;
     float amplitude;

    private Vector3 tempPosition;

	// Use this for initialization
	void Start () {
        tempPosition = transform.position;
        InitalSpeed();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        tempPosition.x += horizontalSpeed;
        tempPosition.y += Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        transform.position = tempPosition;
	}

    void InitalSpeed()
    {
        horizontalSpeed = Random.Range(-5, 5)/100;
        verticalSpeed = Random.Range(-5, 5)/100;
        amplitude = Random.Range(-5, 5)/100;

    }
}

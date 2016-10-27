using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

    private float mSpeed = 5;
    private Rigidbody mRigibid;

	// Use this for initialization
	void Start () {
        mRigibid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float ver = Input.GetAxis("Vertical");
        mRigibid.velocity = transform.forward * ver * mSpeed;
    }
}

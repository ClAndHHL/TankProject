using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

    private float mSpeed = 5;
    private Rigidbody mRigibid;
    private float mRotateSpeed = 6;
    private KeyCode mFireKey = KeyCode.Return;

    public GameObject mFireBullet;
    private Transform mFireBulletTransform;

    public int mCardIndex = 1;

	// Use this for initialization
	void Start () {
        mRigibid = GetComponent<Rigidbody>();
        mFireBulletTransform = transform.FindChild("FirePos");
        if (mCardIndex != 1) {
            mFireKey = KeyCode.KeypadEnter ;
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float ver;
        float hor;
        if (mCardIndex == 1) {
            ver = Input.GetAxis("Vertical1");
            hor = Input.GetAxis("Horizontal1");
        } else {
            ver = Input.GetAxis("Vertical2");
            hor = Input.GetAxis("Horizontal2");
        }
        //Controller the tank
        mRigibid.velocity = transform.forward * ver * mSpeed;
        float dir = ver < 0 ? -1 : 1;
        
        mRigibid.angularVelocity = Vector3.up * hor* mRotateSpeed * dir;

        //Fire
        if (Input.GetKeyDown(mFireKey)) {
            GameObject go = GameObject.Instantiate(mFireBullet, mFireBulletTransform.position,mFireBulletTransform.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * 20;
        }



    }
}

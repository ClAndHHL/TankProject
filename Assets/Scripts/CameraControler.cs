using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

    public Transform player1;
    public Transform player2;
    private Camera mCamera;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - (player1.position + player2.position) / 2;
        mCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = (player1.position + player2.position) / 2 + offset;
        float distance = Vector3.Distance(player1.position,player2.position);
        float size = distance ;
        mCamera.orthographicSize = size;
	}
}

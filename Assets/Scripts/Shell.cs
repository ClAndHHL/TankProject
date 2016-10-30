using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {

    public GameObject shellExplosion;

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider other) {
        GameObject go = GameObject.Instantiate(shellExplosion, transform.position, Quaternion.identity) as GameObject;
        if (other.tag == "Tank") {
            other.SendMessage("TakeDamage");
        }

        Destroy(this.gameObject);
    }
}

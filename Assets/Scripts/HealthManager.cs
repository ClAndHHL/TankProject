using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

    public int mHP = 100;
    public GameObject tankExplosion;

    void TakeDamage() {
        mHP -= Random.Range(10,20);
        if (mHP < 1) {
            mHP = 0 ;
            GameObject.Instantiate(tankExplosion,this.transform.position,Quaternion.identity) ;
            Destroy(this.gameObject);
        }
    }

}

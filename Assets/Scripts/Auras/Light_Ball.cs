using UnityEngine;
using System.Collections;

public class Light_Ball : MonoBehaviour {

    public Transform ShotSpawnHere;
    public GameObject shot;
    public float fireRate;
    private float nextFire;
    public int LightAuraDamage;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, ShotSpawnHere.position, ShotSpawnHere.rotation);
        }


    }

    //void OnCollisonEnter(Collision col)
    //{
    //    EnemyHealth.Icehealth = Icehealth - LightAuraDamage;




    //}

    


}

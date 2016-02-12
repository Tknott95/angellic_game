using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{

    public float LightAuraDamage;
    public static float Icehealth = 100;
    public  float MaxIcehealth;

    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    void Update()
    {

        if (Icehealth <= 0)
        {
            DeathToPlayer();


        }
    }

    void DeathToPlayer()
    {
        Destroy(this.gameObject);
        //make death noise

    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "LightBall")
        {
            Icehealth = Icehealth - LightAuraDamage;
        }


    }
}



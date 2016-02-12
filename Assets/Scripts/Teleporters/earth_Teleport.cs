using UnityEngine;
using System.Collections;

public class earth_Teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "T1")
        {
            Debug.Log("Earth Teleport Test");
           Application.LoadLevel(1);

        }

    }

}

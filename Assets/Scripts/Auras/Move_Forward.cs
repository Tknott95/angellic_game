using UnityEngine;
using System.Collections;

public class Move_Forward : MonoBehaviour {

    public float speed;
    private Transform MyPosition;
         

    void Start()
    {
       


        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    //void moveTowardsPlayer()
    //{

    //    Debug.DrawLine(transform.position, transform.forward, Color.red);
    //    // rotate zomb

    //    myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotateSpeed * Time.deltaTime);
    //    // move 

    //    myTransform.position += myTransform.forward * movementSpeed * Time.deltaTime;








    //}
}

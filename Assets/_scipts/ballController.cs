using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {


   
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "kup")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag=="alt")
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    
    void OnCollisionExit2D(Collision2D coll)
    {
        gameObject.SetActive(false);
    }

    
    
}

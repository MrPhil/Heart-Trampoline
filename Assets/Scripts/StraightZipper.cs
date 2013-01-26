using UnityEngine;
using System.Collections;

public class StraightZipper : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {		
		 rigidbody.AddForce (Vector3.left * 20);
	}
}

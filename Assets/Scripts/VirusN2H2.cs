using UnityEngine;
using System.Collections;

public class VirusN2H2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {		
		 StartCoroutine(Jig());
	}
	
	IEnumerator Jig()
	{
		Debug.Log ( "Jig!");
		
		while(true)
		{
			yield return new WaitForSeconds(0.5f);
		
			UnityEngine.Vector3 direction = Vector3.up;;
			int randomDirection = Random.Range (0, 4);
			
			switch( randomDirection )
			{
			case 1 :
				direction = Vector3.down;
				break;
			case 2 :
				direction = Vector3.left;
				break;
			case 3 :
				direction = Vector3.right;
				break;
			default:
				direction = Vector3.up;
				break;				
			}		
			
			
			rigidbody.AddForce (direction * 10);		
		}
	}
}

using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public Transform projectile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire2")) 
		{
			Debug.Log("coucou");
			Transform proj = GameObject.Instantiate(projectile,transform.position+(transform.forward*2.0f), Quaternion.identity) as Transform;		

			proj.GetComponent<Rigidbody>().AddForce(transform.forward*10f, ForceMode.Impulse);
		}

	}


}

using UnityEngine;
using System.Collections;

public class triggeroeuf : MonoBehaviour {

	public GameObject oeuf;  
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		Destroy (oeuf);
		
	}
}

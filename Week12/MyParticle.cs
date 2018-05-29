using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyParticle : MonoBehaviour {

	// Use this for initialization
	ParticleSystem exhaust;
	void Start () {
		exhaust = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}



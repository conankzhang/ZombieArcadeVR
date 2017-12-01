using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePitch : MonoBehaviour {
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = Random.Range(0.7f, 0.8f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

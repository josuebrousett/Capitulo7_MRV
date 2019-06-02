using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {
	public AudioSource audio;
	public AudioClip hitSound;

	void Start () {
		audio = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other) {
		audio.Play ();
	}
}

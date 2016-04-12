using UnityEngine;
using System.Collections;

public class AudioSettings : MonoBehaviour 
{
	[SerializeField] private AudioSource vowelAudio;

	// Use this for initialization
	public void Start () 
	{
		vowelAudio = GetComponent<AudioSource>();

		vowelAudio.Play();
		vowelAudio.Play(80000);
	}
}

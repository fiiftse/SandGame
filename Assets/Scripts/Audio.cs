using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour 
{
	[SerializeField] private AudioClip startAudio = Resources.Load("Sounds/Phrases/Find the letters...") as AudioClip;

	public void Start()
	{
	
	}
}

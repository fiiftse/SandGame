using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VowelSettings : MonoBehaviour 
{
	[SerializeField] private AudioSource correctAudio; //Stores the congratulatory audio clip
	[SerializeField] private GameObject letter; //Stores the correct vowel letter
	private bool clicked;

	//Returns to menu screen
	public void loadInstructions1() 
	{
		Application.LoadLevel("VowelGame1");
	}

	public void loadGame()
	{
		Application.LoadLevel("VowelGame");
	}

	public void setClicked(bool input)
	{
		clicked = input;
	}

	public bool getClicked()
	{
		return clicked;
	}

	//Method to detect when user clicks on the right vowel
	public void OnMouseDown()
	{
		SpriteRenderer spriteRen = GetComponent<SpriteRenderer>();
		spriteRen.color = new Color(0.5f, 0.5f, 0.5f, 1f); //Sets the clicked (only if it is correct) vowel to opaque grey
		setClicked(true); 

		if (getClicked() == true) //Checks to see if user has chosen the right vowel
		{
			//Plays congratulatory phrase
			correctAudio = GetComponent<AudioSource>();
			correctAudio.Play(20000);
			correctAudio.Play();
		}
	}
}

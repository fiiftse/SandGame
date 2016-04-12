using UnityEngine;
using System.Collections;

public class SandInstructions : MonoBehaviour 
{
	[SerializeField] private AudioSource correctAudio; //Stores the congratulatory audio clip
	[SerializeField] private GameObject beachItem;
	private bool clicked;

	public void loadGame()
	{
		if (getClicked() == true)
		{
			Application.LoadLevel("Menu");
		}
	}

	public void setClicked(bool input)
	{
		clicked = input;
	}

	public bool getClicked()
	{
		return clicked;
	}

	//Changes the sprite colour to indicate it has been clicked
	public void OnMouseDown()
	{
		SpriteRenderer spriteRen = GetComponent<SpriteRenderer>();
		spriteRen.color = new Color(0.5f, 0.5f, 0.5f, 1f); // Set to opaque gray
		clicked = true;

		if (getClicked() == true) //Checks to see if user has chosen the right beach item
		{
			//Plays congratulatory phrase
			correctAudio = GetComponent<AudioSource>();
			correctAudio.Play(20000);
			correctAudio.Play();
		}
	}
}

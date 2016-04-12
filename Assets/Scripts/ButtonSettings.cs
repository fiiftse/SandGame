using UnityEngine;
using System.Collections;

public class ButtonSettings : MonoBehaviour 
{
	[SerializeField] private Setup setup;

	//Loads pick screen
	public void loadPickScreen()
	{
		Application.LoadLevel("PickScreen");
	}

	//Loads main game scene
	public void loadMain()
	{
//		if (setup.getIsEmpty() == false)
//		{
			Application.LoadLevel("Main");
//		}
	}

	//Returns to menu screen
	public void loadMenu() 
	{
		Application.LoadLevel("Menu");
	}

	//Remove all chosen letters
	public void removeAll()
	{
		setup.setIsEmpty(true);
		/*removed = true;
		letterSettings.removeAllLetters();*/
	}

	//Changes the sprite colour to indicate it has been clicked
	public void OnMouseDown()
	{
		SpriteRenderer spriteRen = GetComponent<SpriteRenderer>();
		spriteRen.color = new Color(0.5f, 0.5f, 0.5f, 1f); // Set to opaque gray
	}
}
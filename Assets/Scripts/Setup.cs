using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Setup : MonoBehaviour 
{
//	public GameObject[] lettersArray;

	static bool isEmpty = false; //Checks if the list storing user choices is empty or not
	static bool chosen = false; //Checks to see if card is chosen or not

	private int count;

	List<int> userChoices = new List<int>(); //Stores the chosen letter ids


	//Return size of userChoices list
	public int getSize()
	{
		return userChoices.Count;
	}

	//Method to return whether list is empty
	public bool getIsEmpty()
	{
		return isEmpty;
	}

	//Method to set list boolean 
	public void setIsEmpty(bool input)
	{
		isEmpty = input;
	}

	//Method to return whether card was chosen or not
	public bool getChosen()
	{
		return chosen;
	}

	//Method to set chosen boolean
	public void setChosen(bool input)
	{
		chosen = input;
	}
}
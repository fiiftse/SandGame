//Game concept:
//1. Player chooses the letter(s) they want to practice with.
//2. Player has to pick the items with the corresponding first letter on the sand to match with the chosen letters (shown on the top left)
//3. Once all the corresponding items are chosen, repeat for the next chosen letter (if any)

//Note: this script is only used if the PickScreen is used.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour 
{
	Setup setup;
	//[SerializeField] private List<Sprite> chosenLetters = new List<Sprite>(); //Stores the chosen letters in a list
//	private List<Sprite> chosenBeachItems = new List<Sprite>(); //Stores the chosen picture in a list
	//[SerializeField] private GameObject[] letters; //Array to store all 


	[SerializeField] private GameObject[] Letters = Resources.LoadAll<GameObject>("Sprites/Letters"); //List to store all letters
	[SerializeField] private GameObject[] beachItems = Resources.LoadAll<GameObject>("Sprites/BeachItems"); //List to store all beach items
	//[SerializeField] private List<GameObject> chosenLetters = new List<GameObject>(); //List to store the chosen letter(s)
	[SerializeField] private GameObject[] chosenLetters = new GameObject[26];
//	[SerializeField] private List<GameObject> chosenBeachItem; //List to store chosen beach item(s)

	int index = 0;
	private int[] indexes; //Array to store the indexes of chosen letters

	public void Start()
	{
		//setup = GameObject.Find("a").GetComponent<Setup>();
//		addLetter();
	}


	public void OnMouseDown()
	{
//		for (int i = 0; i < setup.lettersArray.Length; i++)
//		{
//			if (setup.lettersArray[i].transform == transform)
//			{
//				Debug.Log("You just clicked the object with the Index of " + i.ToString());
//			}
//		}
//		chosenLetters.Insert(index, this.gameObject);
		addLetter();
	}

	public void addLetter()
	{
		//GameObject pointer = GameObject.FindGameObjectWithTag("Letters");
		for (int i = 0; i < 26; i++)
		{
			chosenLetters[i] = gameObject;
		}
//		chosenLetters.Add(gameObject);
	}

//	//Method to set the index
//	public void setIndex(GameObject input)
//	{
//		for (int i = 0; i < Letters.Count; i++)
//		{
//			indexes[]
//		}
//		indexes[i] = chosenLetters.IndexOf(input);
//	}
//
//	public int getIndex()
//	{
//		return id;
//	}

//	//Method to add chosen letters into a list
//	public void addLetters(GameObject input)
//	{
//		
//		chosenLetters.Add(input);
//	}

//	//Method to add all beach items into a list
//	public void addBeachItems()
//	{
//		for (int i = 0; i < beachItems.Length; i++)
//		{
//			chosenBeachItems.Add(beachItems[id]);
//		}
//	}
}
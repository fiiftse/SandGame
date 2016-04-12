using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour 
{
	public Transform[] spawnPoints; //Array to store all the beach item spawn points
	public Transform[] letterPoints; //Array to store the 4 letter positions
	public GameObject[] beachItems; //Array to store the beach items that correspond to the chosen letters
	public GameObject[] letters; //Array to store the chosen letters
	
	public float spawnTime = 80f;

	public void Start()
	{
		spawnBeachItems();
		spawnLetters();
	}

	//Method to spawn the corresponding beach items
	public void spawnBeachItems()
	{
		List<Transform> freeSpawnPoints = new List<Transform>(spawnPoints);

		foreach (GameObject beachItem in beachItems)
		{
			if (freeSpawnPoints.Count <= 0)
				return; //Not enough spawn points
			
			int index = Random.Range(0, freeSpawnPoints.Count);
			Transform position = freeSpawnPoints[index];
			freeSpawnPoints.RemoveAt(index); //Ensures no two gameobjects will be instantiated at the same spawn point

			Instantiate(beachItem, position.position, position.rotation);
		}
	}

	//Method to spawn the chosen letters from previous scene
	public void spawnLetters()
	{
		int index = 0;
		foreach (GameObject letter in letters)
		{
			int spawnIndex = Random.Range(0, letterPoints.Length);

			Instantiate(letter, letterPoints[index].position, letterPoints[spawnIndex].rotation);
			index++;
		}	
		index++;
	}
}

using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour 
{
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == this.gameObject.tag) //Checks to see if beach item tag matches letter tag
		{
			Destroy(collision.gameObject); //Destroys beach item on collision
		}

		//TODO: Add revert back to original position if beach itme does not match
	}
}

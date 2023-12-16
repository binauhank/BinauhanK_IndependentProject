using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishZoneScript : MonoBehaviour
{
	public bool isSolved = false;
	void OnTriggerEnter (Collider collider)
	{
		GameObject collidedWith = collider.gameObject;
		if (collidedWith.tag == "Ball")
		{
			isSolved = true;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectGem : MonoBehaviour {

	private float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCursor;
	public GameObject TheGem;
	public AudioSource CollectSound;

	// Update is called once per frame
	void Update () 
	{
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 3) 
		{
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
			ExtraCursor.SetActive(true);
		} 
		else if (ActionDisplay.activeSelf) 
		{
			turnOffExtraCursor();
		}

		if (Input.GetButtonDown("Action") && TheDistance <= 3) 
		{
			CollectSound.Play();
			TheGem.SetActive(false);
			turnOffExtraCursor();
		}
	}

	void OnMouseExit()
	{
		turnOffExtraCursor();
	}

	private void turnOffExtraCursor()
	{
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
		ExtraCursor.SetActive(false);
	}
}

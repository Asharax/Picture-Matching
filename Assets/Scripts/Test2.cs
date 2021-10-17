using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour
{
	public Sprite[] images;
	private SpriteRenderer spriteR;

	void Start()
	{
		spriteR = gameObject.GetComponent<SpriteRenderer>();
		spriteR.sprite = images[TestControl.i+1];

	}

	void Update()
	{
			spriteR.sprite = images [TestControl.i + 1];

	}

	void OnMouseDown(){

		TestControl.selected=gameObject.name;
		TestControl.selected="2";
		spriteR.sprite = images[TestControl.i+1];

	}
}

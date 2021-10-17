using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceController : MonoBehaviour
{
	private AudioSource audioSource;
	public AudioClip[] animal;
	private AudioClip animalClip;

    // Start is called before the first frame update
    void Start()
	{
		audioSource = gameObject.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
		if (TestControl.selected!="-1")
		{
			Debug.Log ("Selected -1");
			animalClip = animal[(TestControl.i)+2];
			audioSource.clip = animalClip;
			audioSource.Play();
		}
    }
}

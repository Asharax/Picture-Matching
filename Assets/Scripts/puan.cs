using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puan : MonoBehaviour
{
    void Update()
    {
		GetComponent<TextMesh> ().text = "Puan= "+TestControl.score;
    }
}

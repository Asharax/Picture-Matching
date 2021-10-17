using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestControl : MonoBehaviour
{	

	public static int score = 0;

	List<string> questions = new List<string>() { 
		"Hangisi Aslan?",
		"Hangisi Ayı?",
		"Hangisi At?",
		"Hangisi Balık?",
		"Hangisi Deve?",
		"Hangisi Eşek?",
		"Hangisi Fare?",
		"Hangisi Fil?",
		"Hangisi İnek?",
		"Hangisi Kaplan?",
		"Hangisi Kaplumbağa?",
		"Hangisi Keçi?",
		"Hangisi Kedi?",
		"Hangisi Kelebek?",
		"Hangisi Koyun?",
		"Hangisi Köpek?",
		"Hangisi Kurbağa?",
		"Hangisi Kuş?",
		"Hangisi Maymun?",
		"Hangisi Ördek?",
		"Hangisi Panda?",
		"Hangisi Penguen?",
		"Hangisi Sincap?",
		"Hangisi Tavşan?",
		"Hangisi Tavuk?",
		"Hangisi Timsah?",
		"Hangisi Yarasa?",
		"Hangisi Yılan?",
		"Hangisi Yunus Balığı?",
		"Hangisi Zürafa?"
	};

	List<string> correct = new List<string>() { "1","1","3","2","3","1","2","3","1","1","2","3","2","1","2","2","3","3","1","2","3","2","1","3","2","2","1","3","1","3"};
	public static string selected="-1";
	public static int i=-1;

    void Start()
	{
			int Highest = PlayerPrefs.GetInt ("hiScore", PlayerProgress.hiScore);
			GetComponent<TextMesh> ().text = questions [i + 1];
			Debug.Log ("En Yüksek Skor: " + Highest);
    }


    void Update()
    {
		if (i < questions.Count-1) {
			if (Input.GetKeyDown (KeyCode.Mouse0) & selected == correct [i + 1]) {
				Debug.Log ("Doğru cevap! i:" + i);
				i++;score++;
				GetComponent<TextMesh> ().text = questions [i + 1];
				selected = "-1";
			} else if (Input.GetKeyDown (KeyCode.Mouse0) & selected != correct [i + 1]) {
				Debug.Log ("Yanlış cevap! i:" + i);
				i++;
				GetComponent<TextMesh> ().text = questions [i + 1];
				selected = "-1";

			}
			if (i >= 29) {
				Debug.Log ("Oyun Biter bay bay");
			}
		} 

		else {
//			GameObject.SetActive QuestionText(false);


				if (score >  PlayerPrefs.GetInt("hiScore",score)) {
					PlayerProgress.hiScore = score;
					SavePlayerProgress ();
				}
			}


       
    }
	private void SavePlayerProgress()
	{
		// Save the value playerProgress.highestScore to PlayerPrefs, with a key of "highestScore"
		PlayerPrefs.SetInt("hiScore", PlayerProgress.hiScore);
	}
	public int GetHighestScore(){
		return PlayerProgress.hiScore;
	}
}

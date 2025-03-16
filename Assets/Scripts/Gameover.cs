using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {

	float timer = 0;
	
	void Update()
	{
		timer += Time.deltaTime;
		if (timer > 2)
		{
			DeteksiSampah.score = 0;
			SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
            //testDrives
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameController : MonoBehaviour
{
	public static GameController instance;

	public Transform[] spawnPoints;
	public Text textScore;
	public int score;

	public float timeElapsed;


	// Start is called before the first frame update
	void Start()
	{
		score = 0;

	}


	public void EarnPoints(int pointAmount)
	{
		score += Mathf.RoundToInt(pointAmount);
	}

	void UpdateDisplay()
	{
		textScore.text = score.ToString();
	}




	void Awake()
	{
		instance = this;
	}

	// Update is called once per frame
	void Update()
	{
		//control speed of hooks
		timeElapsed += Time.deltaTime/5f;
		UpdateDisplay();
	}



	/*void SpawnAsteroid()
	{
	Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
	GameObject randomAsteroidPrefab = asteroidPrefabs[Random.Range(0, asteroidPrefabs.Length)];

	Instantiate(randomAsteroidPrefab, randomSpawnPoint.position, Quaternion.identity);
}

IEnumerator AsteroidSpawnTimer()
{
yield return new WaitForSeconds(asteroidDelay);

SpawnAsteroid();

StartCoroutine("AsteroidSpawnTimer");
}*/
}

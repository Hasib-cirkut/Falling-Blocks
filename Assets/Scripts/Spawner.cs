using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public Transform Block;
	private float randomNum;
	public float timeBetweenWaves = 2f;
	public float waveTime = 2f;

	// Use this for initialization
	void Start () {



		//SpawnBlocks();

	}
	
	// Update is called once per frame
	void Update () {

		if(Time.timeSinceLevelLoad >= waveTime)
		{
			SpawnBlocks();

			waveTime += timeBetweenWaves;
		}
		
	}

	void SpawnBlocks()
	{
		randomNum = Random.Range(0, spawnPoints.Length);

		for(int i=0; i<spawnPoints.Length; i++)
		{
			if(randomNum == i)
			{
				continue;
			}
			else{
				Instantiate(Block, spawnPoints[i].position, Quaternion.identity);
				Block.GetComponent<Rigidbody2D>().gravityScale += .005f;
			}
			}
	}
}

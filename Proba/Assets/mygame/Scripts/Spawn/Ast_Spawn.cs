using UnityEngine;
using System.Collections;

public class Ast_Spawn : MonoBehaviour {


	
	public Transform[] spawnPoints;  // точки спауну
	public GameObject[] enemyPrefabs; // масив обєктів які спамитумуться
	public int amountEnemies = 20;  // загальна кіклькість астероїдів які заспамляться		

	public int yieldTimeMin = 2;  // мінімальний час появлення астероїдів(спавну)
	public int yieldTimeMax = 5;  // максимальний час появлення астероїдів(спавну)
	private int i;
	
	void Start()
	{
		Spawn();
	}
	
	void Spawn() 
	{ 
		for (i=0; i<amountEnemies; i++)
		{
			 new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));  


			GameObject obj  = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]; 
			Transform pos = spawnPoints[Random.Range(0, spawnPoints.Length)];  
			
			Instantiate(obj, pos.position, pos.rotation); 
			
		}
	}  
	}


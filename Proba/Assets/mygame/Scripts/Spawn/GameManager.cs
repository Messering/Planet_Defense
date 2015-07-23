using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	//public GameObject spawnedObject;
	public Transform[] spawnPoints; // точки спауну
	public GameObject[] enemyPrefabs; // масив обєктів які спамитумуться
	private GameObject[] spawn_obj; //масив де зберігаються всі заспамлені обєкти
	public int amountEnemies=10; // загальна кіклькість астероїдів які заспамляться 
	private int a = 0;
	
	public int yieldTimeMin; // мінімальний час появлення астероїдів(спавну)
	public int yieldTimeMax; // максимальний час появлення астероїдів(спавну)
	private int i;

	void Update() 
	{
		a++;
		if(a==240){
			StartCoroutine(spawn());
			//destr();
			a=0;
		}
	}
	
	IEnumerator spawn()
	{
		for (int i = 0; i < amountEnemies; i++)
		{
			GameObject obj = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]; 
			Transform pos = spawnPoints[Random.Range(0, spawnPoints.Length)]; 
			Instantiate(obj, pos.position, pos.rotation); 
			//Instantiate(enemyPrefabs);
			//spawn_obj[spawn_obj.Length]=obj;
			yield return new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));
		}
	}
	/*
	void destr()
				{
		for (int j=0; j<spawn_obj.Length; j++) {
			if (spawn_obj[j].transform.position.x==0 && spawn_obj[j].transform.position.y==0 ){
				Destroy(spawn_obj[j]);
			}
		
		}

		}*/
	}
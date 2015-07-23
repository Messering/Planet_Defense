﻿using UnityEngine;
using System.Collections;
using System.Threading;

public class Ast_Spawn : MonoBehaviour {
	
	
	public Transform[] spawnPoints; // точки спауну
	public GameObject[] enemyPrefabs; // масив обєктів які спамитумуться
	public int amountEnemies=10; // загальна кіклькість астероїдів які заспамляться 
	
	public int yieldTimeMin; // мінімальний час появлення астероїдів(спавну)
	public int yieldTimeMax; // максимальний час появлення астероїдів(спавну)
	private int i;


	IEnumerator Start(){
		while (true) {
			yield return StartCoroutine (Spawn());

		}
	
	}

	
	IEnumerator Spawn() 
	{ 
		for (i=0; i<amountEnemies; i++)
		{
			yield return new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax)); 
			
			GameObject obj = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]; 
			Transform pos = spawnPoints[Random.Range(0, spawnPoints.Length)]; 
			print (enemyPrefabs.Length);
			Instantiate(obj, pos.position, pos.rotation); 
			
			}

	} 
}
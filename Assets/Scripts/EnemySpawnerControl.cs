using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerControl : MonoBehaviour
{
  public Transform[] spawnPoints;
  public GameObject[] enemies;
  int randomSpawnPoint, randomEnemy;
  public static bool spawnAllowed;

  // Start is called before the first frame update
  void Start()
  {
    spawnAllowed = true;
    InvokeRepeating("SpawnAnEnemy", 0f, 1f);
  }

  void SpawnAnEnemy()
  {
    if (spawnAllowed) {
      randomSpawnPoint = Random.Range (0, spawnPoints.Length);
      randomEnemy = Random.Range (0, enemies.Length);
      Instantiate (enemies[randomEnemy], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
    }
  }
}

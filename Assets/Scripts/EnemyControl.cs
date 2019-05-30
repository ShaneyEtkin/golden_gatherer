using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
  Rigidbody2D rb;
  GameObject target;
  float moveSpeed;
  Vector3 directionToTarget;
  string direction;

  // Start is called before the first frame update
  void Start()
  {
    target = GameObject.Find("Player");
    rb = GetComponent<Rigidbody2D> ();
    moveSpeed = Random.Range (1, 3);
  }

  // Update is called once per frame
  void Update()
  {
    MoveMonster ();
  }

  void OnTriggerEnter2D (Collider2D col) {
    if (col.gameObject.tag == "Player") {
      EnemySpawnerControl.spawnAllowed = false;
      Destroy(col.gameObject);
      target = null;
    }
  }

  void MoveMonster () {
    if (target != null) {
      directionToTarget = (target.transform.position - transform.position).normalized;
			rb.velocity = new Vector2 (directionToTarget.x * moveSpeed,
										              directionToTarget.y * moveSpeed);
    } else {
      rb.velocity = Vector3.zero;
      direction = "down";
    }
  }
}

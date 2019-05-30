using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaserThing : MonoBehaviour
{
  // Update is called once per frame
  void Update()
  {
    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 objPos = transform.position;
    if (Input.GetMouseButtonDown(0))
    {
      Vector2 heading = mousePos - objPos;
      float distance = heading.magnitude;
      RaycastHit2D hit = Physics2D.Linecast(objPos, mousePos, LayerMask.GetMask("Enemy"));
      if (hit) Destroy(hit.collider.gameObject);
      Debug.DrawLine(objPos, mousePos, Color.red, 1, false);
      print(hit.collider);
    }
  }
}

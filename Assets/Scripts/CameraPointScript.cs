using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPointScript : MonoBehaviour
{

  private Vector2 mousePos;
  // Start is called before the first frame update
  void Update()
  {
    mousePos = getPosition();
    transform.position = Vector3.MoveTowards(transform.position, mousePos, 4.0f * Time.deltaTime);
  }

  // Update is called once per frame
  Vector2 getPosition()
  {
    return Camera.main.ScreenToWorldPoint(Input.mousePosition);
  }
}
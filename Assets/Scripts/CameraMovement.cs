using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
  public Transform player;
  public Vector3 cameraOffset;
  public float cameraSpeed = 0.1f;

  void Start()
  {
    Vector3 camPosTemp = transform.position;
    transform.position = new Vector3(camPosTemp.x, transform.position.y + cameraOffset.y, camPosTemp.z);
  }

  void FixedUpdate ()
  {
    Vector3 camPosTemp = transform.position;
    Vector3 finalPosition;
    if ((player.position + cameraOffset).y < 0)
    {
      finalPosition = cameraOffset;
    }
    else
    {
      finalPosition = player.position + cameraOffset;
    }
    Vector3 lerpPosition = Vector3.Lerp (transform.position, finalPosition, cameraSpeed);
    transform.position = new Vector3(camPosTemp.x, lerpPosition.y, camPosTemp.z);
    //transform.position = lerpPosition;
  }
}
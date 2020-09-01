using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

  public float speedMax;
  public float speedCurrent;
  public float[] gearAcceleration;
  public float condition;

  public float distCur;
  public float distFinish;

  public void Update()
  {
    distCur = distCur <= distFinish ? distCur + Time.deltaTime : distCur;
  }


}

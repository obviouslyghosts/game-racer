using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RC { START, PLAYER, ENEMY, WON, LOST }

public class RaceSystem : MonoBehaviour
{
  public RC state;
  public Animator actionMenu;
  private float timer;
  public float alarmEnemy = 1f;
  public float alarmPlayer = 5f;


  private void Start()
  {
    state = RC.START;
  }

  private void Update()
  {
    switch ( state )
    {
      case RC.START:
      timer = alarmEnemy;
      state = RC.ENEMY;
      break;
      case RC.PLAYER:
      TimerPlayer();
      break;
      case RC.ENEMY:
      TimerEnemy();
      break;
      case RC.WON:
      break;
      case RC.LOST:
      break;
      default:
      break;

    }
  }

  private void TimerEnemy()
  {
    timer -= Time.deltaTime;
    if ( timer <= 0 )
    {
      timer = alarmPlayer;
      state = RC.PLAYER;
      actionMenu.SetBool( "Open", true );
    }
  }

  private void TimerPlayer()
  {
    timer -= Time.deltaTime;
    if ( timer <= 0 )
    {
      timer = alarmEnemy;
      state = RC.ENEMY;
      actionMenu.SetBool( "Open", false );
    }
  }

}

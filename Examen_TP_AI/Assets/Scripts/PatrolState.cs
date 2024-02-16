using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PatrolState : EnemyState
{
    
    private float patrolSpeed = 3f;
    private int currentPatrolIndex = 0;
    private Vector3 nextPatrolPoint;


    public override bool CanEnter(IState currentState)
    {
        return true;

    }

    public override bool CanExit()
    {
        return true;
    }

    public override void OnEnter()
    {
        SetNextPatrolPoint();
    }

    public override void OnExit()
    {
     
    }

    public override void OnStart()
    {
      
    }

    public override void OnUpdate()
    {
       
    }

    void SetNextPatrolPoint()
    {
       
    }
}

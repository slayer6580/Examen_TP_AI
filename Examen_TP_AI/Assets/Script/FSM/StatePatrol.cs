using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class StatePatrol : EnemyState
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
        return false;
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

		m_stateMachine.gameObject.transform.position = Vector3.MoveTowards(m_stateMachine.gameObject.transform.position, nextPatrolPoint, patrolSpeed * Time.deltaTime);

		if (m_stateMachine.gameObject.transform.position == nextPatrolPoint)
		{	
		    SetNextPatrolPoint();		
		}

	}

    void SetNextPatrolPoint()
    {
        currentPatrolIndex = (currentPatrolIndex + 1) % m_stateMachine.patrolPoints.Length;
        nextPatrolPoint = m_stateMachine.patrolPoints[currentPatrolIndex].position;
    }
}

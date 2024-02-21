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
		return !m_stateMachine.m_isTakingABreak;
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

		m_stateMachine.gameObject.transform.position = Vector3.MoveTowards(m_stateMachine.gameObject.transform.position, nextPatrolPoint, patrolSpeed * Time.deltaTime);

		if (m_stateMachine.gameObject.transform.position == nextPatrolPoint)
		{
			int rngState = Random.Range(0, 4);

			if (rngState == 0)
			{

				m_stateMachine.m_isTakingABreak = true;
			}
			else
			{
				SetNextPatrolPoint();
			}

		}

	}

    void SetNextPatrolPoint()
    {
        currentPatrolIndex = (currentPatrolIndex + 1) % m_stateMachine.patrolPoints.Length;
        nextPatrolPoint = m_stateMachine.patrolPoints[currentPatrolIndex].position;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditorInternal;
using UnityEngine;

public class StatePatrol : EnemyState
{  
    private float patrolSpeed = 3f;
    private int currentPatrolIndex = 0;
    private Vector3 nextPatrolPoint;
    private float m_reachDistance = 1;

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
        m_stateMachine.GetAgent().isStopped = false;
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
		if (Vector3.Distance(m_stateMachine.gameObject.transform.position, m_stateMachine.patrolPoints[currentPatrolIndex].position) < m_reachDistance)
		{
			
			int rngState = Random.Range(0, 3);

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
        currentPatrolIndex++;
		if(currentPatrolIndex == m_stateMachine.patrolPoints.Length)
        {
            currentPatrolIndex = 0;
		}
		
		m_stateMachine.GetAgent().SetDestination(m_stateMachine.patrolPoints[currentPatrolIndex].position);
    }
}

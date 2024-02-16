using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePursuit : EnemyState
{
	public override void OnEnter()
	{
		m_stateMachine.GetAgent().isStopped = false;
		Debug.Log("Enter state: Pursuit\n");
	}

	public override void OnUpdate()
	{
		m_stateMachine.GetAgent().SetDestination(m_stateMachine.GetPlayerTransform().position);
	}

	public override void OnFixedUpdate()
	{

	}

	public override void OnExit()
	{
		m_stateMachine.GetAgent().isStopped = true;
	}

	public override bool CanEnter(IState currentState)
	{

		return m_stateMachine.PlayerIsInSight();


	}

	public override bool CanExit()
	{

		return !m_stateMachine.PlayerIsInSight();
	}
}

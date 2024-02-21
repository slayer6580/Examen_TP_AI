using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : EnemyState
{
    private float m_breakTime = 2;
    private float m_breakTimer = 0;
    //m_stateMachine

    public override void OnEnter()
    {
		m_stateMachine.m_isTakingABreak = false;
		m_breakTimer = m_breakTime;
	}
    public override bool CanEnter(IState currentState)
    {
		return m_stateMachine.m_isTakingABreak;
	}

    public override void OnUpdate()
    {
		m_breakTimer -= Time.deltaTime;
		Debug.Log("Is taking a break");
	}

    public override bool CanExit()
    {
		return m_breakTimer <= 0;
	}
}

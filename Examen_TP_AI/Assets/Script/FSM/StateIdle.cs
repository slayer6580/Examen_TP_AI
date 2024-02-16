using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : EnemyState
{
    private float m_breakTime = 3;
    private float m_breakTimer = 0;
    //m_stateMachine

    public override void OnEnter()
    {
        
    }
    public override bool CanEnter(IState currentState)
    {
        return true;
    }

    public override void OnUpdate()
    {
      
    }

    public override bool CanExit()
    {
        return true;
    }
}

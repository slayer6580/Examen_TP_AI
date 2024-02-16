using UnityEngine;


public class IdleState : EnemyState
{
    public override void OnEnter()
    {

        Debug.Log("Enter state: FreeState\n");
    }

    public override void OnUpdate()
    {

    }

    public override void OnFixedUpdate()
    {

    }

    public override void OnExit()
    {

    }

    public override bool CanEnter(IState currentState)
    {
	
        return true;

    }

    public override bool CanExit()
    {
        return true;
    }

}

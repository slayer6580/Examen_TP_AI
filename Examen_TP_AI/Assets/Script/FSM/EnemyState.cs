public abstract class EnemyState : IState
{
    protected EnemyStateMachine m_stateMachine;

    public void OnStart(EnemyStateMachine stateMachine)
    {
        m_stateMachine = stateMachine;
    }

    public virtual void OnEnter()
    {
    }

    public virtual void OnExit()
    {

    }

    public virtual void OnFixedUpdate()
    {
    }

    public virtual void OnUpdate()
    {
    }

    public virtual bool CanEnter(IState currentState)
    {
        throw new System.NotImplementedException();
    }

    public virtual bool CanExit()
    {
        throw new System.NotImplementedException();
    }

    public virtual void OnStart()
    {
        throw new System.NotImplementedException();
    }

 
}

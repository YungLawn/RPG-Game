using UnityEngine;

public class RunState : MovementState
{
    public override void EnterState(StateManager incomingState)
    {
        // Debug.Log("Entering Run");
        moveSpeed = 1.0f;
        action = WALK;
        state = incomingState;
        body = state.body;
        anim = state.animator;
        lastMoveDirection = state.direction;

    }

    public override void UpdateState()
    {
        // Debug.Log("Running");
        move();
    }

    public override void FixedUpdateState()
    {
        Animate();
    }

    public override void OnCollisionEnter(StateManager state)
    {

    }
}
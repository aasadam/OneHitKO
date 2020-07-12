using Assets.Scripts.Datas;
using Assets.Scripts.Statics;
using System.Numerics;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class MoveSystem : SystemBase
{
    private float3 _inputMoveDirection;

    protected override void OnCreate()
    {
        base.OnCreate();
        InputStatic.Inputs.Player.Movement.performed += ctx => ChangeDirection(ctx.ReadValue<UnityEngine.Vector2>());
    }

    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        float3 inputMoveDirection = _inputMoveDirection;

        Entities.ForEach((ref MoveData movData, in MoveInputData inputData) =>
        {
            movData.Direction = inputMoveDirection;
        }).Schedule();

        Entities.ForEach((ref Translation pos, in MoveData movData) =>
        {
            //pos.Value += movData.Direction * movData.Speed * deltaTime;
            Move(ref pos, movData.Direction, movData.Speed, deltaTime);
        }).Schedule();
    }

    static void Move(ref Translation pos, in float3 direction, in float speed, in float deltaTime)
    {
        pos.Value += direction * speed * deltaTime;
    }

    public void ChangeDirection(UnityEngine.Vector2 direction)
    {
        _inputMoveDirection = new float3(direction.x, 0, direction.y);
    }

}

using Assets.Scripts.Datas;
using Assets.Scripts.Statics;
using Assets.Scripts.Systems;
using System.Numerics;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

[UpdateAfter(typeof(InputSystem))]
public class MoveSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;        

        Entities.ForEach((ref Translation pos, ref MoveDirectionData moveDirectionData, in MoveSpeedData movData) =>
        {
            Move(ref pos, moveDirectionData.Direction, movData.Speed, deltaTime);
        }).Schedule();
    }

    static void Move(ref Translation pos, in float3 direction, in float speed, in float deltaTime)
    {
        pos.Value += direction * speed * deltaTime;
    }
}

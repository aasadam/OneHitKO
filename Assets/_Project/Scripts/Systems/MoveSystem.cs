using Assets.Scripts.Datas;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

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

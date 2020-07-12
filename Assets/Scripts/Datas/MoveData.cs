using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public struct MoveData : IComponentData
{
    public MoveData(float speed, float3 direction = default)
    {
        Direction = direction;
        Speed = speed;
    }

    public float3 Direction;
    public float Speed;    
}

using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public struct MoveSpeedData : IComponentData
{
    public MoveSpeedData(float speed)
    {
        Speed = speed;
    }
    
    public float Speed;    
}

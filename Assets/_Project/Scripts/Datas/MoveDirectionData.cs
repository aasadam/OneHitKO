using Unity.Entities;
using Unity.Mathematics;

namespace Assets.Scripts.Datas
{
    public struct MoveDirectionData : IComponentData
    {
        public MoveDirectionData(float3 direction)
        {
            Direction = direction;
        }

        public float3 Direction;        
    }
}

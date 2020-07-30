using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Datas.Skills.Direction
{
    [GenerateAuthoringComponent]
    public struct BlinkData : IComponentData
    {
        public Entity ParentContainer;
        public float MaxDistance;
    }
}

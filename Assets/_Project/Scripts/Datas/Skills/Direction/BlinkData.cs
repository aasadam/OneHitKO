using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Datas.Skills.Direction
{
    [GenerateAuthoringComponent]
    public struct BlinkData : IDirectionSkillData
    {
        public Entity ParentContainer;
        public float3 WorldPoint { get; set; }
        public bool Execute { get; set; }
    }
}

using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Datas.Skills.Direction
{
    [GenerateAuthoringComponent]
    
    public struct SingleShotData : IDirectionSkillData
    {
        public Entity SingleShot;

        public float3 WorldPoint { get; set; }
        public bool Execute { get; set; }

    }
}

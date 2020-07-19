using Assets._Project.Scripts.Datas.Skills.Direction;
using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Datas.Skills.Direction
{
    public interface IDirectionSkillData : ISkillData
    {
        float3 WorldPoint { get; set; }
    }
}

using Unity.Entities;

namespace Assets._Project.Scripts.Datas.Skills
{
    public interface ISkillData : IComponentData
    {
        bool Execute { get; set; }
    }
}

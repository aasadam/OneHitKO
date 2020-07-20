using Assets._Project.Scripts.Datas.Destruction;
using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets._Project.Scripts.Entities.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Executers.Skills
{
    public static class DirectionSkillExecuter
    {
        public delegate void Execute(EntityManager manager, PlayerDirectionSkill skill, float3 worldPoint);

        public static void ExecuteSingleShot(EntityManager manager, PlayerDirectionSkill skill, float3 worldPoint)
        {
            var component = manager.GetComponentData<SingleShotData>(skill.Entity);
            component.Execute = true;
            component.WorldPoint = worldPoint;
            manager.SetComponentData(skill.Entity, component);
        }

        public static void ExecuteBlink(EntityManager manager, PlayerDirectionSkill skill, float3 worldPoint)
        {
            var component = manager.GetComponentData<BlinkData>(skill.Entity);
            component.Execute = true;
            component.WorldPoint = worldPoint;
            manager.SetComponentData(skill.Entity, component);
        }
    }
}

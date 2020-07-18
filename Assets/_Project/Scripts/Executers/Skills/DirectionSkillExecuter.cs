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
        public delegate void Execute(EntityManager manager, Entity skillEntity, float3 worldPoint);

        public static void ExecuteSingleShot(EntityManager manager, Entity skillEntity, float3 worldPoint)
        {
            var component = manager.GetComponentData<SingleShotData>(skillEntity);
            component.Execute = true;
            component.WorldPoint = worldPoint;
            manager.SetComponentData(skillEntity, component);
        }
    }
}

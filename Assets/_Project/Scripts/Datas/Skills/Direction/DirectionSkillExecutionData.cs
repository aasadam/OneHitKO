using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Datas.Skills.Direction
{
    [GenerateAuthoringComponent]
    public struct DirectionSkillExecutionData : IComponentData
    {
        public float3 WorldPoint;
        public bool ScheduleExecution;
        public bool ExecuteSkill;
    }
}

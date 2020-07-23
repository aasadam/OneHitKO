using Assets._Project.Scripts.Datas.Skills.Direction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;

namespace Assets._Project.Scripts.Systems.Skills.Direction
{
    public class DirectionSkillSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var time = Time.ElapsedTime;
            Entities.ForEach((ref DirectionSkillData directionSkill, ref DirectionSkillExecutionData executionData) =>
            {

                if (executionData.ScheduleCast && directionSkill.TimeLastCasted + directionSkill.CastPoint < time)
                {
                    directionSkill.TimeLastExecuted = time;
                    executionData.ScheduleCast = false;
                    executionData.ExecuteSkill = true;
                    return;
                }
                    
                if (executionData.ScheduleExecution)
                {
                    if (directionSkill.TimeLastExecuted + directionSkill.Cooldown < time)
                    {
                        executionData.ScheduleCast = true;
                        directionSkill.TimeLastCasted = time;
                    }

                    executionData.ScheduleExecution = false;
                }
            }).Schedule();
        }
    }
}

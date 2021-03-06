﻿using Assets._Project.Scripts.Datas.Skills.Direction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Assets._Project.Scripts.Systems.Skills.Direction
{
    public class BlinkSystem : SystemBase
    {
        BeginInitializationEntityCommandBufferSystem _entityCommandBufferSystem;

        protected override void OnCreate()
        {
            base.OnCreate();
            _entityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate()
        {
            //TODO: Understand diference between ToConcurrent() and without it
            var buffer = _entityCommandBufferSystem.CreateCommandBuffer().ToConcurrent();
            Entities.ForEach((Entity entity, int entityInQueryIndex, ref DirectionSkillExecutionData executionData, ref BlinkData blinkData, in LocalToWorld pos) =>
            {
                if (executionData.ExecuteSkill)
                {
                    if (math.distance(executionData.WorldPoint, pos.Position) > blinkData.MaxDistance)
                    {
                        buffer.AddComponent<Translation>(entityInQueryIndex, blinkData.ParentContainer, new Translation() { Value = pos.Position + (blinkData.MaxDistance * math.normalize(executionData.WorldPoint - pos.Position)) });
                    }
                    else
                    {
                        buffer.AddComponent<Translation>(entityInQueryIndex, blinkData.ParentContainer, new Translation() { Value = executionData.WorldPoint });
                    }
                    executionData.ExecuteSkill = false;
                }
            }).Schedule();

            //TODO: WHY?
            _entityCommandBufferSystem.AddJobHandleForProducer(Dependency);
        }
    }
}

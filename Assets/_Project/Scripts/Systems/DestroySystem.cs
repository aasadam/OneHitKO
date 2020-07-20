using Assets._Project.Scripts.Datas.Destruction;
using Assets._Project.Scripts.Datas.Position;
using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets.Scripts.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Assets._Project.Scripts.Systems
{
    public class DestroySystem : SystemBase
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
            Entities.ForEach((Entity entity, int entityInQueryIndex, ref DestroyByDistanceFromPointData destroyByDistance, in SpawnPositionData spawnPosition, in Translation translation) =>
            {
                if (math.distance(translation.Value, spawnPosition.WorldPosition) > destroyByDistance.Distance)
                    buffer.DestroyEntity(entityInQueryIndex, entity);

            }).Schedule();

            //TODO: WHY?
            _entityCommandBufferSystem.AddJobHandleForProducer(Dependency);
        }
    }
}

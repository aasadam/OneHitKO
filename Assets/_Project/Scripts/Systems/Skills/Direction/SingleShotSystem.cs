using Assets._Project.Scripts.Datas.Destruction;
using Assets._Project.Scripts.Datas.Position;
using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets.Scripts.Datas;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Assets._Project.Scripts.Systems.Skills
{
    public class SingleShotSystem : SystemBase
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
            Entities.ForEach((Entity entity, int entityInQueryIndex, ref SingleShotData singleShot, in LocalToWorld pos) =>
            {
                if (singleShot.Execute)
                {
                    //TODO: understand jobIndex parameter
                    var instance = buffer.Instantiate(entityInQueryIndex, singleShot.SingleShot);
                    buffer.AddComponent<MoveDirectionData>(entityInQueryIndex, instance, new MoveDirectionData(math.normalize((new float3(singleShot.WorldPoint.x, pos.Position.y, singleShot.WorldPoint.z) - pos.Position))));
                    buffer.AddComponent<Translation>(entityInQueryIndex, instance, new Translation() { Value = pos.Position });
                    buffer.AddComponent<SpawnPositionData>(entityInQueryIndex, instance, new SpawnPositionData() { WorldPosition = pos.Position });
                    buffer.RemoveComponent<Disabled>(entityInQueryIndex, instance);
                    singleShot.Execute = false;
                }
            }).Schedule();

            //TODO: WHY?
            _entityCommandBufferSystem.AddJobHandleForProducer(Dependency);
        }
    }
}

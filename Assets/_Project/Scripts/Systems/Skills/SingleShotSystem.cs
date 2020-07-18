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
            Entities.ForEach((ref SingleShotData singleShot, in LocalToWorld pos) =>
            {
                if (singleShot.Execute)
                {
                    //TODO: understand jobIndex parameter
                    var instance = buffer.Instantiate(0, singleShot.SingleShot);
                    buffer.AddComponent<MoveDirectionData>(0, instance, new MoveDirectionData(math.normalize((new float3(singleShot.WorldPoint.x, pos.Position.y, singleShot.WorldPoint.z) - pos.Position))));
                    buffer.AddComponent<Translation>(0, instance, new Translation() { Value = pos.Position });
                    buffer.RemoveComponent<Disabled>(0, instance);
                    singleShot.Execute = false;
                }
            }).Schedule();

            //TODO: WHY?
            _entityCommandBufferSystem.AddJobHandleForProducer(Dependency);
        }
    }
}

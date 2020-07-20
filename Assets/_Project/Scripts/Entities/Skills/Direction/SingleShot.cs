using Assets._Project.Scripts.Datas.Destruction;
using Assets.Scripts.Entidades;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

namespace Assets._Project.Scripts.Entities.Skills.Direction
{
    public struct SingleShot : IEntity
    {
        private readonly MoveSpeedData _moveData;
        private readonly RenderMesh _renderMesh;
        private readonly float _maxDistance;

        public SingleShot(float speed, Mesh mesh, Material material, float maxDistance)
        {
            _moveData = new MoveSpeedData
            {
                Speed = speed
            };

            _renderMesh = new RenderMesh
            {
                mesh = mesh,
                material = material
            };

            _maxDistance = maxDistance;
        }


        public Entity CreateEntity(EntityManager manager, Entity? parent = null)
        {
            var entity = manager.CreateEntity(new ComponentType[]
                                              {
                                                            typeof(MoveSpeedData),
                                                            typeof(Translation),
                                                            typeof(Rotation),
                                                            typeof(RenderMesh),
                                                            typeof(RenderBounds),
                                                            typeof(LocalToWorld)
                                              });
            manager.AddComponentData(entity, _moveData);
            manager.AddSharedComponentData(entity, _renderMesh);
            manager.AddComponentData<DestroyByDistanceFromPointData>(entity, new DestroyByDistanceFromPointData() { Distance = _maxDistance } );
            manager.AddComponent<Disabled>(entity);

            return entity;
        }
    }
}

using Assets._Project.Scripts.Datas.Destruction;
using Assets._Project.Scripts.Datas.Skills.Direction;
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
        private readonly float _cooldown;
        private readonly float _castPoint;

        public SingleShot(float speed, Mesh mesh, Material material, float maxDistance, float cooldown, float castPoint)
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
            _cooldown = cooldown;
            _castPoint = castPoint;
        }


        public Entity CreateEntity(EntityManager manager, Entity? parent = null, Entity? root = null)
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

            if(parent.HasValue)
            {
                manager.AddComponentData(parent.Value, new SingleShotData()
                {
                    SingleShot = entity
                });

                manager.AddComponentData(parent.Value, new DirectionSkillData()
                {
                    Cooldown = _cooldown,
                    CastPoint = _castPoint
                });
            }

            return entity;
        }
    }
}

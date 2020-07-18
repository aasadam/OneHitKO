using Assets.Scripts.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

namespace Assets.Scripts.Entidades.Powers
{
    public struct SingleShot
    {
        private readonly MoveSpeedData _moveData;
        private readonly RenderMesh _renderMesh;
        private float3 _startPosition;

        public SingleShot(float speed, Mesh mesh, Material material)
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

            _startPosition = default;
        }

        public void SetStartPosition(float3 position)
        {
            _startPosition = position;
        }

        public Entity CreateEntity(EntityManager manager)
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
            manager.AddComponentData(entity, new Translation() { Value = _startPosition });
            manager.AddComponentData(entity, _moveData);
            manager.AddSharedComponentData(entity, _renderMesh);
            manager.AddComponent<Disabled>(entity);

            return entity;
        }

        
    }
}

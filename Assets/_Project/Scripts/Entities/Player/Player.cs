using Assets._Project.Scripts.Datas.Skills;
using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets._Project.Scripts.Entities.Player;
using Assets._Project.Scripts.Executers.Skills;
using Assets.Scripts.Datas;
using Assets.Scripts.Entidades;
using System;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;

namespace Assets._Project.Scripts.Entities.Player
{
    public class Player : IEntity
    {
        private readonly PlayerObject _playerObject;
        private readonly float3 _startPosition;

        public Player(PlayerObject playerObject, float3 startPosition)
        {
            this._playerObject = playerObject;
            this._startPosition = startPosition;
        }

        public Entity PlayerEntity { get; private set; }
        public PlayerDirectionSkill Skill1 { get; private set; }
        public PlayerDirectionSkill Skill3 { get; private set; }

        public Entity CreateEntity(EntityManager manager, Entity? parent = null)
        {
            var player = manager.CreateEntity(new ComponentType[]
                                              {
                                                            typeof(MoveSpeedData),
                                                            typeof(Translation),
                                                            typeof(Rotation),
                                                            typeof(RenderMesh),
                                                            typeof(RenderBounds),
                                                            typeof(LocalToWorld),
                                                            typeof(MoveDirectionData)
                                              });
            manager.AddComponentData(player, new MoveSpeedData(_playerObject.Speed));
            manager.AddComponentData(player, new Translation() { Value = _startPosition });
            manager.AddSharedComponentData(player, new RenderMesh()
            {
                material = _playerObject.Material,
                mesh = _playerObject.Mesh
            });

            Skill1 = _playerObject.Skill1.AddDirectionSkill(manager, player);
            Skill3 = _playerObject.Skill3.AddDirectionSkill(manager, player);

            PlayerEntity = player;
            return player;
        }
    }
}

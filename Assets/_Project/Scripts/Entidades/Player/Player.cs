using Assets.Scripts.Datas;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;

namespace Assets.Scripts.Entidades.Player
{
    public struct Player : IEntity
    {
        private readonly PlayerObject _playerObject;

        public Player(PlayerObject playerObject)
        {
            this._playerObject = playerObject;
        }

        public Entity CreateEntity(EntityManager manager)
        {
            var player = manager.CreateEntity(new ComponentType[]
                                              {
                                                            typeof(MoveSpeedData),
                                                            typeof(Translation),
                                                            typeof(Rotation),
                                                            typeof(RenderMesh),
                                                            typeof(RenderBounds),
                                                            typeof(LocalToWorld),
                                                            typeof(InputMoveTag),
                                                            typeof(InputPowerPositionTag),
                                                            typeof(MoveDirectionData)
                                              });
            manager.AddComponentData(player, new Translation() { Value = _playerObject.Position });
            manager.AddComponentData(player, new MoveSpeedData(_playerObject.Speed));
            manager.AddSharedComponentData(player, new RenderMesh()
            {
                material = _playerObject.Material,
                mesh = _playerObject.Mesh
            });

            _playerObject.Power1.AddCallerComponents(manager, player);

            return player;
        }
    }
}

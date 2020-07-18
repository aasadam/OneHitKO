using Assets.Scripts.Datas;
using Assets.Scripts.Entidades.Powers;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Objects.Powers
{
    [CreateAssetMenu(fileName = "NewPowerAtPosition", menuName = "Power/Power at Position")]
    public class PowerAtPositionObject : PowerBase
    {
        public float Speed;
        public Mesh Mesh;
        public Material Material;

        public override void AddCallerComponents(EntityManager manager, Entity entity)
        {
            manager.AddComponentData(entity, new InputPowerPositionTag());
            manager.AddComponentData(entity, new SingleShotData()
            {
                SingleShot = (new SingleShot(Speed, Mesh, Material)).CreateEntity(manager)
            });
        }
    }
}

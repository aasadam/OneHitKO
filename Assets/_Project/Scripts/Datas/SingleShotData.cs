using Unity.Entities;

namespace Assets.Scripts.Datas
{
    [GenerateAuthoringComponent]
    public struct SingleShotData : IComponentData
    {
        public Entity SingleShot;
    }
}

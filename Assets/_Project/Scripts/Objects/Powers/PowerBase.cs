using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Objects.Powers
{
    public abstract class PowerBase : ScriptableObject
    {
        public abstract void AddCallerComponents(EntityManager manager, Entity entity);
    }
}

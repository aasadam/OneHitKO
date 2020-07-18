using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;

namespace Assets.Scripts.Extentions
{
    public static class EntityManagerExtentions
    {
        public static void AddComponents<TComponentData>(this EntityManager manager, Entity entity, IEnumerable<TComponentData> componentDatas) where TComponentData : struct, IComponentData
        {
            foreach (var component in componentDatas)
            {
                manager.AddComponentData(entity, component);
            }
        }

        public static void AddSharedComponents<TSharedComponentData>(this EntityManager manager, Entity entity, IEnumerable<TSharedComponentData> sharedComponentDatas) where TSharedComponentData : struct, ISharedComponentData
        {
            foreach (var component in sharedComponentDatas)
            {
                manager.AddSharedComponentData(entity, component);
            }
        }
    }
}

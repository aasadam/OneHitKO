using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Datas.Destruction
{
    [GenerateAuthoringComponent]
    public struct DestroyByDistanceFromPointData : IComponentData
    {
        public float Distance;
    }
}

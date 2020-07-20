using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Mathematics;

namespace Assets._Project.Scripts.Datas.Position
{
    [GenerateAuthoringComponent]
    public struct SpawnPositionData : IComponentData
    {
        public float3 WorldPosition;
    }
}

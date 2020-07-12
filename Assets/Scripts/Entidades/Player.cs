using Assets.Scripts.Datas;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

public class Player
{
    public static ComponentType[] GetComponents()
    {
        return new ComponentType[]
        {
            typeof(MoveData),
            typeof(Translation),
            typeof(Rotation),
            typeof(RenderMesh),
            typeof(RenderBounds),
            typeof(LocalToWorld),
            typeof(MoveInputData)
        };
    }
}

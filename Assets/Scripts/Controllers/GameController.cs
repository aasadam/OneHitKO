using Assets.Scripts.Statics;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float3 _newPlayerPosition;
    [SerializeField] private float _newPlayerSpeed;
    [SerializeField] private Mesh _newPlayerMesh;
    [SerializeField] private Material _newPlayerMaterial;

    private EntityManager _entityManager;

    private void Awake()
    {
        _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        InputStatic.Inputs.Enable();
    }

    private void OnDisable()
    {
        InputStatic.Inputs.Disable();
    }

    private void Start()
    {
        CreateNewPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateNewPlayer()
    {
        var player = _entityManager.CreateEntity(Player.GetComponents());
        _entityManager.AddComponentData(player, new Translation() { Value = _newPlayerPosition });
        _entityManager.AddComponentData(player, new MoveData(_newPlayerSpeed));
        _entityManager.AddSharedComponentData(player, new RenderMesh()
        {
            material = _newPlayerMaterial,
            mesh = _newPlayerMesh
        });
    }
}

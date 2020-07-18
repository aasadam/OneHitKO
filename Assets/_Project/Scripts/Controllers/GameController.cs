using Assets.Scripts.Entidades.Player;
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
    [SerializeField] private PlayerObject _newPlayer;

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
        new Player(_newPlayer).CreateEntity(_entityManager);
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}

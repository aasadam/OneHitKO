using Assets._Project.Scripts.Controllers;
using Assets._Project.Scripts.Entities.Player;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private PlayerObject _newPlayer;
    [SerializeField] private float3 _newPlayerStartPosition;
    //TODO: Handle player reference
    [SerializeField] private InputController _inputController;

    private EntityManager _entityManager;

    private void Awake()
    {
        _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
    }

    private void OnDisable()
    {
    }

    private void Start()
    {
        var player = new Player(_newPlayer, _newPlayerStartPosition);
        player.CreateEntity(_entityManager);
        _inputController.Player = player;
    }
}

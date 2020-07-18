using Assets._Project.Scripts.Controllers;
using Assets._Project.Scripts.Entities.Player;
using Unity.Entities;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private PlayerObject _newPlayer;
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
        var player = new Player(_newPlayer);
        player.CreateEntity(_entityManager);
        _inputController.Player = player;
    }
}

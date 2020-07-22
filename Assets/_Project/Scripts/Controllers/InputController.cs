using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets._Project.Scripts.Entities.Player;
using Assets.Scripts.Datas;
using Assets.Scripts.Statics;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Assets._Project.Scripts.Controllers
{
    public class InputController : MonoBehaviour
    {
        private Vector2 _pointerPosition;
        private EntityManager _entityManager;

        //TODO: Handle the player reference
        public Player Player;

        private void Awake()
        {
            _entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
            InputStatic.Inputs.Enable();

            InputStatic.Inputs.Player.Movement.performed += ctx => ChangeDirection(ctx.ReadValue<UnityEngine.Vector2>());
            InputStatic.Inputs.Player.PointerPosition.performed += ctx => _pointerPosition = ctx.ReadValue<Vector2>();
            InputStatic.Inputs.Player.Skill1.performed += ctx => UseSkill1();
            InputStatic.Inputs.Player.Skill3.performed += ctx => UseSkill3();
        }

        
        private void OnDisable()
        {
            InputStatic.Inputs.Disable();
        }

        private void ChangeDirection(Vector2 vector2)
        {
            _entityManager.SetComponentData(Player.PlayerEntity, new MoveDirectionData { Direction = new float3(vector2.x, 0, vector2.y) });
        }

        private void UseSkill1()
        {
            //Debug.Log($"Mouse pos : {_pointerPosition} === WorldPos: {Camera.main.ScreenToWorldPoint(new Vector3(_pointerPosition.x, _pointerPosition.y, Camera.main.transform.position.y))}");

            //TODO: Handle Camera reference
            ExecuteDirectionSkill(_entityManager, Player.Skill1, Camera.main.ScreenToWorldPoint(new Vector3(_pointerPosition.x, _pointerPosition.y, Camera.main.transform.position.y)));
            
        }

        private void UseSkill3()
        {
            //Debug.Log($"Mouse pos : {_pointerPosition} === WorldPos: {Camera.main.ScreenToWorldPoint(new Vector3(_pointerPosition.x, _pointerPosition.y, Camera.main.transform.position.y))}");

            //TODO: Handle Camera reference
            ExecuteDirectionSkill(_entityManager, Player.Skill3, Camera.main.ScreenToWorldPoint(new Vector3(_pointerPosition.x, _pointerPosition.y, Camera.main.transform.position.y)));
        }

        private static void ExecuteDirectionSkill(EntityManager manager, PlayerDirectionSkill skill, float3 worldPoint)
        {
            var component = manager.GetComponentData<DirectionSkillExecutionData>(skill.Entity);
            component.ScheduleExecution = true;
            component.WorldPoint = worldPoint;
            manager.SetComponentData(skill.Entity, component);
        }

    }
}

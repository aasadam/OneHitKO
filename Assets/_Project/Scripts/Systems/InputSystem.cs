using Assets.Scripts.Datas;
using Assets.Scripts.Statics;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Assets.Scripts.Systems
{
    public class InputSystem : SystemBase
    {
        private float3 _inputMoveDirection;
        private Vector2 _pointerPosition;
        private bool _pointerPress;

        BeginInitializationEntityCommandBufferSystem _entityCommandBufferSystem;

        protected override void OnCreate()
        {
            base.OnCreate();
            InputStatic.Inputs.Player.Movement.performed += ctx => ChangeDirection(ctx.ReadValue<UnityEngine.Vector2>());
            InputStatic.Inputs.Player.PointerPosition.performed += ctx => _pointerPosition = ctx.ReadValue<Vector2>();
            //InputStatic.Inputs.Player.PointerPress.performed += ctx => PointerPress();
            InputStatic.Inputs.Player.PointerPress.started += ctx => PointerPress();

            _entityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate()
        {

            float3 inputMoveDirection = _inputMoveDirection;

            Entities.ForEach((ref MoveDirectionData movData, in InputMoveTag inputData) =>
            {
                movData.Direction = inputMoveDirection;
            }).Schedule();

            if (_pointerPress)
            {
                var buffer = _entityCommandBufferSystem.CreateCommandBuffer().ToConcurrent();
                var worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(_pointerPosition.x, _pointerPosition.y, Camera.main.transform.position.y));

                Entities.ForEach((ref Translation pos, in SingleShotData singleShot, in InputPowerPositionTag inputPower) =>
                {
                    var instance = buffer.Instantiate(0, singleShot.SingleShot);
                    var direction = math.normalize((new float3(worldPosition.x, pos.Value.y, worldPosition.z) - pos.Value));
                    buffer.AddComponent<MoveDirectionData>(0, instance, new MoveDirectionData(direction));
                    buffer.AddComponent<Translation>(0, instance, new Translation() { Value = pos.Value });
                    buffer.RemoveComponent<Disabled>(0, instance);
                }).Schedule();
            }

            _pointerPress = false;
        }

        private void ChangeDirection(Vector2 vector2)
        {
            _inputMoveDirection = new float3(vector2.x, 0, vector2.y);
        }

        private void PointerPress()
        {
            _pointerPress = true;
            Debug.Log($"Mouse pos : {_pointerPosition} === WorldPos: {Camera.main.ScreenToWorldPoint(new Vector3(_pointerPosition.x, _pointerPosition.y, Camera.main.transform.position.y))}");
        }
    }
}

using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets._Project.Scripts.Entities.Player;
using Assets._Project.Scripts.Entities.Skills.Direction;
using Assets._Project.Scripts.Executers.Skills;
using Assets._Project.Scripts.Objects.Skills.Direction;
using Assets.Scripts.Entidades;
using System;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.Objects.Skills.Direction
{
    [CreateAssetMenu(fileName = "NewSingleShot", menuName = "Skills/Single Shot")]
    public class SingleShotObject : DirectionSkillObjectBase
    {
        public float Speed;
        public Mesh Mesh;
        public Material Material;

        public override PlayerDirectionSkill AddDirectionSkill(EntityManager manager, Entity entity)
        {
            var component = new SingleShotData()
            {
                SingleShot = (new SingleShot(Speed, Mesh, Material)).CreateEntity(manager)
            };

            var skill = new PlayerDirectionSkill(DirectionSkillExecuter.ExecuteSingleShot);

            skill.CreateEntity(manager, entity);

            manager.AddComponentData(skill.Entity, component);

            return skill;
        }
    }
}

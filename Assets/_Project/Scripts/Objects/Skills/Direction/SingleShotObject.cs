using Assets._Project.Scripts.Entities.Player;
using Assets._Project.Scripts.Entities.Skills.Direction;
using Assets._Project.Scripts.Objects.Skills.Direction;
using UnityEngine;

namespace Assets.Scripts.Objects.Skills.Direction
{
    [CreateAssetMenu(fileName = "NewSingleShot", menuName = "Skills/Single Shot")]
    public class SingleShotObject : DirectionSkillObjectBase
    {
        public float Speed;
        public Mesh Mesh;
        public Material Material;
        public float MaxDistance;
        public float CoolDown;
        public float CastPoint;

        public override PlayerDirectionSkill PlayerDirectionSkill => new PlayerDirectionSkill(new SingleShot(Speed, Mesh, Material, MaxDistance, CoolDown, CastPoint));
    }
}

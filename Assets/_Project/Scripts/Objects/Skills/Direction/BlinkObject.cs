using Assets._Project.Scripts.Entities.Player;
using Assets._Project.Scripts.Entities.Skills.Direction;
using UnityEngine;

namespace Assets._Project.Scripts.Objects.Skills.Direction
{
    [CreateAssetMenu(fileName = "NewSingleShot", menuName = "Skills/Blink")]
    public class BlinkObject : DirectionSkillObjectBase
    {
        public float Cooldown;
        public float CastPoint;

        public override PlayerDirectionSkill PlayerDirectionSkill => new PlayerDirectionSkill(new Blink(Cooldown, CastPoint));
    }
}

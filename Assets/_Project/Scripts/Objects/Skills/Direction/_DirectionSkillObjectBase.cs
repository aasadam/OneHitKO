using Assets._Project.Scripts.Entities.Player;
using UnityEngine;

namespace Assets._Project.Scripts.Objects.Skills.Direction
{
    public abstract class DirectionSkillObjectBase : ScriptableObject
    {
        public abstract PlayerDirectionSkill PlayerDirectionSkill { get; }
    }
}

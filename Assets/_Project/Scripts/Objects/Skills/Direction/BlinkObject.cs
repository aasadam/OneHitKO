using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets._Project.Scripts.Entities.Player;
using Assets._Project.Scripts.Entities.Skills.Direction;
using Assets._Project.Scripts.Executers.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using UnityEngine;

namespace Assets._Project.Scripts.Objects.Skills.Direction
{
    [CreateAssetMenu(fileName = "NewSingleShot", menuName = "Skills/Blink")]
    public class BlinkObject : DirectionSkillObjectBase
    {
        public override PlayerDirectionSkill PlayerDirectionSkill => new PlayerDirectionSkill(DirectionSkillExecuter.ExecuteBlink, new Blink());
    }
}

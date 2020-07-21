using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets._Project.Scripts.Entities.Player;
using Assets._Project.Scripts.Executers.Skills;
using Assets.Scripts.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using UnityEngine;

namespace Assets._Project.Scripts.Objects.Skills.Direction
{
    public abstract class DirectionSkillObjectBase : ScriptableObject
    {
        public abstract PlayerDirectionSkill PlayerDirectionSkill { get; }
    }
}

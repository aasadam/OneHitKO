using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets.Scripts.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;

namespace Assets._Project.Scripts.Entities.Skills.Direction
{
    public struct Blink : IEntity
    {
        private readonly float _cooldown;
        private readonly float _castPoint;
        private readonly float _maxdistance;

        public Blink(float cooldown, float castPoint, float maxdistance)
        {
            this._cooldown = cooldown;
            _castPoint = castPoint;
            _maxdistance = maxdistance;
        }

        public Entity CreateEntity(EntityManager manager, Entity? parent = null, Entity? root = null)
        {
            if (parent.HasValue)
            {
                manager.AddComponentData(parent.Value, new BlinkData()
                {
                    ParentContainer = root ?? parent.Value,
                    MaxDistance = _maxdistance
                });

                manager.AddComponentData(parent.Value, new DirectionSkillData()
                {
                    Cooldown = _cooldown,
                    CastPoint = _castPoint
                });
            }

            return parent ?? root ?? new Entity();
        }
    }
}

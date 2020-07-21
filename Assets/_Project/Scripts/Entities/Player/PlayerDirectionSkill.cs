using Assets._Project.Scripts.Executers.Skills;
using Assets.Scripts.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using Unity.Transforms;

namespace Assets._Project.Scripts.Entities.Player
{
    public class PlayerDirectionSkill : IEntity
    {
        private readonly IEntity _skill;

        public PlayerDirectionSkill(DirectionSkillExecuter.Execute executer, IEntity skill)
        {
            Executer = executer;
            this._skill = skill;
        }

        public DirectionSkillExecuter.Execute Executer { get; private set; }
        public Entity Entity { get; private set; }
        public Entity Parent { get; private set; }

        public Entity CreateEntity(EntityManager manager, Entity? parent = null, Entity? root = null)
        {
            var skill = manager.CreateEntity(new ComponentType[]
                                              {
                                                            typeof(Translation),
                                                            typeof(LocalToWorld)
                                              });

            manager.AddComponentData<Parent>(skill, new Parent() { Value = parent.Value });
            manager.AddComponentData<LocalToParent>(skill, new LocalToParent());


            Entity = skill;
            Parent = parent??skill;

            if(_skill != null)
                _skill.CreateEntity(manager, Entity, Parent);

            return skill;
        }
    }
}

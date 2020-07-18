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
        public PlayerDirectionSkill(DirectionSkillExecuter.Execute executer)
        {
            Executer = executer;
        }

        public DirectionSkillExecuter.Execute Executer { get; private set; }
        public Entity Entity { get; private set; }

        public Entity CreateEntity(EntityManager manager, Entity? parent = null)
        {
            var skill = manager.CreateEntity(new ComponentType[]
                                              {
                                                            typeof(Translation),
                                                            typeof(LocalToWorld)
                                              });

            manager.AddComponentData<Parent>(skill, new Parent() { Value = parent.Value });
            manager.AddComponentData<LocalToParent>(skill, new LocalToParent());

            Entity = skill;

            return skill;
        }
    }
}

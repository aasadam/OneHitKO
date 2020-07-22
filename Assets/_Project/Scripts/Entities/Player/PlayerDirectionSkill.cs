using Assets._Project.Scripts.Datas.Skills.Direction;
using Assets.Scripts.Entidades;
using Unity.Entities;
using Unity.Transforms;

namespace Assets._Project.Scripts.Entities.Player
{
    public class PlayerDirectionSkill : IEntity
    {
        private readonly IEntity _skill;

        public PlayerDirectionSkill(IEntity skill)
        {
            this._skill = skill;
        }

        public Entity Entity { get; private set; }
        public Entity Parent { get; private set; }

        public Entity CreateEntity(EntityManager manager, Entity? parent = null, Entity? root = null)
        {
            var skill = manager.CreateEntity(new ComponentType[]
                                              {
                                                            typeof(Translation),
                                                            typeof(LocalToWorld),
                                                            typeof(DirectionSkillExecutionData)
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

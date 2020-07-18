using Assets._Project.Scripts.Objects.Skills.Direction;
using Assets.Scripts.Objects.Skills;
using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayer", menuName = "Player")]
public class PlayerObject : ScriptableObject
{
    public float3 Position;
    public float Speed;
    public Mesh Mesh;
    public Material Material;
    public DirectionSkillObjectBase Skill1;
    public DirectionSkillObjectBase Skill3;
}

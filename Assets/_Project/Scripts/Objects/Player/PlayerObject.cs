using Assets.Scripts.Objects.Powers;
using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayer", menuName = "Player")]
public class PlayerObject : ScriptableObject
{
    public float3 Position;
    public float Speed;
    public Mesh Mesh;
    public Material Material;
    public PowerBase Power1;
}

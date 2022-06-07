using UnityEngine;

[CreateAssetMenu(fileName = "New BoomerangConfig", menuName = "Boomerangs/Boomerang Config", order = 0)]
public class SOBoomerang : ScriptableObject
{
    [Header("Configuration")]
    public Sprite sprite;
}

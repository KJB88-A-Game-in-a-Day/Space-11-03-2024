using UnityEngine;

[CreateAssetMenu(fileName = "AsteroidData", menuName = "Custom/AsteroidData", order = 2)]
public class AsteroidData : ScriptableObject
{
    [SerializeField] Vector2 radiusRange = new Vector2(.25f, 2.0f);
    public Vector2 RadiusRange => radiusRange;

    [SerializeField] Vector2 moveSpeedRange = new Vector2(.5f, 3.0f);
    public Vector2 MoveSpeedRange => moveSpeedRange;
}

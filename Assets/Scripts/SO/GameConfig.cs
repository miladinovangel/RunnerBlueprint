using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "gameConfig", menuName = "SO/GameConfig", order = 1)]
public class GameConfig : ScriptableObject
{
    public float playerSpeed;
    public float playerJumpPower;
    public float playerDashPower;
    public float playerWinZTarget;
}

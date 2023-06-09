using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Score", menuName = "SO/ScoreSO", order = 1)]
public class ScoreScriptableObject : ScriptableObject
{
    public List<int> scores;
    public int highScore;
}

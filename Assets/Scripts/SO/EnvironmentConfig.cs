using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "envConfig", menuName = "SO/EnvConfig", order = 1)]
public class EnvironmentConfig : ScriptableObject
{
    public Vector3 HousesOnLeftStartPos;
    public Vector3 HousesOnRightStartPos;
}

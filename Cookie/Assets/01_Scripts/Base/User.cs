using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class User
{
    public ulong money;
    public ulong popularity;
    public ulong secondLevel = 1;
    public ulong clickLevel = 1;

    public ulong secondPer;
    public ulong clickPer;
}

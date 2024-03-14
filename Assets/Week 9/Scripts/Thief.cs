using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

}

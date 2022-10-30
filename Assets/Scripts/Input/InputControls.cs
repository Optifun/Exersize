using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InputControls
{
    Vector3 Direction { get; }
    Vector3 Target { get; }
    Quaternion Rotation { get; }
}
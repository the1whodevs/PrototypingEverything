using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAnimator : MonoBehaviour
{
    public abstract void Move(Vector3 direction);
}

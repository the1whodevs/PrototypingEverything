using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonShooter_Controller : MonoBehaviour
{
    public enum PlayerMoveState { Idle, Run, Sprint, Jump }
    public enum PlayerStanceState { Stand, Crouch, Prone }
    public enum PlayerWeaponState { Idle, Fire, Reload }
    public enum PlayerAimState { Hip, ADS }

    public PlayerMoveState MoveState { get; private set; } = PlayerMoveState.Idle;
    public PlayerStanceState StanceState { get; private set; } = PlayerStanceState.Stand;
    public PlayerWeaponState WeaponState { get; private set; } = PlayerWeaponState.Idle;
    public PlayerAimState AimState { get; private set; } = PlayerAimState.Hip;
}
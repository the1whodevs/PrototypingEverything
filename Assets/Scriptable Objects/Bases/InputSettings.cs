using UnityEngine;

[CreateAssetMenu(menuName = "Veejay/Input Settings")]
public class InputSettings : ScriptableObject
{
    public InputKey ForwardKey = KeyCode.W;
    public InputKey BackwardKey = KeyCode.S;
    public InputKey LeftKey = KeyCode.A;
    public InputKey RightKey = KeyCode.D;
    public InputKey SprintKey = KeyCode.LeftShift;
    public InputKey CrouchKey = KeyCode.LeftControl;
    public InputKey JumpKey = KeyCode.Space;
    public InputKey FireKey = KeyCode.Mouse0;
    public InputKey AimKey = KeyCode.Mouse1;
}

[System.Serializable]
public class InputKey
{
    public enum KeyType { OnDown, OnUp, OnHold }

    public KeyCode Key = KeyCode.None;
    public KeyType Type = KeyType.OnHold;

    public InputKey(KeyCode key, KeyType type)
    {
        this.Key = key;
        this.Type = type;
    }

    public bool IsPressed()
    {
        switch (Type)
        {
            case KeyType.OnDown:
                return Input.GetKeyDown(Key);
                
            case KeyType.OnUp:
                return Input.GetKeyUp(Key);

            case KeyType.OnHold:
                return Input.GetKey(Key);
        }

        return false;
    }

    public static implicit operator InputKey(KeyCode key)
    {
        return new InputKey(key, KeyType.OnDown);
    }
}

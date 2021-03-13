using UnityEngine;

/// <summary>
/// Base class for MonoBehaviour singletons. Checks and destroys itself if there's an existing instance!
/// </summary>
/// <typeparam name="T">The class that should be the singleton, i.e. GameManager etc.</typeparam>
public class MonoSingleton<T> : MonoBehaviour where T: MonoBehaviour
{
    public static T Active
    {
        get
        {
            if (_instance) return _instance;

            _instance = FindObjectOfType<T>();

            return _instance;
        }
    }

    private static T _instance;
}
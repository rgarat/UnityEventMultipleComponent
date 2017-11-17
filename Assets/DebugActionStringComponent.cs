using UnityEngine;


public class DebugActionStringComponent : MonoBehaviour
{
    public string prefix;

    public void Execute(string message)
    {
        Debug.LogFormat("{0} - {1}", prefix, message);
    }
}

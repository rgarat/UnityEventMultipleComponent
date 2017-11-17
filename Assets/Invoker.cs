using UnityEngine;
using UnityEngine.Events;

public class Invoker : MonoBehaviour 
{

	public UnityEvent action;

	[ContextMenu("Execute")]
	public void Execute(){
		action.Invoke ();
	}
}

using UnityEngine;

public class SyncEntityPosition
	: MonoBehaviour
	, Ecsact.UnitySync.IRequired<example.Position>
	, Ecsact.UnitySync.IOnInitComponent<example.Position>
	, Ecsact.UnitySync.IOnUpdateComponent<example.Position>
{
	public void OnInitComponent(in example.Position component) {
		transform.localPosition = new Vector2{x=component.x, y=component.y};
	}

	public void OnUpdateComponent(in example.Position component) {
		transform.localPosition = new Vector2{x=component.x, y=component.y};
	}
}

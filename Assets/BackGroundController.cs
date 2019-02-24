using System.Collections;
using UnityEngine;

public class BackGroundController : MonoBehaviour {

	private float scroll = -0.03f;

	private float deadLine = -16.0f;

	private float startLine = 15.8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (this.scroll, 0, 0);

		if(transform.position.x < this.deadLine){
			transform.position = new Vector2 (this.startLine, 0);
		}
	}
}

using UnityEngine;
using System.Collections.Generic;


public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			// キューブを移動させる
			this.transform.Translate(this.speed, 0, 0);

			// 画面の外に出たら破棄する
			if (this.transform.position.x < this.deadLine) {
				Destroy (this.gameObject);
			}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		/* 衝突対象が自身または地面	*/
		if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
			/* 効果音を鳴らす	*/
			gameObject.GetComponent<AudioSource> ().Play ();
	}
}

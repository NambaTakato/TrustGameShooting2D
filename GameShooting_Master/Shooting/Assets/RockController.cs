using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour {

	float fallSpeed;
	float rotSpeed;

	void Start () {
		this.fallSpeed = 0.01f + 0.1f * Random.value;
		this.rotSpeed = 5f + 3f * Random.value;
	}

	void Update () {
		transform.Translate( 0, -fallSpeed, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed );

		if (transform.position.y < -5.5f) {
            //座標の移動を行う
            GameObject.Find("GameOver").transform.position = new Vector3(90, 100, 0);
            GameObject.Find ("Canvas").GetComponent<UIController> ().GameOver ();
			Destroy (gameObject);
		}
	}
}
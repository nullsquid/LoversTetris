using UnityEngine;
using System.Collections;

public class Piece : MonoBehaviour {
	public float fallStepSpeed = 1.0f;
	private bool falling = true;
	void Start(){
		StartCoroutine("FallStep");
	}

	IEnumerator FallStep(){
		while(falling == true){
			transform.localPosition = new Vector3(0, 1, 0);
			yield return new WaitForSeconds(fallStepSpeed);
		}
		yield return null;
	}

	void OnCollisionEnter(){

	}
}

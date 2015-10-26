using UnityEngine;
using System.Collections;

public class BlockRotate : MonoBehaviour {


	public float naturalYPos;
	public float naturalXPos;
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			RotateClockwise();
		}
		else if(Input.GetMouseButtonDown(1)){

		}
	}

	void RotateClockwise(){
		if(transform.eulerAngles.z == 0f){
			transform.localPosition += new Vector3(.5f, -1.5f, 0f);
			transform.Rotate(Vector3.forward *90);

		}
		else if(transform.eulerAngles.z >= 90.0f && transform.eulerAngles.z < 180f){
			transform.localPosition += new Vector3(1.5f, .5f, 0f);
			transform.Rotate(Vector3.forward *90);

		}
		else if (transform.eulerAngles.z >= 180 && transform.eulerAngles.z < 270){
			transform.localPosition += new Vector3(-.5f, 1.5f, 0);
			transform.Rotate(Vector3.forward *90);

		}
		else if (transform.eulerAngles.z >= 270){

			transform.localPosition = new Vector3(naturalXPos, naturalYPos, 0);
			transform.Rotate(Vector3.forward *90);

		}
	}

	void RotateCounterClockwise(){

	}
}

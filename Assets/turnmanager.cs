using UnityEngine;
using System.Collections;

public class turnmanager : MonoBehaviour {
	private bool nextTurn = false;
	private bool realTime = false;
	public float turnLength = 5.0f;
	private int playerNumber =  1;
	private float pauseTimeScale = 0.0f;
	private float realTimeScale = 1.0f;
	public int turnNumber;

	
	void Update(){
		if(Input.GetKeyDown(KeyCode.Space) && !realTime){
			NextTurn();
		}
	}

	void NextTurn(){
		//do logic
		nextTurn = true;
		if(nextTurn){
			if(playerNumber == 1){
				playerNumber = 2;
			}
			else if(playerNumber == 2){
				playerNumber = 1;
			}
			turnNumber++;
		}
		Debug.Log(playerNumber);
		nextTurn = false;
	}

	void StartPlayerSetup(){
		playerNumber = 1;
	}


}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Randomizer : MonoBehaviour {

	public Piece[] pieces = new Piece[7];
	private List<Piece> allPieces = new List<Piece>();
	List<Piece> bag = new List<Piece>();

	void Start(){
		InitializeAllPieces();
	}
	void Update(){
		if(bag.Count == 0){
			FillBag();
		}
	}
	void FillBag(){
		for(int i = 0; i < allPieces.Count; i++){
			bag.Add (allPieces[i]);
			allPieces.RemoveAt(i);
		}
		InitializeAllPieces();
	}
	void InitializeAllPieces(){
		for(int i = 0; i < pieces.Length; i++){
			allPieces.Add(pieces[i]);
		}
	}

	void RemovePieceFromBag(){
		bag.RemoveAt(0);
	}
}

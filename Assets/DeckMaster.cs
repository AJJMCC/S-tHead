using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckMaster : MonoBehaviour {
    public static DeckMaster Instance;
    public enum StateOfPlay { Playergethering,CardDealing,CardSwitching, Playing,GameOver,  };

    

    public StateOfPlay CurrentState;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool CanPlaceCard(GameObject card)
    {
        return false;
    }
}

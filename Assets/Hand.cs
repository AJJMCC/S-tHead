using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {


    public List<GameObject> CardsInHand;

    private bool IsACardSelected;
    public List<GameObject> SelectedCards;
    private bool AreCardsTheSame;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlayerTappedCard(GameObject TappedCard)
    {
        if (TappedCard.GetComponent<Card>().IsSelected == true)
        
            PlayerDeselectedCard(TappedCard);
            

        else
        
            PlayerSelectedCard(TappedCard);
        
    }

    void PlayerTappedPlaceButton()
    {
        if (SelectedCards.Count == 1)
        {
            PlaceSingularCard();
        }

    }



    void PlayerSelectedCard(GameObject SelectedCard)
    {
        if (DeckMaster.Instance.CanPlaceCard(SelectedCard))
        {

            foreach (GameObject cardo in CardsInHand)
            {
                if (GetComponent<Card>().IsSelected == true)
                {
                    IsACardSelected = true;
                    SelectedCards.Add(cardo);
                }

            }

            foreach (GameObject Cardos in SelectedCards)

            {

                if (Cardos.GetComponent<Card>().Rank != SelectedCard.GetComponent<Card>().Rank)
                {
                    AreCardsTheSame = false;
                }


            }

            if (!IsACardSelected)
            {
                HighLightCard(SelectedCard);
            }

            
            else if (AreCardsTheSame)
            {
                HighLightCard(SelectedCard);
            }

            
        }

    }

    void HighLightCard(GameObject CardToHighLight)
    {

    }

    void PlayerDeselectedCard(GameObject CardToDeselect)
    {

    }


    void PlaceSingularCard()
    {

    }
  
}

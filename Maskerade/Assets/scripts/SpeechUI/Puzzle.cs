using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
public class Puzzle : MonoBehaviour
{
//goals for this class
//setup level layouts
//spawner for level items and resets level
//checks if answers are correct
//if they are then friend made if not then suspicion is increased and task failed?
[Header("puzzle options (draggables)")]
[SerializeField] private GameObject option1;
[SerializeField] private GameObject option2;
[SerializeField] private GameObject option3;
[SerializeField] private GameObject option4;
    int answer;
    [Space]
    [SerializeField] private GameObject clock;
    [SerializeField] private GameObject suspicion;
    public GameObject floaterPrefab;
    Sprite[] levelOptions;
List<Sprite> floaterSprites = new List<Sprite>();
    //private bool startRound = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//npc sends puzzle the round data, after round done npc sends next round if available
    public void SetPuzzleOptions(int answer_, Sprite option1Sprite, Sprite option2Sprite, Sprite option3Sprite, Sprite option4Sprite)
    {
        answer = answer_;
        Sprite[] levelOptions = {option1Sprite,option2Sprite,option3Sprite,option4Sprite};
        option1.GetComponent<Image>().sprite = option1Sprite;
        option2.GetComponent<Image>().sprite = option2Sprite;
        option3.GetComponent<Image>().sprite = option3Sprite;
        option4.GetComponent<Image>().sprite = option4Sprite;


    }

    //the stream of floaters coming out
    public void SetPuzzle(Sprite floater1Sprite, Sprite floater2Sprite, Sprite floater3Sprite){
floaterSprites.Clear();
floaterSprites.Add(floater1Sprite);
floaterSprites.Add(floater2Sprite);
floaterSprites.Add(floater3Sprite);
        StartRound();
    }
    public void SetPuzzle(Sprite floater1Sprite, Sprite floater2Sprite, Sprite floater3Sprite, Sprite floater4Sprite){
floaterSprites.Clear();
floaterSprites.Add(floater1Sprite);
floaterSprites.Add(floater2Sprite);
floaterSprites.Add(floater3Sprite);
floaterSprites.Add(floater4Sprite);
		StartRound();
	}
    public void SetPuzzle(Sprite floater1Sprite, Sprite floater2Sprite, Sprite floater3Sprite, Sprite floater4Sprite, Sprite floater5Sprite){
floaterSprites.Clear();
floaterSprites.Add(floater1Sprite);
floaterSprites.Add(floater2Sprite);
floaterSprites.Add(floater3Sprite);
floaterSprites.Add(floater4Sprite);
floaterSprites.Add(floater5Sprite);
		StartRound();
	}

    public void StartRound()
    {
clock.GetComponent<timerTracker>().startTimer();
        Instantiate(floaterPrefab);
        Debug.Log("instantiated");
	}
    public void checkAnswer(int answer_)
    {
        if (answer_ != answer) {
            suspicion.GetComponent<suspicionTracker>().ChangeSuspicionByAmount(10);

		}
		//start next round if available
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public string textValue;
    public Text textElement;
    public int point;
    private string nameAgain;
    private float diceRoll1;
    private float diceRoll2;
    private int choice;

    // Start is called before the first frame update
    void Start()
    {
        point = 1;
        textValue = "(Use Space to continue. When prompted, press the number or letter that corresponds to the option to make that decision.)";
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = textValue;

        GameObject crewMember = GameObject.Find("CrewMember");
        CrewInfo crewInfo = crewMember.GetComponent<CrewInfo>();
        nameAgain = crewInfo.crewName;

        if (point == 7 && Input.GetKeyDown("space"))
        {
            textValue = "";
            textElement.text = textValue;
            point = 8;
        }
        if (point == 6 && Input.GetKeyDown("1"))
        {
            diceRoll1 = Random.Range(1.0f, 6.0f) + crewInfo.dexterity;
            diceRoll2 = Random.Range(1.0f, 6.0f) + crewInfo.strength;
            if (diceRoll1 >= 3 && choice == 2)
            {
                textValue = "It Works! Somehow punching one of the sharks in the nose worked. Our shipmate lifted it out of the water, gave those nostrils a good slap, and let the man eating fish go. The sharks swim off.";
            }
            else if (diceRoll1 < 3 && choice == 2)
            {
                textValue = "Uh Oh. Maybe trying to punch a shark when there’s a swarm of them wasn’t a good idea. Our shipmate got bitten badly. If a shark could smile I swear they’d be grinning from fish ear to fish ear";
            }
            else if (diceRoll2 >= 3 && choice == 1)
            {
                textValue = "It Works! With a mighty toss, we threw a piece of meat far away from our ship, and those sharks followed it! We better get out of here before they release they’ve been tricked.";
            }
            else
            {
                textValue = "It Doesn’t Work! Despite claiming they could throw far, our shipmate just didn’t deliver. It probably went like a couple feet. The sharks are still here and now they’re hungrier than ever.";
            }
            textElement.text = textValue;
            point = 7;
        }
        if (point == 6 && Input.GetKeyDown("2"))
        {
            diceRoll1 = Random.Range(1.0f, 6.0f) + crewInfo.dexterity;
            diceRoll2 = Random.Range(1.0f, 6.0f) + crewInfo.strength;
            if (diceRoll1 >= 3 && choice == 2)
            {
                textValue = "It Works! Somehow punching one of the sharks in the nose worked. Our shipmate lifted it out of the water, gave those nostrils a good slap, and let the man eating fish go. The sharks swim off.";
            }
            else if (diceRoll1 < 3 && choice == 2)
            {
                textValue = "Uh Oh. Maybe trying to punch a shark when there’s a swarm of them wasn’t a good idea. Our shipmate got bitten badly. If a shark could smile I swear they’d be grinning from fish ear to fish ear";
            }
            else if (diceRoll2 >= 3 && choice == 1)
            {
                textValue = "It Works! With a mighty toss, we threw a piece of meat far away from our ship, and those sharks followed it! We better get out of here before they release they’ve been tricked.";
            }
            else
            {
                textValue = "It Doesn’t Work! Despite claiming they could throw far, our shipmate just didn’t deliver. It probably went like a couple feet. The sharks are still here and now they’re hungrier than ever.";
            }
            textElement.text = textValue;
            point = 7;
        }
        if (point == 6 && Input.GetKeyDown("3"))
        {
            diceRoll1 = Random.Range(1.0f, 6.0f) + crewInfo.dexterity;
            diceRoll2 = Random.Range(1.0f, 6.0f) + crewInfo.strength;
            if (diceRoll1 >= 3 && choice == 2)
            {
                textValue = "It Works! Somehow punching one of the sharks in the nose worked. Our shipmate lifted it out of the water, gave those nostrils a good slap, and let the man eating fish go. The sharks swim off.";
            }
            else if (diceRoll1 < 3 && choice == 2)
            {
                textValue = "Uh Oh. Maybe trying to punch a shark when there’s a swarm of them wasn’t a good idea. Our shipmate got bitten badly. If a shark could smile I swear they’d be grinning from fish ear to fish ear";
            }
            else if (diceRoll2 >= 3 && choice == 1)
            {
                textValue = "It Works! With a mighty toss, we threw a piece of meat far away from our ship, and those sharks followed it! We better get out of here before they release they’ve been tricked.";
            }
            else
            {
                textValue = "It Doesn’t Work! Despite claiming they could throw far, our shipmate just didn’t deliver. It probably went like a couple feet. The sharks are still here and now they’re hungrier than ever.";
            }
            textElement.text = textValue;
            point = 7;
        }
        if (point == 6 && Input.GetKeyDown("4"))
        {
            diceRoll1 = Random.Range(1.0f, 6.0f) + crewInfo.dexterity;
            diceRoll2 = Random.Range(1.0f, 6.0f) + crewInfo.strength;
            if (diceRoll1 >= 3 && choice == 2)
            {
                textValue = "It Works! Somehow punching one of the sharks in the nose worked. Our shipmate lifted it out of the water, gave those nostrils a good slap, and let the man eating fish go. The sharks swim off.";
            }
            else if (diceRoll1 < 3 && choice == 2)
            {
                textValue = "Uh Oh. Maybe trying to punch a shark when there’s a swarm of them wasn’t a good idea. Our shipmate got bitten badly. If a shark could smile I swear they’d be grinning from fish ear to fish ear";
            }
            else if (diceRoll2 >= 3 && choice == 1)
            {
                textValue = "It Works! With a mighty toss, we threw a piece of meat far away from our ship, and those sharks followed it! We better get out of here before they release they’ve been tricked.";
            }
            else
            {
                textValue = "It Doesn’t Work! Despite claiming they could throw far, our shipmate just didn’t deliver. It probably went like a couple feet. The sharks are still here and now they’re hungrier than ever.";
            }
            textElement.text = textValue;
            point = 7;
        }
        if (point == 5 && Input.GetKeyDown("a"))
        {
            textValue = "And who will you send out...\n1. " + "Sailor" + "\t\t\t\t\t\t\t\t\t\t2. " + "Navigator" + "\n3. " + "Warrior" + "\t\t\t\t\t\t\t\t\t4. " + "Shaman"; //Replace names with nameAgain
            textElement.text = textValue;
            point = 6;
            choice = 1;
        }
        if (point == 5 && Input.GetKeyDown("b"))
        {
            textValue = "And who will you send out...\n1. " + "Sailor" + "\t\t\t\t\t\t\t\t\t2. " + "Navigator" + "\n2. " + "Warrior" + "\t\t\t\t\t\t\t\t\t2. " + "Shaman";
            textElement.text = textValue;
            point = 6;
            choice = 2;
        }
        if (point == 4 && Input.GetKeyDown("space"))
        {
            textValue = "Will you...\nOption A: Throw Some Food as a Distraction\nOption B: Try to Punch a Shark in the Nose";
            textElement.text = textValue;
            point = 5;
        }
        if (point == 3 && Input.GetKeyDown("space"))
        {
            textValue = "Option B: While some of us weren’t sure what to do, someone mentioned how they had heard if you punched a shark in the nose it would leave you alone. Surely this should work, right?";
            textElement.text = textValue;
            point = 4;
        }
        if (point == 2 && Input.GetKeyDown("space"))
        {
            textValue = "Option A: We have some meat on board, if we use our strength we could throw it far enough to distract the sharks and sail away. It’s worth a shot.";
            textElement.text = textValue;
            point = 3;
        }
        if (point == 1 && Input.GetKeyDown("space"))
        {
            textValue = "While it started off a normal day, you couldn’t help but notice all the dark forms in the water circling around your ship! Judging by the fins poking out of the water, it’s sharks… maybe you shouldn’t have thrown that rotten meat overboard.";
            textElement.text = textValue;
            point = 2;
        }
    }
}

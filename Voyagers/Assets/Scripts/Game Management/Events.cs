using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public string textValue;
    public Text textElement;
    public int point;
    private int choice;
    private int statMod;
    private float roll;

    public string name1;
    public int FRT1, STR1, DEX1, INT1;
    public string name2;
    public int FRT2, STR2, DEX2, INT2;
    public string name3;
    public int FRT3, STR3, DEX3, INT3;
    public string name4;
    public int FRT4, STR4, DEX4, INT4;

    // Start is called before the first frame update
    void Start()
    {
        point = 1;
        textValue = "(Use Space to continue. When prompted, press the number or letter that corresponds with the option to make that decision.)";
        Debug.Log(point);

        name1 = "Olaf";
        FRT1 = 1;
        STR1 = 1;
        DEX1 = 1;
        INT1 = 0;

        name2 = "Erik";
        FRT2 = 0;
        STR2 = -1;
        DEX2 = 2;
        INT2 = 2;

        name3 = "Bjork";
        FRT3 = 2;
        STR3 = 3;
        DEX3 = -1;
        INT3 = -1;

        name4 = "Ysoppa";
        FRT4 = -1;
        STR4 = 1;
        DEX4 = 0;
        INT4 = 3;
}

    // Update is called once per frame
    void Update()
    {
        textElement.text = textValue;

        // 7. End
        if (point == 7 && Input.GetKeyDown("space"))
        {
            textValue = "";
            textElement.text = textValue;
            point = 8;
        }
        
        // 6. Result
        if (point == 6 && Input.GetKeyDown("1") || Input.GetKeyDown("2") && point == 6 || Input.GetKeyDown("3") && point == 6 || Input.GetKeyDown("4") && point == 6)
        {
            if (Input.GetKeyDown("1") && choice == 1)
            {
                statMod = DEX1;
            }
            else if (Input.GetKeyDown("1") && choice == 2)
            {
                statMod = STR1;
            }
            if (Input.GetKeyDown("2") && choice == 1)
            {
                statMod = DEX2;
            }
            else if (Input.GetKeyDown("2") && choice == 2)
            {
                statMod = STR2;
            }
            if (Input.GetKeyDown("3") && choice == 1)
            {
                statMod = DEX3;
            }
            else if (Input.GetKeyDown("3") && choice == 2)
            {
                statMod = STR3;
            }
            if (Input.GetKeyDown("4") && choice == 1)
            {
                statMod = DEX4;
            }
            else if (Input.GetKeyDown("4") && choice == 2)
            {
                statMod = STR4;
            }

            roll = Random.Range(1.0f, 6.0f) + statMod;

            if (roll >= 3 && choice == 1)
            {
                textValue = "Success! With a mighty toss, we threw a piece of meat far away from our ship, and those sharks followed it! We better get out of here before they release they’ve been tricked.";
            }
            else if (roll < 3 && choice == 1)
            {
                textValue = "Failure! Despite claiming they could throw far, our shipmate just didn’t deliver. It probably went like a couple feet. The sharks are still here and now they’re hungrier than ever.";
            }
            else if (roll >= 3 && choice == 2)
            {
                textValue = "Success! Somehow punching one of the sharks in the nose worked. Our shipmate lifted it out of the water, gave those nostrils a good slap, and let the man eating fish go. The sharks swim off.";
            }
            else if (roll < 3 && choice == 2)
            {
                textValue = "Failure! Maybe trying to punch a shark when there’s a swarm of them wasn’t a good idea. Our shipmate got bitten badly. If a shark could smile I swear they’d be grinning from fish ear to fish ear";
            }

            textElement.text = textValue;
            point = 7;
        }

        // 5. Crewmate Choice
        if (point == 5 && Input.GetKeyDown("a") || Input.GetKeyDown("b") && point == 5)
        {
            if (Input.GetKeyDown("a"))
            {
                choice = 1;
            }
            else if (Input.GetKeyDown("b"))
            {
                choice = 2;
            }

            textValue = "And who will you send out...\n1. " + name1 + "\t\t\t\t\t\t\t\t\t\t2. " + name2 + "\n3. " + name3 + "\t\t\t\t\t\t\t\t\t4. " + name4;
            textElement.text = textValue;
            point = 6;
        }
        
        // 4. Action Choice
        if (point == 4 && Input.GetKeyDown("space"))
        {
            textValue = "Will you...\nOption A: Throw Some Food as a Distraction\nOption B: Try to Punch a Shark in the Nose";
            textElement.text = textValue;
            point = 5;
        }
        
        // 3. Option B
        if (point == 3 && Input.GetKeyDown("space"))
        {
            textValue = "Option B: While some of us weren’t sure what to do, someone mentioned how they had heard if you punched a shark in the nose it would leave you alone. Surely this should work, right?";
            textElement.text = textValue;
            point = 4;
        }
        
        // 2. Option A
        if (point == 2 && Input.GetKeyDown("space"))
        {
            textValue = "Option A: We have some meat on board, if we use our strength we could throw it far enough to distract the sharks and sail away. It’s worth a shot.";
            textElement.text = textValue;
            point = 3;
        }
        
        // 1. Initial
        if (point == 1 && Input.GetKeyDown("space"))
        {
            textValue = "While it started off a normal day, you couldn’t help but notice all the dark forms in the water circling around your ship! Sharks. Maybe you shouldn’t have thrown that rotten meat overboard...";
            textElement.text = textValue;
            point = 2;
        }

    }
}

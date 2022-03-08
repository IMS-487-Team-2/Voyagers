using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CrewInfo : MonoBehaviour
{
    public string crewName;
    [SerializeField] public int strength, dexterity, intellect, fortitude; // Serialized for viewing, should not actually be changed in the viewer
    private MoodEnum mood;
    private List<string> data;
    private List<List<string>> dialogueOptions = new List<List<string>>();
    [SerializeField] private TextAsset crewDataFile = null;


    // Start is called before the first frame update
    void Start()
    {
        crewName = "Fred";
        //this.hp = 4;

        //Base setup values for an example character
        //this.strength = 1;
        //this.dexterity = 1;
        //this.intellect = 2;
        //this.fortitude = -1;

        this.mood = MoodEnum.Amazing;
        ReadFileInfo();
        /*PrintListElements(dialogueOptions[0]);
        PrintListElements(dialogueOptions[1]);
        PrintListElements(dialogueOptions[2]);
        PrintListElements(dialogueOptions[3]);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ReadFileInfo()
    {
        this.data = new List<string>(crewDataFile.text.Split('|'));
        CleanLines(data);
        this.crewName = data[0];
        this.strength = int.Parse(data[1]);
        this.dexterity = int.Parse(data[2]);
        this.intellect = int.Parse(data[3]);
        this.fortitude = int.Parse(data[4]);
        int n = 5;
        List<string> temp;
        for (int i = 0; i < 4; i++)
        {
            temp = new List<string>();
            for (int j = 0; j < 5; j++)
            {
                temp.Add(data[n]);
                n++;
            }
            dialogueOptions.Add(temp);
            
        }
        
    }

    // This method cleans up the strings in the list. It will remove any new lines from a string, and turn any "_" that are followed by a new line into a space
    private void CleanLines(List<string> data)
    {
        for (int i = 0; i < data.Count; i++)
        {
            string temp = "";
            for(int j = 0; j < data[i].Length; j++)
            {
                if ((data[i][j].Equals('_')) && (j + 2 < data[i].Length))
                {
                    if (data[i][j + 2].Equals('\n')) temp += " ";
                }
                else if (!data[i][j].Equals('\n')) temp += data[i][j];
            }
            data[i] = temp;
        }
    }

    // Test method to print the elements of a list provided to a Debug.Log()
    private void PrintListElements(List<string> list)
    {
        string str = "[";
        for (int i = 0; i < list.Count; i++)
        {
            if (i + 1 == list.Count) str += list[i] + "]";
            else str += list[i] + ",  ";
        }
        Debug.Log(str);
    }
}


//GameObject crewMember = GameObject.Find("CrewMember");
//CrewInfo crewInfo = crewMember.GetComponent<CrewInfo>();
//nameAgain = crewInfo.crewName;

// GameObject crewMember = GameObject.Find("Crewmate");
//Crewmate crewInfo = crewMember.GetComponent<Crewmate>();
//nameAgain = crewInfo.crewmateName;
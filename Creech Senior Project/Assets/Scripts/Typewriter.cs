using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typewriter : MonoBehaviour
{
    public Text TextComponenet;

    private static Typewriter instance;
    private List<string> messages = new List<string>();
    private float timer = 0;
    private int charIndex = 0;
    private float timePerChar = 0.05f;
    private string currentMsg = "Welcome to Dungeon Escape. Here are the basic roles of this game." +
        "There are a total of three mazes and you need to collect 5 keys in order to get out of the level. While not dying, time runs out, and avoiding hazards." +
        " At the end of the level there will be a mini boss that you have to defeat in order to advance. Do all that you have won the game. Best of luck. You're gonna need it.";

    private void Awake()
    {
        instance = this;

    }

    private void Update()
    {

        if (string.IsNullOrEmpty(currentMsg))
            return;

        //keep revealing more of the message 
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer += timePerChar;
            charIndex++;

            //assign the message to the typewriter
            string tmpMessage = currentMsg.Substring(0, charIndex);
            

            TextComponenet.text = tmpMessage;

            //if we have reached the end of the sentence, stop typing 
            if(charIndex >= currentMsg.Length)
            {
                currentMsg = null;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum States
    {
        FrogPond,
        MateFrogPond,
        WeirdHouse,
        TheCity,
        JewelleryStore,
        BackAtPond,
        InThePark,
        Hospital,
        ParkPond,
        IgnoreTheBoss,
        DefeatTheBoss,
        Choice1,
        Choice2,
        Choice3,
        Death1,
        Death2,
        Death3,
        Victory
    }

    private States currentState = States.FrogPond;

    void Start()
    {
        Terminal.WriteLine("You start as a simple frog at a\npeaceful pond, when an unusual day\ntakes you on a strange adventure.\n\nType start to start");
    }

    private void OnUserInput(string input)
    {
        string userInput = input.ToLower();

        switch (currentState)
        {
            case States.FrogPond:
                if (userInput == "start")
                {
                    StartGame();
                }
                break;
            case States.MateFrogPond:
                if (userInput == "continue")
                {
                    FirstChoice();
                }
                break;
            case States.Choice1:
                if (userInput == "frog")
                {
                    WeirdHouse();
                }
                else if (userInput == "city")
                {
                    TheCity();
                }
                break;
            case States.WeirdHouse:
                if (userInput == "continue")
                {
                    Death1();
                }
                break;
            case States.TheCity:
                if (userInput == "continue")
                {
                    JewelleryStore();
                }
                break;
            case States.JewelleryStore:
                if (userInput == "continue")
                {
                    SecondChoice();
                }
                break;
            case States.Choice2:
                if (userInput == "necklace")
                {
                    BoughtNecklace();
                }
                else if (userInput == "watch")
                {
                    BoughtWatch();
                }
                break;
            case States.BackAtPond:
                if (userInput == "continue")
                {
                    Hospital();
                }
                break;
            case States.InThePark:
                if (userInput == "continue")
                {
                    ParkPond();
                }
                break;
            case States.Hospital:
                if (userInput == "continue")
                {
                    Death2();
                }
                break;
            case States.ParkPond:
                if (userInput == "continue")
                {
                    ThirdChoice();
                }
                break;
            case States.Choice3:
                if (userInput == "fight")
                {
                    DefeatTheBoss();
                }
                else if (userInput == "ignore")
                {
                    IgnoreTheBoss();
                }
                break;
            case States.IgnoreTheBoss:
                if (userInput == "continue")
                {
                    Death3();
                }
                break;
            case States.DefeatTheBoss:
                if (userInput == "continue")
                {
                    WinGame();
                }
                break;
            case States.Death1:
                if (userInput == "restart")
                {
                    RestartGame();
                }
                break;
            case States.Death2:
                if (userInput == "restart")
                {
                    RestartGame();
                }
                break;
            case States.Death3:
                if (userInput == "restart")
                {
                    RestartGame();
                }
                break;
            case States.Victory:
                if (userInput == "restart")
                {
                    RestartGame();
                }
                break;
        }
    }

    private void RestartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You start as a simple frog at a\npeaceful pond, when an unusual day\ntakes you on a strange adventure.\n\nType start to start");
        currentState = States.FrogPond;
    }
    private void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("A mysterious female frog beckons\ntowards a dark forest. You can follow\nher or ignore her and go shopping in\nthe city.\n\nType continue to continue the story");
        currentState = States.MateFrogPond;
    }

    private void FirstChoice()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Type frog to follow the frog.\nType city to go shopping");
        currentState = States.Choice1;
    }

    private void WeirdHouse()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Following the female frog leads you to a spooky house. You hop inside, but\nit's a trap!\n\nType continue to see if you survived");
        currentState = States.WeirdHouse;
    }

    private void TheCity()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You decided to head to the city for\nsome shopping. After all, nothing beatsretail therapy—even for a laid-back\nfrog like you.\n\nType continue to indulge your shopping spree");
        currentState = States.TheCity;
    }

    private void JewelleryStore()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You hop into the jewelry store, though it's a mystery how you can even afford\nanything. Two items catch your eye: a\nglowing necklace with an otherwordly\naura and a sleek, stylish watch.\n\nType continue to make your choice");
        currentState = States.JewelleryStore;
    }

    private void SecondChoice()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Type necklace to buy the necklace.\nType watch to buy the watch.");
        currentState = States.Choice2;
    }

    private void BoughtNecklace()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You bought the necklace. You were so\nproud of it that you decided to show itoff to your frog-mates back in your\nhome pond! While showing off, you fell to the floor and your eyes went black.\n\nType continue to find out what happened");
        currentState = States.BackAtPond;
    }

    private void BoughtWatch()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You bought the watch, feeling pretty\npleased with yourself. As a laid-back\nfrog, you head to the park to unwind.\nBut as you're chilling, something\ncatches your eye in the distance.\n\nType continue to discover what it is.");
        currentState = States.InThePark;
    }

    private void Hospital()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You wake up in the hospital. The doctortells you that the necklace you bought\nwas corrupted. Unfortunately, there is\nno saving you and the doctor tells you it's best he puts you down.\n\nType continue to die");
        currentState = States.Hospital;
    }

    private void ParkPond()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You spot a beautiful frog pond and,\nwithout thinking, leap right in.\nSuddenly, everyone around you starts\nscreaming with anger. The female frog\nfrom earlier has had enough of your\nlaziness and is out for blood. Now, shewants to kill you! Will you fight back\nor ignore her?\n\nType continue to make your choice");
        currentState= States.ParkPond;
    }

    private void ThirdChoice()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Type fight to fight back.\nType ignore to ignore her.");
        currentState = States.Choice3;
    }

    private void IgnoreTheBoss()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You chose to ignore her, which only\nfuels her rage. In a furious leap, she lunges at you and stabs you in the\nback. Your vision blurs. Will you\nsurvive this attack?\n\nType continue to find out");
        currentState = States.IgnoreTheBoss;
    }

    private void DefeatTheBoss()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You unexpectedly fight back, catching\nher completely off-guard. With her\ndefense down, you defeat her\neffortlessly. The crowd is shocked, buttheir disdain for you remains. You\nwon... but did you really?\n\nType continue to end your story");
        currentState = States.DefeatTheBoss;
    }

    private void Death1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("The female frog has lured you into a\ntrap and you have died. You can try\nagain though!\n\nType restart to restart the story");
        currentState = States.Death1;
    }

    private void Death2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("The doctor has put you down and you\nhave died. You can try again though!\n\nType restart to restart the story");
        currentState = States.Death2;
    }

    private void Death3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("She has killed you, I mean you did\ndeserve it to be fair. You can try\nagain though!\n\nType restart to restart the story");
        currentState = States.Death3;
    }

    private void WinGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You have won! While this is the only\ngood ending, there are multiple\ndecisions in this game that you can\nexplore.\n\nType restart to restart the story");
        currentState = States.Victory;
    }
}

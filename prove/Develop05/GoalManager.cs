using System;
using System.IO.Enumeration;
using System.Collections.Generic;
using System.IO;
using System.Net;

public class GoalManager
{
    private List<Goal> _goal = new List<Goal>(); // String is temperaray it will be fild with the Goal class later

    public int _score = 0;

    public GoalManager(){}

    public void Start(){// The main code were it runs the program
        DisplayPlayerInfo();
    }

    private void DisplayPlayerInfo(){

        Console.WriteLine($"You have {_score} points!");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Events");
        Console.WriteLine("    6. Quit");
        int respons = IntUserRespons("Select a number from the options: ");

        if (respons == 1){
            CreateGoal();
        }
        else if (respons == 2){
            ListGoalDeatails();
        }
        else if (respons == 3){
            SaveGoal();
        }
        else if (respons == 5){
            RecordEvent();
        }
    }

    private int IntUserRespons(string text = ""){
        Console.Write(text);
        string response = Console.ReadLine();
        int numberResponse = int.Parse(response);

        return numberResponse;
    }

    private string StringUserRespons(string text = ""){
        Console.Write(text);
        string response = Console.ReadLine();
        return response;
    }

    private void ListGoalNames(){// One funtion will use this, the RecordEvent use this to display the goals. //This funtion Diaplsys the names of all the Goals in _goal
        int I = 1;
        foreach (Goal item in _goal){
            Console.WriteLine($"    {I}. {item.GetStringName()}");
            I = I + 1;
        } 
    }
    private void ListGoalDeatails(){
        Console.Clear();
        Console.WriteLine("List of Goals: ");

        int I = 1;
        foreach (Goal item in _goal){
            Console.WriteLine($"    {I}. {BoxString(item.IsComplete())} {item.GetDetailsString()}");
            I = I + 1;
        }
    }

    private string BoxString(bool box){
        if (box == true){
            return "[X]";
        }
        else{
            return "[ ]";
        }
    }

    private void CreateGoal(){

        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        int response = IntUserRespons("Witch type of goal would you like to creat? ");
        Console.Clear();

        if (response == 1){
            
            SimpleGoal simpleGoal = new SimpleGoal(
                StringUserRespons("What is the name of your goal? "), 
                StringUserRespons("What is a short description of it? "), 
                IntUserRespons("What is the amount of points associated with this goal? ")
                );
            _goal.Add(simpleGoal);
        }

        else if (response == 2){
            EternalGoal eternalGoal = new EternalGoal(
                StringUserRespons("What is the name of your goal? "), 
                StringUserRespons("What is a short description of it? "), 
                IntUserRespons("What is the amount of points associated with this goal? ")
                );
            _goal.Add(eternalGoal);
        }

        else if (response == 3){
            CheckListGoal checkListGoal = new CheckListGoal(
                StringUserRespons("What is the name of your goal? "), 
                StringUserRespons("What is a short description of it? "), 
                IntUserRespons("What is the amount of points associated with this goal? "),
                IntUserRespons("How many times does this goal need to be accomplished for a bonus? "),
                IntUserRespons("What is the bonus for accomplishing it that maney times? ")
                );
            _goal.Add(checkListGoal);
        }
    }

    // private void DeleteGoal(){} // This one is optionale it gose past core reqerments

    private void RecordEvent(){ // This funtion chages the property of a goal, marking them if they are done.
        Console.Clear();
        Console.WriteLine("List of Goals: ");
        ListGoalNames();
        _score  = _score + _goal[IntUserRespons("Witch goal did you acomplish? ") - 1].RecordEvent(); // first ask user for a number then chage that item that was givin - 1 then chage the _score by whater the item returns
    }

    private void SaveGoal(){
            
            string fileName = StringUserRespons("What is the name of the file? ")
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Goal item in _goal)
                {
                    outputFile.WriteLine(item.GetStringRepresentation());

                }
                Console.WriteLine("made file we thinks");
            }
    } // Save and Load from file.
    private void LoadGoal(){}

}
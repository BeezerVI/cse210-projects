// Made this cool leveling system so the player can level up every 500 points!

using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goal = new List<Goal>(); // String is temperaray it will be fild with the Goal class later

    public int _score = 0;
    public int _level = 0;

    public GoalManager(){}

    public bool DisplayPlayerInfo(){
        CheckLevel();
        Console.WriteLine($"You are level {_level}! (every 500 points you level up)");
        Console.WriteLine($"You have {_score} points!");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Events");
        Console.WriteLine("    6. Quit");
        int respons = IntUserResponse("Select a number from the options: ");
        if (respons == 6){
            return false;
        }
        else{
            if (respons == 1){
                CreateGoal();
            }
            else if (respons == 2){
                ListGoalDeatails();
            }
            else if (respons == 3){
                SaveGoal();
            }
            else if (respons == 4){
                LoadGoal();
            }
            else if (respons == 5){
                RecordEvent();
            }
            return true;
        }
    }

    private void CheckLevel()
    {
        if (_level * 500 <= _score)
        {
            int trueLevel = _score / 500;
            if (trueLevel > _level)
            {
                _level = trueLevel;
                Console.WriteLine("");
                Console.WriteLine("---YOU JUST LEVELED UP!---");
                Console.WriteLine($"You are now level {_level}");
                Console.WriteLine("-----------------------");
            }
        }
    }
    private int IntUserResponse(string text = ""){
        Console.Write(text);
        string response = Console.ReadLine();
        int numberResponse = int.Parse(response);

        return numberResponse;
    }

    private string StringUserResponse(string text = ""){
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
        int response = IntUserResponse("Witch type of goal would you like to creat? ");
        Console.Clear();

        if (response == 1){
            
            SimpleGoal simpleGoal = new SimpleGoal(
                StringUserResponse("What is the name of your goal? "), 
                StringUserResponse("What is a short description of it? "), 
                IntUserResponse("What is the amount of points associated with this goal? ")
                );
            _goal.Add(simpleGoal);
        }

        else if (response == 2){
            EternalGoal eternalGoal = new EternalGoal(
                StringUserResponse("What is the name of your goal? "), 
                StringUserResponse("What is a short description of it? "), 
                IntUserResponse("What is the amount of points associated with this goal? ")
                );
            _goal.Add(eternalGoal);
        }

        else if (response == 3){
            CheckListGoal checkListGoal = new CheckListGoal(
                StringUserResponse("What is the name of your goal? "), 
                StringUserResponse("What is a short description of it? "), 
                IntUserResponse("What is the amount of points associated with this goal? "),
                IntUserResponse("How many times does this goal need to be accomplished for a bonus? "),
                IntUserResponse("What is the bonus for accomplishing it that maney times? ")
                );
            _goal.Add(checkListGoal);
        }
    }

    // private void DeleteGoal(){} // This one is optionale it gose past core reqerments

    private void RecordEvent(){ // This funtion chages the property of a goal, marking them if they are done.
        Console.Clear();
        Console.WriteLine("List of Goals: ");
        ListGoalNames();
        _score  = _score + _goal[IntUserResponse("Witch goal did you acomplish? ") - 1].RecordEvent(); // first ask user for a number then chage that item that was givin - 1 then chage the _score by whater the item returns
    }

    private void SaveGoal()
    {
        string fileName = StringUserResponse("What is the name of the file? ");
        
        try
        {
            // Ensure the filename is valid and ends with a .txt extension (optional)
            if (!fileName.EndsWith(".txt"))
            {
                fileName += ".txt";
            }

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"{_score}~~{_level}");
                foreach (Goal item in _goal)
                {
                    outputFile.WriteLine(item.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("Error: Unauthorized access. Please check your permissions.");
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine("Error: Directory not found. Please check the path and try again.");
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("Error: An I/O error occurred while writing the file.");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine(e.Message);
        }
    }


    private void LoadGoal(){
            string fileName = StringUserResponse("What is the name of the file? ");
            string[] lines = System.IO.File.ReadAllLines(fileName);
            bool firstLineDone = false;
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");

                if (firstLineDone == false){
                    _score = _score + int.Parse(parts[0]);
                    _level = _level + int.Parse(parts[1]);
                    firstLineDone = true;
                }
                else {
                    if (parts[0] == "SimpleGoal"){
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                            _goal.Add(simpleGoal);
                        }
                        if (parts[0] == "EternalGoal"){
                            EternalGoal simpleGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            _goal.Add(simpleGoal);
                        }
                        if (parts[0] == "CheckListGoal"){
                            CheckListGoal simpleGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), bool.Parse(parts[6]), int.Parse(parts[7]));
                            _goal.Add(simpleGoal);
                        }
                        else{
                            Console.WriteLine("skiping");
                    }
                }
            }
            Console.WriteLine("Finshed wrighting from file try display");
    }

}
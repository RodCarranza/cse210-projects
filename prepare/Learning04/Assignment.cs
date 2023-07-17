using System;

public class Assignment //Base class
{
    private string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;

    }

    //Getters
    public string GetSummary() {
        return _studentName + " - " + _topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }







}
﻿
using cSharpTutorials;

{ 
    //Pipelining pl = new Pipelining();

    //pl.PipelineWork();

    LinqPractice lp = new LinqPractice();

    lp.DoSomeLinqPractice();


    //File path
    string json = File.ReadAllText(@"D:\Software Engineering\Repos");

    Console.WriteLine("Deserialised Data:");

};

// 1 - Static class to hold your methods, usually called 'Extensions'

// 2 - Make sure all methods are static

// 3 - 1st parameter of all methods is preceded by 'this'

// 4 - Return type matches type of 1st parameter

//
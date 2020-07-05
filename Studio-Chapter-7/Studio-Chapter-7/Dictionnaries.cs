using System;
using System.Collections.Generic;
using System.Text;

namespace StudioNS
{
    public class Dictionnaries
    {
        //multiple choice questions and potential answers
        public static Dictionary<string, List<string>> mcQuestions = new Dictionary<string, List<string>>
        { {"Which of the following is NOT a true statement about data-binding?", new List<string> {"In one-way binding, user input does not affect component data.","In one-way binding, information flows in one direction only.", "In one-way binding, changing a component variable never updates the application view.", "Data-binding refers to the linking of component information to a view." } },
        {"To include dynamic styles in a component:", new List<string>{"Only data-binding is needed", "Only an event handler is needed",  "Angular, data-binding, and event handling are all necessary", "Data-binding and event handling are both necessary" } },
        { "Which of the following shows the three Angular directives arranged from the most \n   general to most specific?", new List<string>{"Structural directives, attribute directives, components", "Components, attribute directives, structural directives", "Structural directives, components, attribute directives", "Components, structural directives, attribute directives", "Attribute directives, components, structural directives", "Attribute directives, structural directives, components" } },
        {"For the same code sample shown in the previous question, which of the following \n   shows the correct syntax for the *ngIf statement?", new List<string>{"* ngIf = 'prepWork.length === 0; else #noHW'", "* ngIf = 'prepWork.length === 0; else noHW'", "* ngIf = 'prepWork.length !== 0; else #noHW'", "* ngIf = 'prepWork.length !== 0; else noHW'" } },
        { "Where would be the BEST place to modify our code if we want a different font for any \n   <p> text within a template?", new List<string>{"app.component.css", "app.component.ts", "app.component.html", "app.module.ts" } } };

        //checkbox questions and potential answers
        public static Dictionary<string, List<string>> cbQuestions = new Dictionary<string, List<string>>
        { { "Which of the following show proper data-binding syntax? Choose ALL that apply.", new List<string>{"<button value='[variableName]'>Go!</button> ","<p>[variableName]</p> ", "<li>{{ variableName }}</li> ", "<button [name]='{{ variableName }}'/> ", "<img [src]='variableName'/>", "<input placeholder='{{ variableName }},/> " } },
        {"Where could we place the<app-inside-task-list></app-inside-task-list> element to \n   make 'inside-task-list works!' appear on the screen?", new List<string>{"Place the element in task-list.component.html.", "Place the element in index.html.", "Place the element in app.component.html.", "Place the element in inner-task-list.component.html." } } };
        
        //true/false questions and potential answers
        public static Dictionary<string, List<string>> tfQuestions = new Dictionary<string, List<string>>
        { { "Changing the CSS for the template affects all of the smaller parts within that \n   template?", new List<string>{"true", "false" } },
        { "Changing the CSS for one component in a template affects all of the other parts \n   within that template?", new List<string>{"true", "false" } },
        { "'app.component.html' would be the BEST place to modify our code if we want to add a \n   heading and an unordered list to the template?", new List<string>{"true", "false" } },
        { "We define a new HTML tag in ", new List<string>{"true", "false" } } };

        //multiple choice; index of correct answers
        public static List<int> mcCorrects = new List<int> { 3, 4, 4, 4, 1 };

        //checkbox; index of correct answers
        public static List<List<int>> cbCorrects = new List<List<int>> { new List<int> { 3, 5, 6 }, new List<int> { 1, 3 } };

        //true/false; index of correct answers
        public static List<int> tfCorrects = new List<int> { 1, 2, 1, 2 };
    }
}


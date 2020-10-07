using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents; // List, a reference type
        public string Santa { get; set; } // string, reference type
        public int? TreeHeight { get; set; }  //TODO Make the Height property nullable 
        // is of type int, a value type.

        //TODO Make the property, "Day", type enum
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        // A enumerated list of days of the week, under the 'Day', type enumerated list.
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Videodetail.Models
{
    /*public class Object
    {
    }*/

// The Point class is derived from System.Object.
            class Point
                {
                    public int x, y;        

                    public Point(int x, int y)          //here we are using the key value pair.
        {
                        this.x = x;
                        this.y = y;
                    }

                    public override bool Equals(object obj)
                    {
                        // If this and obj do not refer to the same type, then they are not equal.
                        if (obj.GetType() != this.GetType()) return false;

                        // Return true if  x and y fields match.
                        var other = (Point)obj;
                        return (this.x == other.x) && (this.y == other.y);
                    }

                    // Return the XOR of the x and y fields.
                    public override int GetHashCode()
                    {
                        return x ^ y;
                    }

                    // Return the point's value as a string.
                    public override String ToString()
                    {
                        return $"({x}, {y})";
                    }

                    // Return a copy of this point object by making a simple field copy.
                    public Point Copy()
                    {
                        return (Point)this.MemberwiseClone();
                    }
                }

                public sealed class App
                {
                    static void Main()
                    {
                        // Construct a Point object.
                        var p1 = new Point(1, 2);

                        // Make another Point object that is a copy of the first.
                        var p2 = p1.Copy();

                        // Make another variable that references the first Point object.
                        var p3 = p1;

                        // The line below displays false because p1 and p2 refer to two different objects.
                        Console.WriteLine(Object.ReferenceEquals(p1, p2));

                        // The line below displays true because p1 and p2 refer to two different objects that have the same value.
                        Console.WriteLine(Object.Equals(p1, p2));

                        // The line below displays true because p1 and p3 refer to one object.
                        Console.WriteLine(Object.ReferenceEquals(p1, p3));

                        // The line below displays: p1's value is: (1, 2)
                        Console.WriteLine($"p1's value is: {p1.ToString()}");
                    }
                }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorApp.models
{
    internal class Person
    {

        private double DEFAULT_WEIGHT = 50;
        private float DEFAULT_HEIGHT = 1.524f;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public float Height { get; set; }

        public double Weight { get; set; }



        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Weight = DEFAULT_WEIGHT;
            Height = (float)DEFAULT_HEIGHT;
        }

        public Person(int _id, string _name, int _age, float _height, double _weight) : this(_id, _name, _age)
        {
            Height = _height;
            Weight = _weight;

        }

        public double CalculateBmiScore()
        {
            double bmiScore = (Weight) / (Height * Height);
            return bmiScore;
        }

        public static string BodyType(double bmiScore)
        {
            if (bmiScore < 18.50)
            {
                return ("You are Underweight");
            }
            else if (bmiScore >= 18.5 && bmiScore <= 24.9)
            {
                return ("You are Healthy");
            }
            else if (bmiScore >= 25 && bmiScore <= 29.9)
            {
                return ("You are Overweight");
            }
            else
            {
                return ("You are Obese");
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"BMI Score: {CalculateBmiScore():F2}\n";
                
        }





    }
}

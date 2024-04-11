using System;
using System.Collections.Generic;

namespace MyFirstProgram{
    class Program{

        static void  DisplayArray<T>(T[] array){
            foreach(T t in array){
                Console.WriteLine(t);
            }
        }

        static void DisplayValues(){
            for(int i=0;i<10;i++){
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            // Console.Write("Bye Bye");
            // Console.WriteLine("Hello World!!!!");
            // int a = 4;
            // float g = 2.4F;
            // string r = "Hello";
            // double j = 4.5;
            // bool q = false;
            // char s = '@';
            // //Constant
            // const double PI = 3.14;
            // int integer = Convert.ToInt32(PI);
            // Console.WriteLine(Convert.ToInt16("1"));
            // Console.WriteLine(Convert.ToBoolean("true"));
            // Console.WriteLine(integer);
            // Console.WriteLine(integer.GetType());
            // Console.WriteLine("a= "+a);
            // Console.WriteLine("g= "+g);
            // Console.WriteLine("r= "+r);
            // Console.WriteLine("j= "+j);
            // Console.WriteLine("q= "+q);
            // Console.WriteLine("s= "+s);
            // Console.WriteLine("What is Your Name");
            // double n = Math.Pow(2,3);
            // Console.WriteLine(n);
            // String? name = Console.ReadLine();
            // Random rn = new Random();
            // System.Console.WriteLine(rn.Next(1,7));
            // Console.WriteLine(rn.NextDouble());
            // Console.WriteLine("Hello "+name);
            // Console.WriteLine("Please Enter the First Side");
            // double side1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Please Enter the Second Side");
            // double side2 = Convert.ToDouble(Console.ReadLine());
            // double hyp = Math.Sqrt(Math.Pow(side1,2)+Math.Pow(side2,2));
            // Console.WriteLine("The Hypotnuse of the Triangle is "+hyp);
            // const String name = "Dawit Hailu";
            // Console.WriteLine(name.ToUpper());
            // Console.WriteLine(name.ToLower());
            // Console.WriteLine(name.Replace(' ','-'));
            // Console.WriteLine(name.Length);
            // name.Substring(0,4);
            // bool playAgain = true;
            // Random rn = new();
            // while(playAgain){
            //     int val = rn.Next(1,11);
            //     string chosen = "";
            //     while(chosen==""||chosen!=Convert.ToString(val)){
            //         Console.WriteLine("Please Guess Value");
            //         chosen = Console.ReadLine();
            //         if(Convert.ToInt16(chosen)>val){
            //             Console.WriteLine("To High");
            //         }
            //         else if(Convert.ToInt16(chosen)<val){
            //             Console.WriteLine("To Low");
            //         }
            //         else{
            //             Console.WriteLine("Congratulation You Got it. The Number was "+val);
            //         }
            //     }
            //     Console.WriteLine("Would You Like To Play Again? Press Y to play again, any other game to quit");
            //     Char? answer = Console.ReadLine()?.ToLower().ElementAt(0);
            //     playAgain = answer switch
            //     {
            //         'y' => true,
            //         _ => false,
            //     };
            // }
            // bool playAgain = true;
            // Random rn = new();
            // while(playAgain){
            // string[] choices = ["ROCK","PAPER","SCISSOR"];
            // Console.WriteLine("Please Choose ROCK,PAPER,SCISSOR");
            // String input = Console.ReadLine().ToUpper();
            // while(input!="ROCK"&&input!="PAPER"&&input!="SCISSOR"){
            //     Console.WriteLine("Please Choose one of [ROCK,PAPER,SCISSOR]");
            //     input = Console.ReadLine().ToUpper();
            // } 
            // String computer = choices[rn.Next(0,3)];
            // Console.WriteLine("Player: "+input);
            // Console.WriteLine("Computer: "+computer);
            // if(computer==input){
            //     Console.WriteLine("Result: It is Draw");
            // }
            // else{
            // switch(input){
            //     case "ROCK":
            //         if(computer=="SCISSOR"){
            //             Console.WriteLine("You Win");
            //         }
            //         else{
            //             Console.WriteLine("You Lose");
            //         }
            //         break;
            //     case "PAPER":
            //         if(computer=="SCISSOR"){
            //             Console.WriteLine("You Lose");
            //         }
            //         else{
            //             Console.WriteLine("You Win");
            //         }
            //         break;
            //     case "SCISSOR":
            //         if(computer=="PAPER"){
            //             Console.WriteLine("You Win");
            //         }
            //         else{
            //             Console.WriteLine("You Lose");
            //         }
            //         break;
            // }
            // }
            // Console.WriteLine("Would you like to play again? y for yes, any other key for No");
            // char answer = Convert.ToChar(Console.ReadLine().ToLower().ElementAt(0));
            // playAgain = answer switch{
            //     'y'=>true,
            //     _ =>false
            // };
            // }
            // string[] choices = ["ROCK","PAPER","SCISSOR"];
            // foreach(string ch in choices){
            //     System.Console.WriteLine(ch);
            // }
            // for(int i=0;i<choices.Length;i++){
            //     System.Console.WriteLine(choices[i]);
            // }
            // String[] cars = new string[5];
            // cars[0] = "Nissan";
            // Console.WriteLine(cars[0]);
            // try{
            //     int d = 0;
            //     int s = 9/d;
            // }
            // catch(ArithmeticException e){
            //     Console.WriteLine(e.Message);
            // }
            // catch(NullReferenceException e){
            //     Console.WriteLine("JNJJN");
            // }
            // finally{
            //     Console.WriteLine(args[1]);
            //     Console.WriteLine("This is the last message");
            // }
            // int temprature = 35;
            // string message = temprature<35?"It is cold outside":"it is warm outside";
            // System.Console.WriteLine(message);
            // string name = "Dave";
            // String msg = $"Hello {name}, How are you?";
            // Console.WriteLine(msg);
            // string fullName = "daveChappel";
            // int age = 21;
            // Console.WriteLine($"Hello {fullName}, are you {age,-4} years old?");
            //MultiDimension Arrays
            // String[,] cars = {{"Ford","Fusion"},{"Ferrari","Lamborghini"},{"Toyota","Audi"}};
            // int[,] numbers = new int[5,5];
            // foreach(String e in cars){
            //     Console.WriteLine(e);
            // }
            // Variable.Hello();
            // Vehicle car = new Car();

            // car.go();
            // List<String> listString = [];
            // listString.Add("Abebe");
            // listString.Find(s=>s=="Abebe");
            // foreach(String s in listString){
            //     Console.WriteLine(s);
            // }
            // Car car = new(200)
            // {
            //     Speed = 200
            // };
            // Console.WriteLine(PLANET.Mercury+" is a planet");
            // Console.WriteLine(PLANET.Mercury+" is a planet "+(int)PLANET.Mercury);
            // DisplayArray(["A","B","C","D"]);
            // DisplayArray([1,2,3,4]);
            Thread thread1 = new(DisplayValues);
            Thread thread2 = new(DisplayValues);
            thread1.Start();
            thread2.Start();
            Console.WriteLine("Main Thread Completed");
        }
    }


// abstract mean it can not be instantiated

interface ISpeed{
    public void Turbo();
}


 class Vehicle{
        protected int numberOfWheels;

        public virtual void Go(){
            Console.WriteLine("The Vehicle is going");
        }
    }

    class Car<T>:Vehicle,ISpeed{
        int speed;

        //Auto implemented Getter and Setter
        public String Model{get;set;}
        public Car(int speed){
            Speed = speed;
        }

        public int Speed{
            get{
                return this.speed;
            }
            set{
                if(value<200){
                    speed = value;
                }
            }
        }
        public override void Go(){
            Console.WriteLine("The Car is going");
        }
        public void Turbo(){
            Console.WriteLine("This is turbo boost");
        }
    }

    //Enums can also be types in functions
    enum PLANET{
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Neptune,
        Pluto
    }
}

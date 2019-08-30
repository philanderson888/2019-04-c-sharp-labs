Visual Basic : came first : no longer official supported
Overload : same name different parameters
Override : Virtual in parent, override in child
Override : same name different code implementation
Polymorphism : Different implementations at runtime
Abstract class and Method
Testing : 3 types
    MSTest : native Visual Studio
    NUnit  : **
    XUnit : latest
Polymorphism 
    BaseParent : virtual DoThis(){}
    DerivedChild : override DoThis(){}
4 Pillars Of Object Oriented Code

    Abstraction   : code is hidden behind (encpsulated) but user can interact with it using
                    PUBLIC PROPERTIES  

        Both encapsulate (hide) key code but also reveal or expose desired 'Properties'
        Properties ==> {get;set;}  ==> allows public access

            CAR : engine inner workings are encapsulated (hidden)
                  steering, clutch, accelerator are PUBLIC PROPERTIES ACCESSIBLY BY END USER


    Encapsulation  

        hide code which does not need to be revealed to outside world

            CAR ENGINE : deep inner workings hidden from general user

            CODE : private keyword for this

                4 options with keywords are called 'ACCESS MODIFIERS'

                ACCESS MODIFIERS 
                    private         encapsulates (hides) code from outside
                                    access : code ONLY IN THIS CLASS ONLY!!!
                    public          accessible from any code
                    protected       access : from code in THIS CLASS AND ALL DERIVED CHILD
                                                                 CLASSES ALSO
                    internal        access : from any code inside the compiled .exe or .dll
                                    file which is produced for this project ('Assembly')

    Polymorphism : poly = many, morph = type: polymorphism : can have one 'master' instruction but in the child classes, each child (derived) class may have its own implementation

            FAMILY : PARENT : Each child has own idea of how to throw a party!

    Inheritance

        Parent (Base) Class

            Child (Derived) Class

constructor

Access Modifiers

    private : this class
    public : any class
    protected : can see from this class and all child derived classes 
    internal : can see from any code inside final compiled 'exe' or
                'dll' ASSEMBLY
    protected internal = protected plus internal scope

int
int16  short
int32  int
int64  long
uint32 unsigned

4 pillars of OOP
    encapsulation : hiding private code
    polymorphism : unique ways to override parent code in child class
    inheritance : fields from parent also in child
    abstraction : hiding (encapsulation) private fields         hidden engine
                  exposing               public PROPERTIES      revealed clutch, accelerator


? Code run 'line by line' in order from top to bottom
Compiled code ==> create (build) .exe (.dll) then run it
Interpreted code : Powershell with individual lines run one by one, in turn
    CMD old fashioned command line
    BASH linux
    POWERSHELL
    ZSH advanced linux
What is OOP?  Object Oriented
    Old computers : program start line 1 and run to end
    GUI : screen objects eg button, list, label also internal objects from database like
        array, dictionary.
    OOP ==> attach code to OBJECTS EG button_click() method  hover()...  
        array.sort()
    Code is called as required : EVENTS initiate the process (eg button click)

    Object {}
        int inherits from object

High Level : Slower to run on computer because there's lots of extra code in there
             to make it easier for human to understand!
    CIL : intermediate 
Low Level  : raw syntax/commands sent directly into computer for processing
    ASSEMBLY LANGUAGE

High level : Java, C#, Python, Javascript
Low level : Assembly language

Agile : build incrementally from simple to more complex
    Goal : each increment is unit of 'WORKING CODE' which adds value to customer
    Good for real world where requirements can change in 3 months
    Can be hard to control 'big picture' and costs
        SPRINTS : focused blocks of work
        LIST OF REQUIREMENTS : BACKLOG
            SPRINT : SPRINT BACKLOG : mini-list for just this sprint

Waterfall : traditional : ANALYSE DESIGN BUILD TEST IMPLEMENT in order
    Not good for flexible projects 

SQL
Order by
Select distinct
... as ...
LIKE
LIKE '%a'    ends a
LIKE 'a%'    starts a
LIKE '%a%'   contains a
IN(a,b)   both a and b
count(field)
sum
avg
min/max
between
substring(string,startIndex,numCharacters)
charIndex('char',string)          ('a','abc') ==> 1
                                  ('b','abc') ==> 2
LTRIM
RTRIM
null
is null
is not null
field1 + field2 as title
LEN(string)
UPPER
LOWER
REPLACE(string,remove,insert)    ('abc','a','z')  => zbc
[Order Details]
% operator   :  modulus : remainder
100/8   (integer) ==> 12
100%8                 4
    100 is  8 x 12   +   4



readonly double Constant01 = 2.45793;

Struct : mini class with fully public fields

STACK : FAST : int, bool,char and STRUCT!!!!
HEAP  : SLOWER : classes, collection, array, strings

Sealed class

Overload  :  Methods have SAME NAME with DIFFERENT PARAMETERS
                DoThis(int x)
                DoThis(string y)

Override  :  Base Parent class has a method with code; Child derived class
                has same method with different code

ref    pass in integer into method; stays global in that method

Dictionary<int,string>()    int = index (unique)

   foreach(var (key,value) in mydict.keys){}

### Interface

3 levels of class inheritance

    1.   Regular class   Parent ==> Child

            Polymorphism works here  

                        virtual in Parent .... override in Child

                        class Parent{
                            virtual void DoThis(){}
                        }
                        class Child:Parent{
                            override void DoThis(){}
                        }

    2.   Abstract class  Parent ==> Child

            Abstract parent has to have a child class.

                    abstract class Parent{
                        abstract void DoThis();
                        void AlsoDoThis(){} // ok
                        void AndThis(){} // ok
                    }

                    class Child:Parent{
                        override void DoThis(){}  // code 
                    }


            Note that abstract classes must have at least one abstract method but may
            contain any number of regular methods.


    3.   Interfaces

        Problem with classes is that we can only inherit from 1 class

            Think natural family : you can only belong to one family 

        Interface is a structure that allows us to 'use' code from more than one place

            Think garden shed : tools which we can 'implement' or 'use'

            Class ==> Inherit           ONE
            Interface ==> Implement     MANY 

        interface IUseThisTool01{
            // no fields
            // yes properties
            int number01{get;set}    // ASSUMED PUBLIC 
            // yes methods
            void DoThis(){}          // ASSUMED PUBLIC
        }

        class MyClass : IUseThisTool01{
            public int number01{get;set;}
            public void DoThis(){}  
        }
                    


Class 

    Picture : Class is like the architectural blueprint which an architect creates
        as a plan for a building.  It's not a building but a builder can turn the plan
        into a real object.

    Computing : Class is a template for creating real objects

        Class Parent{}

                            var p = new Parent();    p is real object INSTANCE created from
                                                        class template


Class : blueprint or template from which we create real objects using `new` keyword (this is called instantiation)

    Class : template
    new   : instantiate real object







4 Pillars Of OOP

    Encapsulation : Hiding private fields/methods
    Abstraction : Hide private fields and Reveal public properties
    Inheritance : Base Parent => Derived Child
    Polymorphism : poly=many, morph=type
        Polymorphism allows many 'types' to exist
                Parent ==> method
                Child  ==> overide that method with its unique code

                Multiple children ==> poly (many) unique implementations




















Class



```

OOP
4 Pillars
Waterfall
Agile
Scrum
Product Owner
Scrum Master


Dev Team


Kanban : think non-stop factory : production never ceases.  

        backlog(todo)   selected    in development    for review     done


                                    max 5 items


    Kanban : from Toyota : 'just-in-time' model where want to deliver items on time continuously - get the 'flow' right.  At any one time we LIMIT AMOUNT OF ITEMS
    WE ARE WORKING ON.  Think bath plug - water leaves better if you limit amount of 'stuff' trying to escape the plughole


Scrum : start-stop : discrete stages 'iterations' of a product

Kanban : continuous flow of work, limiting active items at any one time








XP Extreme Programming / Pair Programming
Sprint
SDL Software Dev Lifecycle stages

Risk is chance % possibility that something will happen * impact if it did take place
    
    20% possiblity this week my shoe laces come loose ==> no impact ....

    0.0000001 of asteroid causing damage ....


    10% chance project delayed 2 months     £10,000 penalty



Mitigation of risk

    Ways to reduce risk

        Avoid...do something else
        Insure (Transfer)
        Do nothing (Accept)
        Mitigate (spend money to reduce risk)  ((think potholes on roads))


Abstract class
Virtual keyword
Override keyword
Overload

### .Base() in method

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_64_base
{
    class Program
    {
        static void Main(string[] args)
        {
            // parent : dothis
            var p1 = new Parent();
            p1.DoThis();
            // child : dothis
            var c1 = new Child();
            c1.DoThis();
        }
    }


    class Parent {
        public virtual void DoThis() {
            Console.WriteLine("I'm in the parent");
        }
    }
    class Child : Parent {
        public override void DoThis()
        {
            base.DoThis();
            Console.WriteLine("I'm in the child");
        }
    }
}


```


### base keyword in Constructor

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_64_base
{
    class Program
    {
        static void Main(string[] args)
        {
            // parent : dothis
            var p1 = new Parent();
            p1.DoThis();
            // child : dothis
            var c1 = new Child();
            c1.DoThis();
        }
    }


    class Parent {
        public virtual void DoThis() {
            Console.WriteLine("I'm in the parent");
        }
    }
    class Child : Parent {
        public override void DoThis()
        {
            base.DoThis();
            Console.WriteLine("I'm in the child");
        }
    }
}

```














### Review

checked : throws an exception if your number gets too big or small

    unchecked : turns off again (default)

dynamic : turns off type checking at compile time

    dynamic x = 10;  // int
    x = true;        // bool

    ((Note : Javascript does this by default))

Dynamic language : loose checking of types : even at runtime the type can possibly change as is the case with Javascript and also C# with 'dynamic' keyword.

Statically typed / strongly typed language : types are strictly defined at compile time.

    var keyword : type is still strictly inferred at compile time

Javascript - loose type checking

    Typescript - plug-in to Javascript where types are more strictly controlled

    using strict;  is Javascript in 'strict' mode also prevents switching type

    var x = 10;







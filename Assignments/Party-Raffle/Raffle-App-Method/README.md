# Raffle(Method Version)

You are hosting a party and want to give a lucky guest a prize before the party is over. You ask your friend Roger to help you create a console app to do that.

**_The app should allow you to collect everyone name and give each person a numbered ticket (4 digits)._**

***
1. Fork this repo
1. Clone it on you local machine in the folder you want it.
2. Once you finish with your assignment, push it to GitHub and submit the link in Canvas, so your TA can have it.

***
4. This will be a great time to continue using git/GitHub. You will work on 7 methods for this exercise. You can create branches as you code along and name them after your method:  _**This is an example: (This is optional)**_

     
    * ``` git checkout -b getUserInput-method ```. This will create the branch **getUserInput-method.**
    * ``` git merge main ``` Before working in a new branch always merge master to make sure that you are not missing any changes in master. You work on your branch, write your code, and once you are done:
    * ``` git status ``` check the status of the branch that you are currently working.
    * ``` git add -A ``` add the change in your staging area.
    * ``` git commit -m "finished working with GetUserInput-method" ``` commit your work in your local repo.
    * ``` git checkout main ``` switch back to main.
    * ``` git merge GetUserInput-method ``` merge everything you work  in GetUserInput-method to master.
    * ``` git push -u origin GetUserInput-method ``` push the branch to your remote repo
    * Although it is not recommended to do your own pull request since you are working solo, you can go ahead and do it. Do pull request on GitHub and merge the changes in the main branch.
    * Now go back to the terminal and switch to main ``` git checkout main ``` then do a pull ``` git pull ``` to get all the changes from GitHub
    * Repeat the process by changing just the name of your branch
***

### Variables
1. Declare a private static empty Dictionary<int, string> named **guests**
1. Declare and initialize a private static integer named **min** with value 1000
2. Declare and initialize a private static integer named **max** with value 9999
3. Create a private static integer named **raffleNumber**
4. Create an instance of the random class and store it a variable name **rdm** ``` private static Random _rdm = new Random();```

***
### Methods

_**You will need to create 7 methods for this assignment**_

1. Create a method that return a string and name it **GetUserInput**. This method will take a string parameter called message
    * This method should make it easier for you to get input from the user.
    * instead of using Console.WriteLine and Console.ReadLine all the time just call this method and pass the string message as an argument. This method should return the data you collect from the user, just like console.Readline return a string as output.
  
2. Create a method that returns nothing and name it **GetUserInfo().**
   1. Inside your method use a loop to ask the user to enter the name of the guest. You should call the method **GetUserInput** and store it in a variable call **name ex: ``` string name = GetUserInput("Please enter your name "); ```
   2. The loop will end when the user type "yes". use a separate variable to store the input ex: ```otherGuest = GetUserInput("Do you want to add another name? ").ToLower(); ``` Remember that you have to declare this variable outside of the loop and inside the body of your function so you can use it in the while condition ex: ```do{//....}while(otherGuest == 'yes'); ```
   3. create a 4 digits random number by calling the **GenerateRandomNumber()**(see description for this method below) and store it in the **raffleNumber** variable that you created.
   4. **Validate your input.** Keep asking for the guest's name if user enter an empty string
   5. Same thing for your random number, validate the data. You can't have the same raffleNumber. You can use a loop to keep calling **GenerateRandomNumber()** method.
   6. Add both the raffleNumber and guest name in the dictionary by calling **AddGuestsInRaffle()** method (see description below)

3. Create a method that return an integer and name it **GenerateRandomNumber().**
    * This method should take **_2 parameters int min, and int max_**, This method should return an integer number between min and max.


***

4. Create a method that returns nothing and name it **AddGuestsInRaffle().** This method should take **2 parameters int raffleNumber and string guest**
    * Add the raffleNumber and the guest name that you collect from the user and store them in the guests dictionary that you created.

5. Create a void method and name it **PrintGuestsName()**
    * Use a loop to print the name of all your guests with their assigned raffleNumber

6. Create a method and call it **GetRaffleNumber().** This method should take a Dictionary<int, string> as parameters you can call it anything, people for example.
    * This method should allow you to get a random key value from the dictionary and return it as winner number.**(I'll let you do the work here. If stuggled for more than 30 mns, ask your TA for hints)**

7. Create a void static method and name it **PrintWinner()**
    * This method should print the name of the winner and the raffleNumber
    * You should be able to call the **GetRaffleNumber().** method and store it in an int variable named winnerNumber
    * You should be able to get the winnerName once you have the winnerNumber.
    * ``` Console.WriteLine($"The Winner is: {WinnerName} with the #{winnerNumber}"); ```
***
### Main method

Please add this code in your main method once you are finished writing all your code.

```
 static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Party!!");
            GetUserInfo();
            PrintGuestsName();
            PrintWinner();
            
        }

```

***

### <ins>Important points:</ins>
* Follow DRY principles **(DO NOT REPEAT YOURSELF)** as much as possible. Call your methods when necessary
* All your methods should be private static
* When you declare any variable in class level(outside your method) and want to use it inside a static method, this varibale has to be also static

***


### Bonus
Call the **MultiLineAnimation()** method provided in the started code in your main method.



**_Thanks, Happy Coding!!!_**

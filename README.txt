Project Instruction
1	Tools used:   
        SpecFlow, RestSharp, NUnit in VS C# version 2019 

2	Test Environment setup:
    2.1 Prerequisites:
      •	Visual studio (e.g. 2019) is installed on your PC from web site  at https://visualstudio.microsoft.com/downloads/
      •	Git is installed on your PC from web site https://git-scm.com/download/win
      •	The user has GitHub account or created one following the instruction at https://docs.microsoft.com/en-us/visualstudio/version-control/git-create-github-account?view=vs-2022
    2.2 SetUp Git repository for the testing project
      •	Create a new git repository on command line 
        Go the target folder (e.g. Hometrack_API) and right click to open GitBash here
        Git init
        Git commit –m “first commit”
        Git Branch –M main
     	Git remote add origin https://github.com/{name}/folder.git (e.g)
	Git push –u origin main
	Repeat d- f to Create branch Dev
      •	If there is an existing repository, you can clone it down to your local PC folder, see this instruction at https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository

3	Test Framework setup
   3.1	Install required NuGet packages in Visual Studio
     •  Create a new testing solution/project (NUnit project) and save in the git repository folder
     •  Install below packages through Tools>NuGet Package Manager>Manage NuGet Packages for the project
	NUnit
	NUnit.ConsoleRunner
	NUnit3TestAdapter
	Specflow
	Specflow.Assitt.Dynamic
	Specflow.NUnit
	Specflow.Tools.MSBuild.Generation
        RestSharp
    3.2	Layout the BDD process required format 
     •	Create Features folder and Add a feature file in the folder
	Right Click the Project>Add new item>Specflow>Specflow Feature file and save it
     •  Feature file format 
	Background: 	   All common feature steps for all scenarios
	Scenario:   	   Single test
	Scenario outline:  Multi tests with same testing structure
     •	Create Steps folder and add steps c# code here
	Select scenarios steps >right click > Generate Step Definition>Generate and save it to Steps folder

4	Testing Code check in Git hub repository process
	Check in dev branch first
	Send review code request
	After code review
	Check it in Main branch 

5	Test run process
     	In Visual studio
      •	Build/rebuild the solution
      •	Open Test Explorer through View> Test Explorer
      •	Click Run on Text Explorer tool bar (for all tests in view)
      •	Select project/Test cases>right click >Run (for a specific test)

6	Test Scenarios
        It includes testing below scenarios only using JSON response Method
      •	Filter and remove all text in profanity lists and displayed as * by default
	case insensitive
	part of word or words
	at front , middle, and end
      •	Add new word or words as profanity text and can be filtered out and displayed as * by default
      •	Filter out the profanity text and replace by the specified word  or symbols
      •	Add and replace the profanity text in the same time
      •	Error Handling scenarios
	Empty string
	replacing word is more than 20 characters
	Added bad word is more than 10 words

Note:   It doesn’t includes testing those scenarios using XML or plain text method.




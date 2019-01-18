# Game of Life

The point of this exercise is to work WITH the interviewee, not stare over their shoulder silently. Answer any questions they have and help them through any issues (without completely solving it for them). The idea is to treat this like you are working on a real engagement.

Besides technical abilities, you should pay attention to how they solve problems and overcome obstacles.
* Do they ask you for help, Google things, struggle through them silently?
* How do they organize their thoughts, do they communicate what they are doing?

## Prep

You can use your own machine, or a prepared VM on the shared Madison Azure subscription. It is recommended to use the VM as it has all necessary tools installed with the defaults.

To use the VM:
1) Log into the Azure portal using your Centare account and look for the interview-vm virtual machine in the interview-rg resource group. Ask Steve or Kyle if you do see this resource group.
2) Start the VM. It will be deallocated.
3) RDP to centare-interview.centralus.cloudapp.azure.com using the credentials:
   username: centare
   password: !@centare12@!


## Getting started

* Before starting the exercise verify that
  1. The developer has experience with unit testing, and if they know what TDD is.
     * Also check if they put it on their resume. Is it on their resume but they are unable to write tests?
     * The exercise can still proceed without TDD experience, but pay attention to how they develop. Is it a lot of Console.WriteLines or debugging and breakpoints?
  2. They are familiar with the VS unit testing syntax as opposed to some other framework like xUnit.
     * This shouldn't be a hinderance but you may have to point out the attribute names and Assert syntax.

* Start by opening the solution and README.md file and explaining the exercise, then leave the room and give them 5-10 minutes to review the project.
  * Be sure to explain that, although they will take the lead, the purpose of this is to pair program with you.
  * Also let them know that there is no expectation that they completely finish the application, so they should take their time as needed.

* Encourage them to do TDD by asking them to start by writing a test, or, if you are interested in seeing how they approach a new problem, you may want to just ask "Where should we start?"

## Inital Help

If the interviewee is having trouble getting started:

1. Prompt them for a test they could write without working on any of the Update logic.

2. If they are still uncertain, ask them what could be tested about the constructor.
   * A null parameter to the constructor can be a good first start. This can prompt a conversation about whether they think that should throw a NullReferenceException or the Board class should allow it (e.g. return null for the Cells property).
   * or what if the parameter passed into the constructor contains a character other than "." or "*"?

3. If they are struggling with the Update method ask them if there is any behavior that would be correct even without writing any code in Update.
   * A board with only dead cells will not result in any changes after a call to Update. This gives them the chance to write a passing test without writing any implementation.


## Pitfalls

There are some issues that most developers are likely to encounter. These are good chances to see how they tackle problems

* Multi-dimensional array syntax - Multi-dimensional arrays are not something developers deal with very often and the C# syntax is a little different than other languages:
  * string[,] a; // declares a new 2-dimensional array of string, NOT string[][] a; which is an array of string arrays and works differently
  * a[1,2] // Accesses an item, not a[1][2];
  * Multi-dimensional array initializers look like this:
  ```
    var a = new[,] {
        { ".", ".", "." },
        { ".", ".", "." },
        { ".", ".", "." }
    };
  ```
  * The Length property is the total number of items in the array, so for a 2-dimensional array it is rows*columns.  Use the GetLength(int dimension) method instead when looping through rows and columns (dimension is 0 based).

* Developers might not be familiar with CollectionAssert even if they do a lot of unit testing. This will save them from having to create a lot of loops in unit tests.

* Attempting to write a test for an entire game rule (i.e. "Any live cell with fewer than two live neighbors dies") seems like a logical start, but can lead down a rabbit hole to implementing a lot of code to make the test pass. This is because much of the logic is in the counting of neighbor cells without getting an ArrayIndexOutOfBoundsException. If they go down this route encourage them to make a test with a more limited scope:
  * Doing a CollectionAssert(string[,], string[,]) includes a wide scope of scenarios. Suggest that they write a test that only checks that a single cell is updated properly. For example, does a single cell in the middle of the board update properly if the rules are satisfied just by cells in the same row?
  * How about making a method that just counts live neighbors and testing that first?
  * Try just implementing counting neighbors on a single row first. Then add counting the row above and below separately.

## Wrapping up

* Be sure to ask the interviewee what they thought about the exercise
* If they didn't complete the task what would they do next?
* Are they unhappy about anything in their code that they would change if given more time?
* What features would they add if they had more time?

## Cleaning up

1. Shut down and DEALLOCATE the VM in Azure. The VM will automatically shut down every night, but it is an expensive one so you don't want to leave it running.
2. Restore the interview-vm-sn disk snapshot to return the VM back to it's original state.

If you want to make changes to the clean VM state make sure to take a snapshot of the disk and overwrite the existing interview-vm-sn snapshot.

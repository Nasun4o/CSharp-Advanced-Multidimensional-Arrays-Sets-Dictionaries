# CSharp-Advanced-Multidimensional-Arrays-Sets-Dictionaries
Advanced CSharp

Problem 1.	Fill the Matrix
Write two programs that fill and print a matrix of size N x N. Filling a matrix in the regular pattern (top to bottom and left to right) is boring. Fill the matrix as described in both patterns below:
Pattern A	Pattern B
 	 
Problem 2.	Maximal Sum
Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns.
Print the elements of the 3 x 3 square as a matrix, along with their sum.
Input	Matrix	Output
4 5
1 5 5 2 4
2 1 4 14 3
3 7 11 2 8
4 8 12 16 4	 	Sum = 75
1 4 14
7 11 2
8 12 16

Problem 3.	Matrix shuffling
Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way like in the problem above – first you read the dimensions and then the data. Remember, you are not required to do this step first, you may add this functionality later.  
Your program should then receive commands in format: "swap row1 col1 row2c col2" where row1, row2, col1, col2 are coordinates in the matrix. In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [row1, col1] with cell [row2, col2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered. Examples:
Input	Output
2
3
1
2
3
4
5
6
swap 0 0 1 1
swap 10 9 8 7
swap 0 1 1 0
END	(after swapping 1 and 5):
5 2 3
4 1 6
Invalid input!
(after swapping 2 and 4):
5 4 3
2 1 6
1
2
Hello
World
0 0 0 1
swap 0 0 0 1
swap 0 1 0 0
END	Invalid input
World Hello
Hello World

Problem 4.	Sequence in Matrix
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Examples:
Matrix	Output		Matrix	Output
 	ha, ha, ha		 	s, s, s

Problem 5.	Collect the Coins
Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.
You receive the layout of a board from the console. Assume it will always have 4 rows which you'll get as strings, each on a separate line. Each character in the strings will represent a cell on the board. Note that the strings may be of different length.
You are the player and start at the top-left corner (that would be position [0, 0] on the board). On the fifth line of input you'll receive a string with movement commands which tell you where to go next, it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down). 
You need to keep track of two types of events – collecting coins (represented by the symbol '$', of course) and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). When all moves are over, print the amount of money collected and the number of walls hit. Example:
Input	Output	Comments
Sj0u$hbc
$87yihc87
Ewg3444
$4$$
V>>^^>>>VVV<<	Coins collected: 2
Walls hit: 2	Starting from (0, 0), move down (coin), twice right, up, up again (wall), three times right (coin on second move), twice down, down again (wall), twice to the left – game over (no more moves). Total of two coins collected and two walls hit in the process.

Problem 6.	Count Symbols
Write a program that reads some text from the console and counts the occurrences of each character in it. Print the results in alphabetical (lexicographical) order. Examples:
Input	Output
SoftUni rocks	 : 1 time/s
S: 1 time/s
U: 1 time/s
c: 1 time/s
f: 1 time/s
i: 1 time/s
k: 1 time/s
n: 1 time/s
o: 2 time/s
r: 1 time/s
s: 1 time/s
t: 1 time/s
Did you know Math.Round rounds to the nearest even integer?	 : 9 time/s
.: 1 time/s
?: 1 time/s
D: 1 time/s
M: 1 time/s
R: 1 time/s
a: 2 time/s
d: 3 time/s
e: 7 time/s
g: 1 time/s
h: 2 time/s
i: 2 time/s
k: 1 time/s
n: 6 time/s
o: 5 time/s
r: 3 time/s
s: 2 time/s
t: 5 time/s
u: 3 time/s
v: 1 time/s
w: 1 time/s
y: 1 time/s
Uvh34yt78y78y7Y&T^^DFt362t62thfwuihhYG&GY2	&: 2 time/s
2: 3 time/s
3: 2 time/s
4: 1 time/s
6: 2 time/s
7: 3 time/s
8: 2 time/s
D: 1 time/s
F: 1 time/s
G: 2 time/s
T: 1 time/s
U: 1 time/s
Y: 3 time/s
^: 2 time/s
f: 1 time/s
h: 4 time/s
i: 1 time/s
t: 4 time/s
u: 1 time/s
v: 1 time/s
w: 1 time/s
y: 3 time/s

Problem 7.	Phonebook
Write a program that receives some info from the console about people and their phone numbers.
You are free to choose the manner in which the data is entered; each entry should have just one name and one number (both of them strings). 
After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a search of a contact by name and print her details in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist." Examples:
Input	Output
Nakov-0888080808
search
Mariika
Nakov	Contact Mariika does not exist.
Nakov -> 0888080808
Nakov-+359888001122
RoYaL(Ivan)-666
Gero-5559393
Simo-02/987665544
search
Simo
simo
RoYaL
RoYaL(Ivan)	Simo -> 02/987665544
Contact simo does not exist.
Contact RoYaL does not exist.
RoYaL(Ivan) -> 666
* Bonus: What happens if the user enters the same name twice in the phonebook? Modify your program to keep multiple phone numbers per contact.

Problem 8.	Night Life
Being a nerd means writing programs about night clubs instead of actually going to ones. Spiro is a nerd and he decided to summarize some info about the most popular night clubs around the world. 
He's come up with the following structure – he'll summarize the data by city, where each city will have a list of venues and each venue will have a list of performers. Help him finish the program, so he can stop staring at the computer screen and go get himself a cold beer.
You'll receive the input from the console. There will be an arbitrary number of lines until you receive the string "END". Each line will contain data in format: "city;venue;performer". If either city, venue or performer don't exist yet in the database, add them. If either the city and/or venue already exist, update their info.
Cities should remain in the order in which they were added, venues should be sorted alphabetically and performers should be unique (per venue) and also sorted alphabetically.
Print the data by listing the cities and for each city its venues (on a new line starting with "->") and performers (separated by comma and space). Check the examples to get the idea. And grab a beer when you're done, you deserve it. Spiro is buying.
Input	Output
Sofia;Biad;Preslava
Pernik;Stadion na mira;Vinkel
New York;Statue of Liberty;Krisko
Oslo;everywhere;Behemoth
Pernik;Letishteto;RoYaL
Pernik;Stadion na mira;Bankin
Pernik;Stadion na mira;Vinkel
END	Sofia
->Biad: Preslava
Pernik
->Letishteto: RoYaL
->Stadion na mira: Bankin, Vinkel
NewYork
->Statue of Liberty: Krisko
Oslo
->everywhere: Behemoth

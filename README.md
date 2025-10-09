# Data Structures - Final
## Part 1 : Implementation of a Movie Playlist

### Question 1: Implement the Class Movie
1. Define the class Movie with properties: Title and Genre of type string, Duration of type int.
2. Define the Constructor with parameters.
3. Override the ToString() method.

### Question 2: Implement the Class Node
1. Define the class Node according as illustrated in the picture below.
2. Override the ToString() method.

### Question 3: Implement the Class Movie_Playlist
Implement in C# a Movie_Playlist which is a customized Doubly Linked List of Nodes (as illustrated in 
the picture below). The playlist should support a loop mode where the last song connects back to the first 
song. Your playlist must support the following operations:
1. public void Add (Movie newMovie): Add a movie to the playlist (at the end). 
2. public void Remove(string title): Remove a movie from the playlist (by title). 
3. public void PlayNext(): Display the title of the next movie (move to the next node). 
4. public void PlayPrev(): Display the title of the previous movie (move to prev node). 
5. public void ShufflePlay(): Display a randomly selected movie to play. 
6. public void DisplayPlaylist()

<img width="666" height="224" alt="Screenshot 2025-10-07 185026" src="https://github.com/user-attachments/assets/6f1becfa-03ee-409c-ba77-335874f36221" />

## Part 2: Binary Search Trees
### Question 2: Delete Nodes from a Binary Search Tree
Delete the nodes with keys 77 and 44 (in that order) from the following Binary Search Tree.  
Show the resulting tree after each deletion.
  
 <img width="815" height="517" alt="Screenshot 2025-10-07 185240" src="https://github.com/user-attachments/assets/a846645d-74d6-407a-a9b8-e9a0349fa9e7" />

### Question 3: Insert Nodes into a Binary Search Tree
Insert the following keys into an empty BST, in this order: ```38, 21, 12, 50, 28, 55, 43```.

Draw the tree after each insertion.

### Question 4: Binary Search Tree Traversals
Display the nodes of the resulting tree in Question3 using the following traversal methods:
- Pre-Order
- In-Order
- Post-Order
- Level Order

using System;
using System.Xml.Linq;

namespace _2333960_DS_Final
{
    public class Movie_Playlist
    {
        private Node? head;
        private Node? tail;
        private Node? current;

        public Node? Head { get => head; }
        public Node? Tail { get => tail; }
        public Node? Current { get => current; }

        public Movie_Playlist()
        {
            this.head = null;
            this.tail = null;
            this.current = null;
        }

        public Movie_Playlist(Movie newMovie)
        {
            Node newNode = new Node(newMovie);
            this.head = newNode;
            this.tail = newNode;
            this.current = newNode;
        }

        // Complexity: O(1)
        public void Add(Movie newMovie)
        {
            Node newNode = new Node(newMovie);

            if (newNode == null)
            {
                throw new ArgumentNullException("The parameter movie cannot be NULL");
            }

            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
                this.current = newNode;
                newNode.Next = this.head;
                this.head.Prev = newNode;
                return;
            }
            else if(this.tail != null)
            {
                newNode.Prev = this.tail;
                newNode.Next = this.head;
                this.tail.Next = newNode;
                this.head.Prev = newNode;
                this.tail = newNode;
            }
        }

        // Complexity: O(n)
        public void Remove(string title)
        {
            if (title == null)
            {
                throw new ArgumentNullException("The parameter title cannot be NULL");
            }


            if (this.head == null)
            {
                throw new InvalidOperationException("The playlist is empty.");
            }

            Node? temp = this.head;

            do
            {
                if (temp.Movie.Title == title)
                {
                    if (temp == this.head && temp == this.tail)
                    {
                        this.head = null;
                        this.tail = null;
                        this.current = null;
                    }
                    else if (temp.Prev != null && temp.Next != null)
                    {
                        temp.Prev.Next = temp.Next;
                        temp.Next.Prev = temp.Prev;
                    }

                    Console.WriteLine("Removed: " + title);
                    return;
                }

                temp = temp.Next;

            } while (temp != this.head && temp != null);

            Console.WriteLine("Movie '" + title + "' not found.");
        }


        // Complexity: O(1)
        public void PlayNext()
        {
            if (this.current == null)
            {
                throw new InvalidOperationException("The playlist is empty.");
            }

            if(this.current != null)
            {
                this.current = current.Next;
                Console.WriteLine("Next Movie: " + this.current.Movie.Title);
            }
        }

        // Complexity: O(1)
        public void PlayPrev()
        {
            if (this.current == null)
            {
                throw new InvalidOperationException("The playlist is empty.");
            }

            if(this.current != null)
            {
                this.current = current.Prev;
                Console.WriteLine("Previous Movie: " + this.current.Movie.Title);
            }
        }

        // Complexity: O(n)
        public void ShufflePlay()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException("The playlist is empty.");
            }

            List<Node> nodes = new List<Node>();
            Node temp = this.head;

            do
            {
                nodes.Add(temp);
                temp = temp.Next!;
            } while (temp != this.head);

            Random rand = new Random();

            Console.WriteLine("Playing on shuffle: " + nodes[rand.Next(nodes.Count)]);
        }

        // Complexity: O(n)
        public void DisplayPlaylist()
        {
            if (this.head == null)
            {
                Console.WriteLine("The playlist is empty.");
                return;
            }

            Node temp = head;
            int count = 1;
            do
            {
                Console.WriteLine(count + ". " + temp.Movie);
                count++;
                temp = temp.Next!;
            } while (temp != this.head);
        }
    }
}
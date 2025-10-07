using System;
namespace _DS_Final
{
    public class Node
    {
        private Node? prev;
        private Node? next;
        private Movie movie;

        public Node? Prev { get => prev; set => prev = value; }
        public Node? Next { get => next; set => next = value; }
        public Movie Movie { get => movie; set => movie = value; }

        public Node(Movie movie)
        {
            this.movie = movie;
            this.prev = null;
            this.next = null;
        }

        public override string ToString()
        {
            return Movie.ToString();
        }
    }
}


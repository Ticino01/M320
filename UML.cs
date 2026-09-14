using System;
using System.Collections.Generic;

namespace UmlExercise
{

    public class Animal
    {
        private string _species;

        public Animal(string species)
        {
            _species = species;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{_species} makes a sound: *typical animal noise*");
        }
    }

    public class Artist
    {
        private string _name;

        public Artist(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }

    // ---------------------------------------------
    // Music
    // ---------------------------------------------
    public class Music
    {
        private string _genre;
        private Artist _artist;

        public int Tempo { get; set; }

        public Music(string genre, Artist artist, int tempo)
        {
            _genre = genre;
            _artist = artist;
            Tempo = tempo;
        }

        public void Play()
        {
            Console.WriteLine($"Playing '{_genre}' by {_artist} at {Tempo} BPM.");
        }
    }

    // ---------------------------------------------
    // Human
    // ---------------------------------------------
    public class Human
    {
        private string _name;        public Animal Pet { get; set; }

        public Human(string name, int age, Animal pet = null)
        {
            _name = name;
            _age = age;
            Pet = pet;
        }

        public void Speak()
        {
            Console.WriteLine($"{_name} says: \"Hello, I am {_age} years old!\"");
        }
                public void ListenTo(List<Music> playlist)
        {
            Console.WriteLine($"{_name} is listening to a playlist of {playlist.Count} song(s):");
            foreach (Music song in playlist)
            {
                song.Play();
            }
        }

        public bool HasAnimal()
        {
            return Pet != null;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Artist artist1 = new Artist("Daft Punk");
            Artist artist2 = new Artist("Queen");

            Music song1 = new Music("Electronic", artist1, 123);
            Music song2 = new Music("Rock", artist2, 141);
            song2.Tempo = 145;

            List<Music> playlist = new List<Music> { song1, song2 };

            Animal dog = new Animal("Dog");
            dog.MakeSound();

            Human alice = new Human("Alice", 28);
            Console.WriteLine($"Does Alice have a pet? {alice.HasAnimal()}");
            alice.Speak();
            alice.ListenTo(playlist);

            Console.WriteLine();

            Human bob = new Human("Bob", 34, dog);
            Console.WriteLine($"Does Bob have a pet? {bob.HasAnimal()}");
            bob.Speak();
            bob.Pet.MakeSound(); 
            bob.ListenTo(playlist);
        }
    }
}
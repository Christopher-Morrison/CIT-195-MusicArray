using System;

namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Classical,
            Rock,
            Acoustic,
            Acapella,
            Metal
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private int Length;
            private Genre? Genre;

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(int length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int totalSongs = int.Parse(Console.ReadLine());
            Music[] songArray = new Music[totalSongs];
            try
            {
                for (int i = 0; i < totalSongs; i++)
                {
                    Console.WriteLine("Name a song: ");
                    songArray[i].setTitle(Console.ReadLine());

                    Console.WriteLine("Name the song's artist: ");
                    songArray[i].setArtist(Console.ReadLine());

                    Console.WriteLine("Name the song's album: ");
                    songArray[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("How long is the song: (integer)");
                    songArray[i].setLength(int.Parse(Console.ReadLine()));

                    Console.WriteLine("What Genre is it: \nC - Classical \nR - Rock\nA - Acoustic \nP - Acapella \nM - Metal");
                    char m = char.Parse(Console.ReadLine());
                    switch (m)
                    {
                        case 'C':
                            songArray[i].setGenre(Genre.Classical);
                            break;
                        case 'R':
                            songArray[i].setGenre(Genre.Rock);
                            break;
                        case 'A':
                            songArray[i].setGenre(Genre.Acoustic);
                            break;
                        case 'P':
                            songArray[i].setGenre(Genre.Acapella);
                            break;
                        case 'M':
                            songArray[i].setGenre(Genre.Metal);
                            break;
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < totalSongs; i++)
                {
                    Console.WriteLine(songArray[i].Display());
                }
            }
        }
    }
}

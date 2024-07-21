using MovieStoreApp.Models;
namespace MovieStoreApp
{
    internal class Program
    {
        static List<Movie> movies = new List<Movie>();
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Movie Management System: \n" +
                    "What do you wish to do?\n" +
                    "1. Add a Movie\n" +
                    "2. Display All Movie\n" +
                    "3. Find Movie By ID\n" +
                    "4. Update Movie details\n" +
                    "5. Remove Movie By Name\n" +
                    "6. Clear All Movies\n" +
                    "7. Exit   ");

                int choice = Convert.ToInt32(Console.ReadLine());
                DoTask(choice);
            }
        }

        static void DoTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddNewMovie();
                    break;
                case 2:
                    if(movies.Count == 0)
                        Console.WriteLine("No Movise Foubd");
                    else
                    {
                            movies.ForEach(movie => Console.WriteLine(movie));
                    }
                    break;
                case 3:
                    Movie findMovie = FindMovieById();
                    if(findMovie != null)
                        Console.WriteLine(findMovie);
                    else
                        Console.WriteLine("Movie No =t Found");
                    break;
                case 4:
                    UpdateMovieName();
                    break;
                case 5:
                    RemoveMovie();
                    break;
                case 6:
                    if (movies.Count == 0)
                        Console.WriteLine("List is already EMpty, nothing to clear");
                    else
                    {
                        movies.Clear();
                    }
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter Valid Input");
                    break ;


            }
        }

        static void RemoveMovie()
        {
            Movie findMovie = FindMovieById();
            if (findMovie != null)
                movies.Remove(findMovie);
            else
                Console.WriteLine("Movie doesnt exists. Please check ID again");
        }

        static void UpdateMovieName()
        {
            Movie findMovie = FindMovieById();
            if(findMovie == null)
                Console.WriteLine("Movie doesnt exists. Please check ID again");
            else
            {
                Console.WriteLine("Enter Movie name: ");
                string name = Console.ReadLine();
                findMovie.Name = name;
                Console.WriteLine("Movie Updated successfully");
            }
        }
        static Movie FindMovieById()
        {
            Movie findMovie = null;
            Console.WriteLine("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            findMovie = movies.Where(item => item.Id == id).FirstOrDefault();
            return findMovie;

        }
        static void AddNewMovie()

           


        {
            Console.WriteLine("Enter movie ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter movie name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter mOvie Genre: ");
            string genre = Console.ReadLine();
            Console.WriteLine("ENter Year of Release: ");
            int yearOfRelease = Convert.ToInt32(Console.ReadLine());

            Movie newMovie = Movie.AddMovie(id, name, genre, yearOfRelease);
            movies.Add(newMovie);
            Console.WriteLine("Movie added Successfully");



        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Libro> arrayLibros = new Libro[]
            {
                new Libro(1, "Poeta en nueva york", "Federico García Lorca"),
                new Libro(2, "Los asesinos del emperador", "Santiago Posteguillo"),
                new Libro(3, "circo máximo", "Santiago Posteguillo"),
                new Libro(4, "La noche en que Frankenstein leyó el Quijote", "Santiago Posteguillo"),
                new Libro(5, "El origen perdido", "Matilde Asensi"),
            };

            //arrayLibros fuera la tabla, y libro cada fila,
            //objeto donde buscas es en arraylibros y cada elemento es un libro
            //Si solo quisieras el titulo no el libro completo IEnumerable<string> y select libro.titulo;
            IEnumerable<Libro> libros = from libro in arrayLibros where libro.Autor == "Santiago Posteguillo" select libro;

            IEnumerable<Libro> librosExtension = arrayLibros.Where(a => a.Autor =="Santiago").OrderBy(a=>a.Titulo);
            //Se le agrega.Select(a=>a.titulo) y seria un enumerable de strings

            Libro libroFirst = arrayLibros.First(a=>a.Id==1);

            Libro libroLast = arrayLibros.Last();
            //Console.WriteLine(libroLast.Id);


            //Si no tenemos da null pero si tiene más de uno da una excepción
            Libro librosFirstDefault = arrayLibros.SingleOrDefault(a => a.Id == 1);

            var agrupacion = arrayLibros.GroupBy(a => a.Autor);


            librosExtension = arrayLibros.Filtro(a => a.Autor == "Santiago Postegui");

            //foreach(var autorLibro in agrupacion)
            //{
            //    Console.WriteLine(autorLibro.Key);
            //    foreach(var libro in autorLibro)
            //    {
            //        Console.WriteLine(libro.Titulo);
            //    }
            //}

            QueryStringArray();

            QueryIntArray();

            QueryArrayList();

            QueryCollection();

            QueryAnimalData();






        }
        static void QueryStringArray()
        {
            string[] dogs = {"K 9", "Brian Griffin",
                "Scooby Doo", "Old Yeller", "Rin Tin Tin",
                "Benji", "Charlie B. Barkin", "Lassie",
                "Snoopy"};


            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog descending select dog;

            //I prefer this sintax
            //var dogSpacesD = dogs.Where(a => a.Contains(" ")).OrderByDescending(a=>a);

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            //foreach(var i in dogSpacesD)
            //{
            //    Console.WriteLine(i);
            //}
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5,10,15,20,25,30,35};

            var gt20 = from num in nums where num > 20 orderby num select num;

            foreach(var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine($"Get type: {gt20.GetType()}");
            List<int> listGT20 = gt20.ToList();
            int[] arrayGT20 = gt20.ToArray();

            nums[0] = 40;

            foreach(var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            return arrayGT20;
            
        }

        static void QueryArrayList()
        {
            List<Animal> famAnimals = new List<Animal>
            {
                 new Animal{Name = "Heidi",
                Height = .8,
                Weight = 18},

                new Animal
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130
                },

                new Animal
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }
            };

            var smAnimals = from animal in famAnimals
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach(var animal in smAnimals)
            {
                Console.WriteLine($"{animal.Name} weighs {animal.Weight} lbs");
            }
            Console.WriteLine();

        }
        static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200}
            };

            var bigDogs = from dog in animalList
                          where (dog.Weight >= 70 && dog.Height > 25)
                          orderby dog.Name
                          select dog;


            foreach(var dog in bigDogs)
            {
                Console.WriteLine($"A {dog.Name} weighs {dog.Weight} lbs");
            }
            Console.WriteLine();

        }


        static void QueryAnimalData()
        {
            Animal[] animals = new[]
           {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77,
                AnimalID = 1},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4,
                AnimalID = 2},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200,
                AnimalID = 3},
                new Animal{Name = "Pug",
                Height = 12,
                Weight = 16,
                AnimalID = 1},
                new Animal{Name = "Beagle",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner{Name = "Doug Parks",
                OwnerID = 1},
                new Owner{Name = "Sally Smith",
                OwnerID = 2},
                new Owner{Name = "Paul Brooks",
                OwnerID = 3}
            };
            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };
            Array arrNameHeight = nameHeight.ToArray();

            foreach (var i in arrNameHeight)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();

            var innerJoin = from animal in animals
                            join owner in owners on animal.AnimalID equals owner.OwnerID
                            select new
                            {
                                OwnerName = owner.Name,
                                AnimalName = animal.Name
                            };
            foreach(var i in innerJoin)
            {
                Console.WriteLine($"{i.OwnerName} owns {i.AnimalName}");
            }

            Console.WriteLine();

            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals on owner.OwnerID equals animal.AnimalID into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animals = from owner2 in ownerGroup orderby owner2.Name select owner2
                            };

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    Console.WriteLine($"* {animal.Name}");
                }
            }




        }

    }
}

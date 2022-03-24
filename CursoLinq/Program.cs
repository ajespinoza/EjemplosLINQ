using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHERE

            //int[] numeros = Enumerable.Range(1, 20).ToArray();

            //var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

            ////Console.WriteLine("Los numeros impares son: ");
            ////foreach(var numero in numerosImpares)
            ////{
            ////    Console.WriteLine(numero);
            ////}

            ////Sintaxis de metodos o lambda
            //var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

            ////Sintaxis de query
            //var numerosImparesMayoresQue10_2 = from n in numeros
            //                                   where n % 2 == 1 && n > 10
            //                                   select n;

            //Console.WriteLine("Los numeros impares mayores que 10 son: ");
            //foreach (var numero in numerosImparesMayoresQue10_2)
            //{
            //    Console.WriteLine(numero);
            //}


            //var personas = new List<Persona>() {
            //    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
            //    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
            //    new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
            //    new Persona { Nombre = "Valentina", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
            //    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            //};

            //var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();

            //foreach(var persona in personasDe25AñosOMenos)
            //{
            //    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");
            //}

            //var solteros = personas.Where(p => p.Soltero && p.Edad <=25).ToList();
            //foreach(var persona in solteros)
            //{
            //    Console.WriteLine($"{persona.Nombre} es soltero/a.");
            //}

            //var personasConMenos3MesesEnLaEmpresa = personas
            //                                .Where(p => p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();

            //var personasConMenos3MesesEnLaEmpresa_2 = from p in personas
            //                                          where p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)
            //                                          select p;

            //foreach (var persona in personasConMenos3MesesEnLaEmpresa_2)
            //{
            //    Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa.");
            //}


            //FIRST y FIRSTORDEFAULT

            //var primeraPersona = personas.First();
            ////Devuelve el valor por defecto del tipo de dato
            //var primeraPersona2 = personas.FirstOrDefault();

            //var paises = new List<string>();
            //var primerPais = paises.FirstOrDefault();

            //var primeraPersonaNoSoltera = personas.FirstOrDefault(p => !p.Soltero);
            //var primeraPersonaNoSoltera_2 = (from p in personas
            //                                 where !p.Soltero
            //                                 select p).FirstOrDefault();



            //LAST OR LASTORDEFAULT

            //var ultimaPersona = personas.Last();
            //var ultimaPersona_2 = personas.LastOrDefault();
            //var ultimaPersonaSoltera = personas.LastOrDefault(p => p.Soltero);


            //ELEMENTAT

            //var terceraPersona = personas.ElementAt(2);
            //var sextaPersona = personas.ElementAtOrDefault(5);

            //var sextaPersona_2 = (from p in personas
            //                      select p).ElementAtOrDefault(5);


            //SINGLE OR SINGLEORDEFAULT
            //var personaMayorde60 = personas.Single(p => p.Edad > 60);

            //try
            //{
            //    var personaMayora100 = personas.SingleOrDefault(p => p.Edad > 100);
            //}catch(Exception ex)
            //{
            //    Console.WriteLine("Hubo un error, arreglo vacio");
            //}

            //try
            //{
            //    var personaMayora5 = personas.SingleOrDefault(p => p.Edad > 5);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hubo un error, arreglo con mas de un elemento");
            //}


            //OFTYPE

            //var listado = new List<object>() { "Felipe", 1, 2, "Claudia", true};

            //var strings = listado.OfType<string>();
            //var numeros = listado.OfType<int>();

            ////Sintaxi de querys
            //var strings_2 = from s in listado.OfType<string>()
            //                select s;



            //ORDERBY


            //var personasOrdenadasporEdad = personas.OrderBy(p => p.Edad);
            //foreach(var persona in personasOrdenadasporEdad)
            //{
            //    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            //}

            //int[] numeros = { 1, 5, 12, 2, 3, 111, 6 };
            //foreach(var numero in numeros.OrderBy(x=> x))
            //{
            //    Console.WriteLine(numero);
            //}

            //var numeros_2 = from n in numeros
            //                orderby n
            //                select n;
            //var personasOrdenadasporEdad_2 = from p in personas
            //                                 orderby p.Edad descending
            //                                 select p;

            //var personasOrdenadasporEdadyNombre = personas.OrderBy(p => p.Edad).ThenBy(p => p.Nombre);
            //foreach (var persona in personasOrdenadasporEdadyNombre)
            //{
            //    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            //}

            //var personasOrdenadasporEdadyNombre_2 = from p in personas
            //                                        orderby p.Edad, p.Nombre descending
            //                                        select p;
            //foreach (var persona in personasOrdenadasporEdadyNombre)
            //{
            //    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            //}



            //REVERSE

            //var numeros = Enumerable.Range(1, 20).Reverse();

            //var numeros_2 = from n in Enumerable.Range(1, 20).Reverse()
            //                select n;

            //var personasInvertido = personas.AsEnumerable().Reverse();



            //SELECT

            //var nombres = personas.Select(p => p.Nombre).ToList();

            //var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad }).ToList();

            //var nombresYEdadesDTO = personas.Select(p => new PersonaDTO { Nombre=p.Nombre, Edad = p.Edad }).ToList();

            //var numeros = Enumerable.Range(1, 5).ToList();
            //var numerosDuplicados = numeros.Select(n => 2 * n).ToList();

            //var personasConIndice = personas.Select((p,indice) => new { Persona = p, Indice = indice + 1 }).ToList();
            //foreach(var item in personasConIndice)
            //{
            //    Console.WriteLine($"{item.Indice}) {item.Persona.Nombre}");
            //}

            ////Con querys
            //var nombres_2 = (from p in personas
            //                select p.Nombre).ToList();
            //var nombresYEdades_2 = from p in personas
            //                       select new { Nombre = p.Nombre, Edad = p.Edad };
            //var numerosDuplicados_2 = from n in numeros
            //                          select 2 * n;
            ////No podemos hacer el ejemplo del indice con sintaxis de querys


            //SELECT MANY

            //var personas = new List<Persona>() {
            //    new Persona { Nombre = "Eduardo", Telefonos = { "123-234", "123-347" } },
            //    new Persona { Nombre = "Nidia", Telefonos = { "456-2364", "67-7" } },
            //    new Persona { Nombre = "Alejandro", Telefonos = { "567-234", "789-36747" } },
            //    new Persona { Nombre = "Valentina" }
            //};

            //var telefonos = personas.SelectMany(p => p.Telefonos).ToList();
            //var telefonosSelect = personas.Select(p => p.Telefonos).ToList();

            //int[] numeros = { 1, 2, 3 };
            //var personasYNumeros = personas.SelectMany(p=> numeros, (persona, numero) => new 
            //{ 
            //    Persona = persona,
            //    Numero = numero
            //});

            //foreach(var item in personasYNumeros)
            //{
            //    Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
            //}

            //var personasyTelefonos = personas.SelectMany(p => p.Telefonos, (persona, telefono) => new
            //{
            //    Persona = persona,
            //    Telefono = telefono
            //});
            //foreach (var item in personasyTelefonos)
            //{
            //    Console.WriteLine($"{item.Persona.Nombre} - {item.Telefono}");
            //}

            ////Querys
            //var telefonos_2 = from p in personas
            //                  from telefono in p.Telefonos
            //                  select telefono;

            //var personasYNumeros_2 = from p in personas
            //                       from n in numeros
            //                       select new { Persona = p, Numero = n };


            //COUNT Y LONGCOUNT
            //var personas = new List<Persona>() {
            //    new Persona { Nombre = "Eduardo", Soltero = true },
            //    new Persona { Nombre = "Nidia", Soltero = true },
            //    new Persona { Nombre = "Alejandro", Soltero = true },
            //    new Persona { Nombre = "Valentina", Soltero = false }
            //    };

            //Console.WriteLine($"La cantidad de personas es: {personas.Count()}");
            //Console.WriteLine($"La cantidad de personas solteras es: {personas.Count(p => p.Soltero)}");

            ////Usar longcount para colecciones arriba de los 2mil millones 
            ////Sintaxis de querys
            //var conteoSolteros = (from p in personas
            //                      where p.Soltero
            //                      select p).Count();


            ////SUMA, MAXIMO y MINIMO
            //var personas = new List<Persona>() {
            //    new Persona { Nombre = "Eduardo", Edad = 19 },
            //    new Persona { Nombre = "Nidia", Edad = 25 },
            //    new Persona { Nombre = "Alejandro", Edad = 30 },
            //    new Persona { Nombre = "Valentina", Edad = 22 }
            //    };
            //var numeros = Enumerable.Range(1, 5);
            //Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
            //Console.WriteLine($"La suma de las edades es {personas.Sum(p => p.Edad)}");
            //Console.WriteLine($"La edad maxima de las personas es {personas.Max(p => p.Edad)}");
            //Console.WriteLine($"La edad minima de las personas es {personas.Min(p => p.Edad)}");

            ////PROMEDIOS
            //Console.WriteLine($"El promedio de los numeros es {numeros.Average()}");
            //Console.WriteLine($"El promedio de las edades es {personas.Average(p => p.Edad)}");

            ////AGREGADOS - Operacion entre los elementos de una coleccion
            //var resultado = numeros.Aggregate((a,b) => a * b); //1x2x3x4x5
            //Console.WriteLine($"Resultado es {resultado}");

            //var resultadoConValorInicial = numeros.Aggregate(10,(a,b) => a * b); //10x1x2x3x4x5
            //Console.WriteLine($"Resultado es {resultadoConValorInicial}");


            //CUANTIFICADORES -- No hay sintaxis de querys
            //ALL
            //var personas = new List<Persona>() {
            //    new Persona { Nombre = "Eduardo", Edad = 19, Soltero = true },
            //    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
            //    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
            //    new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
            //    };
            //var numeros = Enumerable.Range(1, 5);

            //var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad > 18);
            //var sonTodasLasPersonasSolteras = personas.All(p => p.Soltero);

            ////ANY
            //var existeMenor = personas.Any(p => p.Edad < 18);
            //var existeMayorde20 = personas.Any(p => p.Edad > 20);

            ////CONTAINS
            //var estaElNumero3 = numeros.Contains(3);
            //var estaElNumero20 = numeros.Contains(20);




            ////PAGINACION
            ////TAKE Y TAKELAST
            //var numeros = Enumerable.Range(1, 100);

            //var primeros10 = numeros.Take(10).ToList();
            //var ultimos10 = numeros.TakeLast(10).ToList();

            ////SKIP y SKIPLAST

            //var segundoLotede10 = numeros.Skip(10).Take(10).ToList();
            //var penultimolote = numeros.SkipLast(10).TakeLast(10).ToList();


            ////EJEMPLO DE PAGINACION
            //for(int i = 1; i<=10; i++)
            //{
            //    Console.WriteLine($"Pagina {i}");
            //    var paginado = numeros.Paginar(i, 10);
            //    foreach(var numero in paginado)
            //    {
            //        Console.WriteLine(numero);
            //    }
            //}

            ////TAKEWHILE Y SKIPWHILE
            //int[] numeros = { 1,2,3,4,5,6,7,8,9,10,3,2,1};

            ////Toma los elementos mientras el predicado sea true
            ////A partir de que el predicado sea falso deja de tomar elementos
            //var resultadoTakeWhile = numeros.TakeWhile(x => x < 5).ToList();

            //var resultadoSkipWhile = numeros.SkipWhile(x => x < 5).ToList();




            ////GROUP BY

            //var personas = new List<Persona>() {
            //    new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
            //    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
            //    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
            //    new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
            //    new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
            //    new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
            //    new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
            //};

            //var agrupamientoPorSolteria = personas.GroupBy(p => p.Soltero);
            ////Query
            //var agrupamientoPorSolteria_2 = from p in personas
            //                                group p by p.Soltero into grupos
            //                                select grupos;

            //foreach (var grupo in agrupamientoPorSolteria)
            //{
            //    Console.WriteLine($"Grupo de las personas donde soltero = {grupo.Key} (Total: {grupo.Count()})");
            //    foreach(var persona in grupo)
            //    {
            //        Console.WriteLine($"- {persona.Nombre}");
            //    }
            //}


            //var agrupamientoPorRangoEdad = personas.GroupBy(p => p.Edad / 5);
            ////Query
            //var agrupamientoPorRangoEdad_2 = from p in personas
            //                                 group p by p.Edad / 5 into grupos
            //                                 select grupos;
            //foreach (var grupo in agrupamientoPorRangoEdad)
            //{
            //    Console.WriteLine($"Grupo de las personas en el rango de edad {grupo.Key * 5} - {grupo.Key * 5 +5-1}");
            //    foreach(var persona in grupo)
            //    {
            //        Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
            //    }
            //}




            ////RELACIONES JOIN Y GROUPJOIN

            //var personas = new List<Persona>() {
            //                new Persona { Nombre = "Eduardo", EmpresaId = 1, },
            //                new Persona { Nombre = "Nidia",  EmpresaId = 1 },
            //                new Persona { Nombre = "Alejandro", EmpresaId = 3 },
            //                new Persona { Nombre = "Valentina",  EmpresaId = 2 },
            //                new Persona { Nombre = "Roberto",  EmpresaId = 3 },
            //                new Persona { Nombre = "Eugenia"},
            //                new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
            //                };

            //var empresas = new List<Empresa>()
            //{
            //    new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
            //    new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
            //    new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"},
            //    new Empresa{Id = 4, Nombre = "Ferreteria Lorenzo"},
            //};

            //var personasYEmpresas = personas.Join(empresas, p => p.EmpresaId, e => e.Id, (persona,empresa) => new {
            //    Persona = persona,
            //    Empresa = empresa
            //});

            ////Por query
            //var personasYEmpresas_2 = from p in personas
            //                          join e in empresas on p.EmpresaId equals e.Id
            //                          select new
            //                          {
            //                              Persona = p,
            //                              Empresa = e
            //                          };

            //foreach (var item in personasYEmpresas)
            //{
            //    Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}");
            //}


            ////GROUPJOIN (LEFT JOIN)
            //var empresasYSusEmpleados = empresas.GroupJoin(personas, e => e.Id, p => p.EmpresaId, (empresa, personas) => new {
            //Empresa = empresa, Personas = personas});
            ////Con query
            //var empresasYSusEmpleados_2 = from empresa in empresas
            //                              join persona in personas
            //                              on empresa.Id equals persona.EmpresaId into personas2
            //                              select new {
            //                                Empresa = empresa,
            //                                Personas = personas2
            //                              };

            //foreach (var item in empresasYSusEmpleados)
            //{
            //    Console.WriteLine($"Las siguientes personas trabajan en {item.Empresa.Nombre}");
            //    foreach(var persona in item.Personas)
            //    {
            //        Console.WriteLine($"- {persona.Nombre}");
            //    }
            //}


            //CONJUNTOS
            ////DISTINCT
            //var personas = new List<Persona>() {
            //                new Persona { Nombre = "Eduardo", EmpresaId = 1, },
            //                new Persona { Nombre = "Nidia",  EmpresaId = 1 },
            //                new Persona { Nombre = "Eduardo" },
            //                new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
            //                };

            //int[] numeros = { 1,2,3,1,1,6};

            //var numerosSinRepeticiones = numeros.Distinct();
            ////var personasSinNombresRepetidos = personas.DistinctBy(p => p.Nombre);

            ////Query
            //var numerosSinRepeticiones_2 = from n in numeros.Distinct()
            //                               select n;
            ////var personasSinNombresRepetidos_2 = from p in personas.DistinctBy(x => x.Nombre)
            ////                                    select p;



            //UNION
            //var personasA = new List<Persona>() {
            //new Persona { Nombre = "Eduardo", EmpresaId = 1, },
            //new Persona { Nombre = "Nidia",  EmpresaId = 1 },
            //new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
            //};

            //var personasB = new List<Persona>()
            //{
            //    new Persona{Nombre = "Fernando", Edad = 25},
            //    new Persona { Nombre = "Eduardo", EmpresaId = 1, },
            //};

            //int[] numerosA = { 1, 2, 3};

            //int[] numerosB = { 1, 15 };

            //var unionNumeros = numerosA.Union(numerosB);
            ////var unionPersonas = personasA.UnionBy(personasB, x => x.Nombre);


            ////EXCEPT
            ////Todo lo que esta en A y que no está en B
            //var numerosEnAQueNoEstanEnB = numerosA.Except(numerosB);
            //var personasBNombres = personasB.Select(x => x.Nombre);
            ////var personasAQueNoEstanEnB = personasA.ExceptBy(personasBNombres, x=> x.Nombre);


            ////INTERSECT
            //var numerosQueEstanEnAyB = numerosA.Intersect(numerosB);
            ////var personasQueEstanEnAYB = personasA.IntersectBy(personasBNombres, x=>x.Nombre);




            ////CONCAT
            //int[] A = { 1, 2, 3 };
            //int[] B = { 4, 5, 6 };

            //var resultado = A.Concat(B);


            ////SEQUENCEEQUAL - Si dos colecciones tienen exactamente los mismos elementos
            //string[] A = { "felipe", "fernando" };
            //string[] B = { "felipe", "fernando" };
            //string[] C = { "FEliPE", "FernandO" };
            //string[] D = { "fernando", "felipe" };

            //var AB = A.SequenceEqual(B);
            //var AC = A.SequenceEqual(C);
            //var ACSinImportarMayusculas = A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);
            //var AD = A.SequenceEqual(D);




            ////ZIP Operacion sobre los elementos respectivos de colecciones
            //int[] A = { 1, 2, 3 };
            //int[] B = { 4, 5, 6 };

            //var combinados = A.Zip(B); // (1,4) (2,5) (3,6)
            //foreach(var combinado in combinados)
            //{
            //    Console.WriteLine($"({combinado.First},{combinado.Second})");
            //}

            //var resultado = A.Zip(B, (a, b) => a * b);




            //CHUNK c#10 Divide una coleccion en el tamano dado
            //int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var resultado = A.Chunk(2) //{1,2}, {3,4}....;


                


            var a = 1;
        }
    }
}

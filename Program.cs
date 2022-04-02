// See https://aka.ms/new-console-template for more information
using Semana02_UESAN_Consola;

Console.WriteLine("Hello, World!");

string nombCurso = "Desarrollo de aplicaciones web 2022-01";
int edad = 22;
double monto = 12.5;

var nombreAlumno = "Luis";
var peso = 60;


List<Persona> listado = new List<Persona>();
var Persona = new Persona();
Persona.dni = "12345678";
Persona.nombreCompleto = "Luisa";
Persona.telefono = 99488484;

var Persona2 = new Persona("22993300", "Juan", 28);

var Persona3 = new Persona()
{
    dni = "66778899",
    nombreCompleto = "Pedro",
    telefono = 994884000,
};

listado.Add(Persona);
listado.Add(Persona2);
listado.Add(Persona3);

//Print listado personas
foreach (var item in listado)
{
    Console.WriteLine(item.dni + " - " + item.nombreCompleto + " - " + item.telefono);
}

var busqueda = listado.Find(search => search.dni == "66778899");
//Validar si es null
if (busqueda != null)
    Console.WriteLine(busqueda.dni + " - " + busqueda.nombreCompleto + " - " + busqueda.telefono);
else
    Console.WriteLine("No se encontro el registro");
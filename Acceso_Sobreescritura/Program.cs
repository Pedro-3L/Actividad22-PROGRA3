Console.WriteLine("CONTROL DE ACCESOS");
Persona p1 = new Empleado();
p1.nombre = "Carlos";

Persona p2 = new Visitante();
p2.nombre = "Ana";

Persona p3 = new Seguridad();
p3.nombre = "Luis";

Console.WriteLine();
p1.Acceso();

Console.WriteLine();
p2.Acceso();

Console.WriteLine();
p3.Acceso();



class Persona
{
	public string nombre;

	public virtual void Acceso()
	{
		Console.WriteLine(nombre + " tiene acceso básico");
	}
}
class Empleado : Persona
{
	public override void Acceso()
	{
		Console.WriteLine(nombre + " tiene acceso a oficinas y áreas de trabajo");
	}
}
class Visitante : Persona
{
	public override void Acceso()
	{
		Console.WriteLine(nombre + " tiene acceso limitado (solo áreas públicas)");
	}
}
class Seguridad : Persona
{
	public override void Acceso()
	{
		Console.WriteLine(nombre + " tiene acceso total a todas las áreas");
	}
}
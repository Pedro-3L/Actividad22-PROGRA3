Alumno a = new Alumno();
Console.WriteLine("DATOS ALUMNO");
a.nombre="Carlos";
a.carne=245;
a.edad=15;
a.carrera="Ingenieria";
a.dpi=114213;
a.direccion="1-2Av zona 10";
a.Login();
a.MostrarInformacion();
a.Estudiar();

Console.WriteLine();
Catedratico c = new Catedratico();
Console.WriteLine("DATOS CATEDRATICO");
c.nombre="Miguel";
c.edad=35;
c.dpi=796873;
c.salario=550.00;
c.direccion="13 calle 5Av zona 1";
c.codigo_colegiado=14794;
c.Login();
c.MostrarInformacion();
c.Enseñar();

Console.WriteLine();
Cordinacion o = new Cordinacion();
Console.WriteLine("DATOS CORDINACION");
o.nombre="Andrea";
o.edad=55;
o.dpi=1021983;
o.direccion="12Av zona 11";
o.cargo="Secretaria";
o.Login();
o.MostrarInformacion();
class Usuario
{
	public string nombre;
	public int dpi;
	public int edad;
	public string direccion;
	public void Login()
	{
		Console.WriteLine(nombre + " inició sesión");
	}
	public virtual void MostrarInformacion()
	{
		Console.WriteLine("Nombre: " + nombre);
		Console.WriteLine("No.dpi: " + dpi);
		Console.WriteLine("Edad: " + edad);
		Console.WriteLine("Dirección: " + direccion);
	}
}
class Alumno : Usuario
{
	public int carne;
	public string carrera;
	public override void MostrarInformacion()
	{
		base.MostrarInformacion();
		Console.WriteLine("Carné: " + carne);
		Console.WriteLine("Carrera: " + carrera);
	}
	public void Estudiar()
	{
		Console.WriteLine(nombre + " está estudiando " + carrera);
	}
}
class Catedratico : Usuario
{
	public double salario;
	public int codigo_colegiado;
	public override void MostrarInformacion()
	{
		base.MostrarInformacion();
		Console.WriteLine("Salario: " + salario);
		Console.WriteLine("Código de colegiado de ingeniero: " + codigo_colegiado);
	}
	public void Enseñar()
	{
		Console.WriteLine(nombre + " imparte clases");
	}
}

class Cordinacion : Usuario
{
	public string cargo;
	public override void MostrarInformacion()
	{
		base.MostrarInformacion();
		Console.WriteLine("Cargo: " + cargo);
	}
}
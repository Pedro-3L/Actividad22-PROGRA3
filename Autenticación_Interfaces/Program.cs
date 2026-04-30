Sistema s = new Sistema();

s.Login("Carlos", "1234");
s.Registrar("Carlos inició sesión");

Console.WriteLine();

s.Login("Miguel", "abcd");
s.Registrar("Miguel intentó acceder");
    



interface IAutenticacion
{
	void Login(string usuario, string contraseña);
}

interface IAuditoria
{
	void Registrar(string accion);
}

class Sistema : IAutenticacion, IAuditoria
{
	public void Login(string usuario, string contraseña)
	{
		Console.WriteLine("Usuario " + usuario + " autenticado en el sistema");
	}

	public void Registrar(string accion)
	{
		Console.WriteLine("Auditoría: " + accion);
	}
}

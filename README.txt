A. Instrucciones de cómo ejecutar la aplicación en un ambiente local.

	1-) Instalar .NET Standar 2.0.
	2-) Insntalar ASP .NET Framework 4.6.1 en adelante.
	3-) Inslatar un motor de BD SQL Server para el Backend (En la carpeta Resourse/ del InfoClima-SoapServer/ se encuentra el Query de la BD).
	4-) Importar la BD InfoClima_Query.sql y crear una instancia con su cadena de conexion respectiva.
	5-) Actualizar la cadena de conexion identificada con el atributo "InfoClimaEntities" en el Web.config del Proyecto Web WCF Service con los valores de la instancia SQLServer de su equipo.
	6-) Abrir ambas soluciones en Visual Studio 2019.
	7-) La URL SOAP del Servicio por defecto es: http://localhost:58590/ServiceClimate.svc?wsdl 
	8-) Navegar la vista, ya tiene en su Web.config la URL_SOAP por defecto.
				
   
B. Explicación de la arquitectura que planteo para solucionar el problema.

	Se empleo el principio SOLID de Arquitectura por capas para un mayor desacoplamiento y reutilizacion de componentes.
	En la carpeta Resourse del BE esta el diagra de Arquitectura empleada en el ejercicio.
	
C. Explicación de las tecnologías seleccionadas para resolver el problema.

	Servicio SOAP: .NET Standar 2.0 y .NET Framework 4.6.1 para las libreias de los componentes de las capa y Pruebas Unitarias (Lenguaje C#)
	Cliente SOAP Web: ASP .NET Framework 4.6.1 con MVC 5 (C# y Razor HTML5).
	
	ORM: EntityFramework 6.X
	Servicio Web SOAP: WCF
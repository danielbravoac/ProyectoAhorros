# Ahorros
 Proyecto de Ahorros para simular apertura de cuenta corriente

# 📟 Módulos en Ejecución
+ Apertura de Cuenta Corriente

# 👨‍💻 Sobre el Código
El código ha sido realizado gracias a la arquitectura N Capas. La programación por capas es una arquitectura cliente-servidor en el que el objetivo primordial es la separación de la lógica de negocios de la lógica de diseño; un ejemplo básico de esto consiste en separar la capa de datos de la capa de presentación al usuario.
La ventaja principal de este estilo es que el desarrollo se puede llevar a cabo en varios niveles y, en caso de que sobrevenga algún cambio, solo se ataca al nivel requerido sin tener que revisar entre código mezclado.
El más utilizado actualmente es el diseño en tres niveles (o en tres capas), las cuales son:

+ Capa de presentación: la que ve el usuario (también se la denomina "capa de usuario"), presenta el sistema al usuario, le comunica la información y captura la información del usuario en un mínimo de proceso (realiza un filtrado previo para comprobar que no hay errores de formato). También es conocida como interfaz gráfica y debe tener la característica de ser "amigable" (entendible y fácil de usar) para el usuario. Esta capa se comunica únicamente con la capa de negocio.
+ Capa de negocio: es donde residen los programas que se ejecutan, se reciben las peticiones del usuario y se envían las respuestas tras el proceso. Se denomina capa de negocio (e incluso de lógica del negocio) porque es aquí donde se establecen todas las reglas que deben cumplirse. Esta capa se comunica con la capa de presentación, para recibir las solicitudes y presentar los resultados, y con la capa de datos, para solicitar al gestor de base de datos almacenar o recuperar datos de él. También se consideran aquí los programas de aplicación.
+ Capa de datos: es donde residen los datos y es la encargada de acceder a los mismos. Está formada por uno o más gestores de bases de datos que realizan todo el almacenamiento de datos, reciben solicitudes de almacenamiento o recuperación de información desde la capa de negocio.

# 📦 Sobre la Base de Datos
La base de datos no relacional representada, se ha realizado con las especificaciones hechas por el cliente. Basando la base de datos en la documentación brindada a continuación:
[Presentación de Documentación](https://docs.google.com/document/d/19RG5ffvn-2cmFvbtJA3KHfLeMbAIbSdRF2JjjVY1vV4/edit?usp=sharing) [Diagrama de Proceso] (https://app.lucidchart.com/invitations/accept/4c508bc4-e8e6-4913-b77d-8c318403f692)

# ❓ Como Descargarlo y Restaurarlo
Para la restauración de la **base de datos** utilice [SQL Server 2019](https://www.microsoft.com/es-es/sql-server/sql-server-2019) con una instancia local o con contraseña; realice consultando la [documentación](https://docs.microsoft.com/es-es/sql/relational-databases/backup-restore/restore-a-database-backup-using-ssms?view=sql-server-ver15) respectiva y para la **edición de código** use [Visual Studio 2019](https://visualstudio.microsoft.com/es/vs/), alterne la cadena de conexión conveniente en la capa de Acceso a Datos en clsConexion.cs

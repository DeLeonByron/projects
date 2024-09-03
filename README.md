# projects
project list
# Calculadora Aritmética

Este proyecto es una calculadora aritmética web desarrollada con Angular en el frontend y una API en ASP.NET Core en el backend. La aplicación permite realizar operaciones básicas como suma, resta, multiplicación y división.

## Requisitos Previos

Antes de comenzar, asegurarse de tener las siguientes herramientas instaladas en el equipo.

- [Node.js](https://nodejs.org/) (versión 14 o superior)
- [Angular CLI](https://angular.io/cli) (versión 12 o superior)
- [Visual Studio Code](https://code.visualstudio.com/) o cualquier otro editor de código
- [ASP.NET Core SDK](https://dotnet.microsoft.com/download/dotnet/5.0) (versión 5.0 o superior)
- [Git](https://git-scm.com/) (opcional, control de versiones)

## Clonación del Repositorio

Primero, clona el repositorio del proyecto a tu máquina local usando Git:

```bash
git clone https://github.com/DeLeonByron/projects.git
```

## Configuración del Frontend (Angular)

### 1. Instalación de Dependencias

Navega a la carpeta `frontend` y ejecuta el siguiente comando para instalar todas las dependencias necesarias:

```bash
cd arithmetic-calculator
npm install
```

### 2. Configuración del Archivo `environment`

En la carpeta `src/environments`, asegúrate de que el archivo `environment.ts` esté configurado con la URL de tu API backend:

```typescript
export const environment = {
  production: false,
  apiUrl: 'http://localhost:5090/api' // puerto asignado de web API
};
```

### 3. Ejecución del Servidor de Desarrollo

Para iniciar el servidor de desarrollo de Angular, ejecuta:

```bash
ng serve
```

Luego, abre un navegador web y navega a `http://localhost:4200` o según puerto asignado para ver la aplicación.

## Configuración del Backend (ASP.NET Core)

### 1. Instalación de Dependencias

Navega a la carpeta `backend` y restaura los paquetes NuGet necesarios:

```bash
cd ArithmeticCalculatorApi
dotnet restore
```

### 2. Ejecución de la API

Para ejecutar la API, utiliza el siguiente comando:

```bash
dotnet run
```

Esto iniciará el servidor en `http://localhost:5090` o en el puerto asignado.

### 3. Exploración de la API con Swagger

Para visualizar y probar los endpoints de la API, navega a `http://localhost:5090/swagger` en tu navegador. Swagger proporcionará una interfaz visual para interactuar con los endpoints de la API.

## Estructura del Proyecto

### Frontend (Angular)

- **src/app/views**: Contiene el componente de la calculadora.
- **src/app/core/core/services/calculator.service.ts**: Contiene los servicios de Angular que interactúan con la API backend.
- **src/environments**: Configuración del entorno, como las URLs de la API.

### Backend (ASP.NET Core)

- **Controllers/ArithmeticController.cs**: Controlador principal que maneja las operaciones aritméticas.
- **Services/ArithmeticService.cs**: Servicio que implementa la lógica de las operaciones.
- **Program.cs**: Punto de entrada para la aplicación.

## Notas

- Asegurarse de tener siempre la última versión de las dependencias.
- El proyecto está configurado para un entorno de desarrollo

Este README cubre todos los aspectos esenciales del proyecto, desde la instalación hasta la ejecución.

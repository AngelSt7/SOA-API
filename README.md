# Gu�a de Instalaci�n y Configuraci�n

## Paso 1: Clonar el Repositorio
```bash
git clone https://github.com/AngelSt7/SOA-API.git
cd SOA-API
```

## Paso 2: Restaurar Paquetes NuGet
```bash
dotnet restore
```

## Paso 3: Levantar los Contenedores Docker
```bash
docker compose up -d
```

## Paso 4: Abrir la Consola del Administrador de Paquetes
1. Ir a **Ver** en el men� superior
2. Seleccionar **Otras ventanas**
3. Hacer clic en **Consola del Administrador de Paquetes**

## Paso 5: Aplicar la Migraci�n Inicial
En la Consola del Administrador de Paquetes, ejecutar:
```powershell
Add-Migration InitDB
```

## Paso 6: Actualizar la Base de Datos
```powershell
Update-Database
```

## Paso 7: Ejecutar la Aplicaci�n
Presionar el bot�n verde de **Play/Run** en Visual Studio

## Paso 8: Ejecutar el Seed de Datos
Realizar una petici�n GET a:
```
http://localhost:7026/api/seed
```
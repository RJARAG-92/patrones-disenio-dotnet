# 🏗️ Factory Method - Ejemplo 1

Este ejemplo muestra una implementación del patrón **Factory Method** usando C# y .NET, con una estructura modular dividida en **Factories**, **Interfaces** y **Services**.

---

## 📁 Estructura del ejemplo

```
FactoryMethod/
└── Ejemplo1/
    ├── Interfaces/
    │   └── INotificacion.cs
    ├── Services/
    │   ├── NotificacionEmail.cs
    │   └── NotificacionSms.cs
    ├── Factories/
    │   ├── NotificacionFactory.cs (abstracta)
    │   ├── EmailFactory.cs
    │   └── SmsFactory.cs
```

---

## 🧠 Descripción

- `INotificacion`: Interfaz base para todos los tipos de notificación.
- `NotificacionEmail` y `NotificacionSms`: Implementaciones concretas de notificación.
- `NotificacionFactory`: Clase abstracta que declara el método `CrearNotificacion()` y define el comportamiento común `EnviarConLog()`.
- `EmailFactory` y `SmsFactory`: Fábricas concretas que implementan la creación específica.

---

## 🖥️ Ejecución desde consola

El proyecto `PatronesDeDisenio.ConsoleRunner` contiene un menú para ejecutar este ejemplo:

```bash
Seleccione un patrón:
1. Factory Method
2. Salir

> 1

Seleccione tipo de notificación:
1. Email
2. SMS

> 2

[FACTORY] Instanciando SmsFactory
[LOG] Preparando envío...
[DEBUG] Usando NotificacionSms
SMS enviado: Hola desde la consola con Factory Method
[LOG] Envío completado.
```

---

## ✅ Pruebas automatizadas

El archivo `FactoryMethodTests.cs` contiene pruebas con `xUnit` para verificar:
- La creación de instancias específicas (Email/SMS).
- La ejecución del método `EnviarConLog` con sus logs.
- El comportamiento completo de las fábricas.

---

## 📌 Aplicaciones comunes
- Envío de notificaciones por múltiples canales
- Creación desacoplada de componentes
- Procesamiento modular según tipo

---

📗 Autor: Ricardo Jara Gaspar
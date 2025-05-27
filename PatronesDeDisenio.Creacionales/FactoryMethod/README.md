# 🏗️ Factory Method

El patrón **Factory Method** permite delegar la creación de objetos a subclases específicas, promoviendo flexibilidad y desacoplamiento. Este patrón proporciona una interfaz para crear objetos en una superclase, pero permite que las subclases alteren el tipo de objetos que se crearán.

---

## ❓ ¿Para qué sirve?
- Para permitir que una clase delegue la instanciación a subclases.
- Para evitar el acoplamiento directo con clases concretas.
- Para crear objetos en tiempo de ejecución basados en condiciones dinámicas.

---

## ⏱️ ¿Cuándo usarlo?
- Cuando el código debe trabajar con interfaces y no con implementaciones concretas.
- Cuando una clase no puede anticipar qué clase de objetos debe crear.
- Cuando la lógica de creación debe variar según contexto, configuración o entrada del usuario.

---

## 📁 Estructura del patrón

```
Product        -> Interfaz o clase abstracta común (INotificacion, IValidadorDocumento)
ConcreteProduct -> Implementaciones concretas (NotificacionEmail, ValidadorFactura)
Creator        -> Clase abstracta con método de fábrica (NotificacionFactory)
ConcreteCreator -> Subclases que implementan el método de fábrica (EmailFactory)
```

---

## 📦 Ejemplos incluidos

### 🧪 Ejemplo 1: Notificaciones (básico)
Ubicación: `FactoryMethod/Ejemplo1`

- Crea notificaciones por **Email** o **SMS** según la fábrica seleccionada.
- Demuestra el uso de métodos reutilizables (`EnviarConLog`) en la clase abstracta.
- Se usa en consola y en pruebas con `xUnit`.

### 🏢 Ejemplo 2: Validación de documentos empresariales (real)
Ubicación: `FactoryMethod/Ejemplo2`

- Valida distintos tipos de documentos: **Factura**, **Contrato**, **Memorando**.
- Cada tipo de documento tiene su propio validador con lógica especializada.
- Se selecciona dinámicamente el validador adecuado usando una fábrica.

---

## 🖥️ Uso desde consola

```bash
Seleccione un patrón:
1. Factory Method
2. Salir

> 1

Seleccione ejemplo:
1. Notificación por tipo (Email/SMS)
2. Validación de documento empresarial
```

---

## ✅ Pruebas automatizadas

Cada ejemplo incluye pruebas con `xUnit` que verifican:
- La creación del tipo correcto de objeto
- El uso correcto de los métodos de la interfaz
- La salida esperada por consola

---

📗 Autor: Ricardo Jara Gaspar

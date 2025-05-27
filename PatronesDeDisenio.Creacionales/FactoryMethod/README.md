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

### 📊 Comparativa entre Ejemplo 1 y Ejemplo 2

| Aspecto                      | Ejemplo 1: Notificaciones                            | Ejemplo 2: Validación de Documentos                           |
| ---------------------------- | ---------------------------------------------------- | ------------------------------------------------------------- |
| **Propósito**                | Elegir cómo enviar un mensaje (Email o SMS)          | Validar reglas de negocio según tipo de documento             |
| **Tipo de creación**         | Objeto de tipo `INotificacion`                       | Objeto de tipo `IValidadorDocumento`                          |
| **Complejidad del producto** | Simple, comportamiento directo (`Enviar`)            | Complejo, múltiples validaciones por tipo de documento        |
| **Parámetro del método**     | Solo un `string mensaje`                             | Puede ser un objeto `Documento` con múltiples propiedades     |
| **Tipo de fábrica**          | `NotificacionFactory` → `EmailFactory`, `SmsFactory` | `ValidadorFactoryConcreto` centralizada                       |
| **Uso de subclases**         | Fábricas concretas heredan de `NotificacionFactory`  | Una única clase `ValidadorFactoryConcreto` maneja el switch   |
| **Escenario real**           | Comunicación (SMS/Email)                             | Lógica empresarial, reglas de negocio                         |
| **Contexto típico**          | Servicio o utilitario                                | Validaciones en un sistema transaccional (ERP, trámite, etc.) |
| **Nivel de abstracción**     | Básico / estructural                                 | Empresarial / orientado al dominio                            |
| **Nivel de realismo**        | Ideal para enseñar el patrón                         | Ideal para usar en sistemas reales                            |


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

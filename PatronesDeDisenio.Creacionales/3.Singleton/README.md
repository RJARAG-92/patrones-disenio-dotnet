# 🧱 Singleton

El patrón **Singleton** garantiza que una clase tenga una única instancia y proporciona un punto de acceso global a ella. Es útil cuando se necesita controlar el acceso a recursos compartidos y asegurar una instancia única en toda la aplicación.

---

## ❓ ¿Para qué sirve?
- Para asegurar que una clase tenga solo una instancia en todo el sistema.
- Para proporcionar un acceso global controlado a esa instancia.
- Para mantener un estado único o centralizado que sea consistente.

---

## ⏱️ ¿Cuándo usarlo?
- Cuando solo debe existir una instancia de una clase en toda la aplicación (por ejemplo, un logger, configuración global, etc.).
- Cuando varias partes del sistema necesitan compartir el mismo objeto.
- Cuando se requiere control estricto sobre la creación de objetos.

---

## 📁 Estructura del patrón

```
Singleton -> Clase con constructor privado y acceso estático controlado
Cliente -> Utiliza la instancia única a través del método de acceso estático
```

---

## 📦 Ejemplos incluidos

### 🧪 Ejemplo 1: Notificaciones (básico)
Ubicación: `Singleton/1.ModuleLoggerCentralizado`

- Implementa un logger compartido por múltiples servicios como `ServicioPago` y `ServicioNotificacion`.
- Cada llamada a `Logger.Instance.Log(...)` registra el mensaje con marca de tiempo.
- La clase `Logger` es inmutable, segura y perezosa (`Lazy<T>`).
- Ideal para centralizar la trazabilidad de eventos en aplicaciones de consola o backend.

---

## 🖥️ Uso desde consola

```bash
Seleccione un patrón:
1. Factory Method
2. Abstract Factory 
3. Singleton

> 3

Seleccione ejemplo:
1. Logger Centralizado
2. 
3. 
```

---

## ✅ Pruebas automatizadas

Cada ejemplo incluye pruebas con `xUnit` que verifican:
- La creación del tipo correcto de objeto
- El uso correcto de los métodos de la interfaz
- La salida esperada por consola

---

## 👤 Autor

**Ricardo Jara Gaspar**  
Ingeniero de Software especializado en .NET y Arquitectura de Software  
[GitHub](https://github.com/RJARAG-92) · [LinkedIn](https://www.linkedin.com/in/ricardo-jara-gaspar-b7a515265/) · 🇵🇪 Perú
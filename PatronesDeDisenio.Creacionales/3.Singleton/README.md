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

### 🧪 Ejemplo 1: Logger Centralizado
Ubicación: `Singleton/1.ModuleLoggerCentralizado`

- Implementa un logger compartido por múltiples servicios como `ServicioPago` y `ServicioNotificacion`.
- Cada llamada a `Logger.Instance.Log(...)` registra el mensaje con marca de tiempo.
- La clase `Logger` es inmutable, segura y perezosa (`Lazy<T>`).
- Ideal para centralizar la trazabilidad de eventos en aplicaciones de consola o backend.

### ⚙️ Ejemplo 2: Configuración Global  
Ubicación: `Singleton/2.ModuleConfiguracionGlobal`

- Simula acceso centralizado a parámetros de configuración como cadena de conexión, entorno y flags de logging.
- `ConfiguracionGlobal.Instance` permite consultar desde cualquier clase.
- Usado por `ServicioInicio` y `ServicioConexion`.

### 👤 Ejemplo 3: Gestor de Sesión de Usuario  
Ubicación: `Singleton/3.ModuleSessionManager`

- Controla el inicio y cierre de sesión del usuario actual en toda la aplicación.
- `SessionManager.Instance.UsuarioActual` es consultado por distintos servicios.
- Simula una sesión única accesible desde distintos puntos.

### 📦 Ejemplo 4: Gestor de Caché en Memoria  
Ubicación: `Singleton/4.ModuleMemoryCacheManager`

- Implementa un sistema simple de caché en memoria con `Guardar`, `Obtener`, `Eliminar` y `Limpiar`.
- Compartido por `ServicioProducto` y `ServicioCliente`.
- Simula un comportamiento similar a `IMemoryCache` para apps pequeñas o locales.

- ### 🆔 Ejemplo 5: Generador de Identificadores Únicos  
Ubicación: `Singleton/5.ModuleUniqueIdGenerator`

- Genera identificadores secuenciales y únicos, protegidos con `lock` para concurrencia.
- Compartido por `ServicioTicket` y `ServicioDocumento`.
- Útil para simular códigos únicos sin depender de base de datos.

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
2. Configuración Global 
3. Gestor de Sesión de Usuario  
4. Gestor de Caché en Memoria
5. Generador de Identificadores Únicos
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
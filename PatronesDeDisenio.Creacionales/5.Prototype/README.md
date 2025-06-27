# 🧬 Prototype

El patrón **Prototype** permite crear nuevos objetos copiando instancias existentes (prototipos), en lugar de instanciarlos desde cero. Es útil cuando la creación es costosa o los objetos requieren una configuración compleja.

---

## ❓ ¿Para qué sirve?

- Para clonar objetos configurados previamente sin depender de constructores complejos.
- Para mejorar el rendimiento cuando crear instancias nuevas es costoso.
- Para facilitar la creación de variantes a partir de una plantilla base.

---

## ⏱️ ¿Cuándo usarlo?

- Cuando necesitas múltiples objetos similares con pequeñas variaciones.
- Cuando la inicialización de un objeto involucra muchos pasos o recursos.
- Cuando deseas evitar la duplicación de lógica de construcción.

---

## 📁 Estructura del patrón

```
Prototype -> Interfaz con método Clonar()
ConcretePrototype -> Implementación que usa MemberwiseClone()
Cliente -> Usa el prototipo y lo clona según necesidad
```

---

## 📦 Ejemplos incluidos

### 🧾 Ejemplo 1: Plantillas de Documentos
Ubicación: `Prototype/1.ModulePlantillaDocumento`

- Define estructuras base para **contratos** y **solicitudes**.
- Permite clonar documentos y adaptarlos rápidamente a nuevos contextos.
- Útil en sistemas de RRHH, legales o administrativos.

---

### 💻 Ejemplo 2: Producto Configurado (Laptop)
Ubicación: `Prototype/2.ModuleProductoConfigurado`

- Crea variantes de un producto base (Laptop X1) como **modelo gamer** o **modelo económico**.
- Útil en tiendas virtuales o sistemas de configuración de productos.

---

### 👥 Ejemplo 3: Usuario Perfilado
Ubicación: `Prototype/3.ModuleUsuarioPerfilado`

- Clona un perfil base para crear roles como **Administrador** o **Auditor**.
- Permite reutilizar permisos y modificar solo lo necesario por perfil.
- Aplicable en sistemas CRM, intranets o ERP.

---

### 🌐 Ejemplo 4: Configuración por Ambiente
Ubicación: `Prototype/4.ModuleConfiguracionAmbiente`

- Parte de una configuración base para generar variantes para **QA** o **Producción**.
- Se ajustan URLs, módulos activos y flags de debug.
- Ideal en despliegues automatizados o configuraciones CI/CD.

---

### 📧 Ejemplo 5: Plantilla de Email
Ubicación: `Prototype/5.ModulePlantillaEmail`

- Clona una plantilla base de email para notificaciones como **bienvenida**, **recuperación de contraseña**, o **campañas**.
- Se personaliza solo destinatario, asunto o cuerpo.
- Útil en sistemas de comunicación automatizada.

---

## 🖥️ Uso desde consola

```
Seleccione patrón:

5. Prototype

> 5

Seleccione ejemplo:
1. Plantillas de Documentos
2. Producto Configurado (Laptop)
3. Usuario Perfilado
4. Configuración de Ambientes
5. Plantilla de Email
```

---

## ✅ Pruebas automatizadas

Cada ejemplo puede ser adaptado para pruebas automatizadas de sus productos:
- Verificar que se crean instancias correctas según la fábrica.
- Comprobar que los métodos producen las salidas esperadas.

---


## 👤 Autor

**Ricardo Jara Gaspar**  
Ingeniero de Software especializado en .NET y Arquitectura de Software  
[GitHub](https://github.com/RJARAG-92) · [LinkedIn](https://www.linkedin.com/in/ricardo-jara-gaspar-b7a515265/) · 🇵🇪 Perú
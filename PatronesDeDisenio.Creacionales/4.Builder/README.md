# 🧱 Builder

El patrón **Builder** permite construir objetos complejos paso a paso, separando su construcción de su representación final.  
Es útil cuando un objeto tiene múltiples partes opcionales o configuraciones variables.

---

## ❓ ¿Para qué sirve?

- Para construir estructuras complejas de forma controlada.
- Para reutilizar el proceso de construcción con diferentes representaciones del objeto final.
- Para mantener código limpio y mantenible cuando la inicialización directa sería engorrosa.

---

## ⏱️ ¿Cuándo usarlo?

- Cuando necesitas crear objetos con múltiples configuraciones posibles.
- Cuando el proceso de construcción debe ser reutilizable o variar dependiendo del contexto.
- Cuando desees aplicar separación de responsabilidades entre el cliente y la creación de un objeto.

---

## 📁 Estructura del patrón

```
Builder -> Interfaz para construir partes del producto
ConcreteBuilder -> Implementación específica para construir el objeto
Director -> Orquesta los pasos de construcción
Product -> Objeto final que se desea construir
Cliente -> Solicita al director la construcción del objeto
```

---

## 📦 Ejemplos incluidos

### 🍔 Ejemplo 1: Combos de Restaurante
Ubicación: `Builder/1.ModuleComboRestaurante`

- Permite construir combos personalizados con hamburguesa, papas y bebida.
- Separa el proceso de armado del combo de los ingredientes concretos.
- Ejemplo práctico aplicable a sistemas de pedidos o POS.

---

### 🏠 Ejemplo 2: Generador de Reportes
Ubicación: `Builder/2.ModuleReportBuilder`

- Construye reportes financieros, operativos o de auditoría.
- Define paso a paso: título, cuerpo de datos, resumen y pie de página.
- Aplicable en sistemas empresariales, BI o automatización de informes.

---

### 📃 Ejemplo 3: Contrato Legal Empresarial
Ubicación: `Builder/3.ModuleContratoBuilder`

- Permite construir contratos de tipo **Laboral**, **Alquiler** y **Servicios**.
- Cada contrato tiene encabezado, cláusulas, condiciones especiales, firma y anexos.
- Muy útil en áreas legales, recursos humanos o sistemas documentales automatizados.

---

### ⚙️ Ejemplo 4: Configuración por Entorno
Ubicación: `Builder/4.ModuleConfiguracionEntorno`

- Construye configuraciones distintas para entornos **Dev**, **QA** y **Producción**.
- Define parámetros como cadena de conexión, rutas de logs y nivel de debug.
- Muy utilizado en despliegues, DevOps y CI/CD.

---

### 📄 Ejemplo 5: Generador de Documentos Oficiales
Ubicación: `Builder/5.ModuleDocumentoBuilder`

- Construye documentos tipo **Carta**, **Solicitud** o **Informe** paso a paso.
- Cada builder define encabezado, cuerpo, referencias, firmas y pie legal.
- Ideal para sistemas de gestión documental, entidades públicas o sector legal.

---

## 🖥️ Uso desde consola

```
Seleccione patrón:

4. Builder

> 4

Seleccione ejemplo:
1. Combos de Restaurante
2. Generador de Reportes
3. Contratos Personalizados
4. Configuración por Entorno
5. Generador de Documento Oficial
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
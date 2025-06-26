# 🧱 Abstract Factory

El patrón **Abstract Factory** proporciona una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas. Es útil cuando el sistema debe ser independiente de cómo se crean, componen y representan sus objetos.

---

## ❓ ¿Para qué sirve?

- Para encapsular la creación de múltiples objetos relacionados que deben usarse en conjunto.
- Para asegurar la coherencia entre productos que pertenecen a la misma familia.
- Para desacoplar la lógica de uso de la lógica de instanciación.

---

## ⏱️ ¿Cuándo usarlo?

- Cuando necesitas crear familias de productos sin acoplar el código a clases concretas.
- Cuando el sistema debe trabajar con distintos grupos de objetos, dependiendo del contexto (por ejemplo, múltiples proveedores, motores de bases de datos, temas visuales, etc.).
- Cuando la creación de los objetos está estrechamente relacionada y debe ser coordinada.

---

## 📁 Estructura del patrón

```
AbstractFactory      -> Interfaz para crear familias de productos relacionados
ConcreteFactory      -> Implementaciones concretas que producen variantes de los productos
AbstractProduct      -> Interfaz común para cada tipo de producto
ConcreteProduct      -> Implementaciones concretas de los productos
Cliente              -> Usa la fábrica abstracta y productos sin conocer las clases concretas
```

---

## 📦 Ejemplos incluidos

### 🧪 Ejemplo 1: Pasarelas de Pago
Ubicación: `AbstractFactory/1.ModulePasarelaPago`

- Crea un `CheckoutService` capaz de trabajar con **PayPal** o **Stripe** sin cambiar la lógica del cliente.
- Cada pasarela implementa su propio `IPaymentProcessor` y `IReceiptGenerator`.

---

### 🧠 Ejemplo 2: Conexiones a bases de datos
Ubicación: `AbstractFactory/2.ModuleConexionBD`

- Simula una conexión a **SQL Server** o **PostgreSQL** usando fábricas abstractas.
- Proporciona objetos `IDbConnection`, `IDbCommand`, `IDbReader` sin conocer la implementación exacta.

---

### 🖥️ Ejemplo 3: Interfaces gráficas multiplataforma (GUI)
Ubicación: `AbstractFactory/3.ModuleGuiMultiplataforma`

- Simula una aplicación que debe funcionar en **Windows** y **Linux**.
- Cada sistema tiene su propia fábrica que crea botones y cuadros de texto específicos.
- Se puede ampliar fácilmente para incluir nuevos sistemas operativos o componentes GUI.

---
### 📈 Ejemplo 4: Informes financieros por región
Ubicación: `AbstractFactory/4.ModuleInformeFinanciero`

- Genera reportes financieros adaptados a **Europa**, **Latinoamérica** y **Asia**.
- Cada región produce encabezados, cálculos y pies de página personalizados.
- Aplica lógica contable y normativa distinta según la ubicación geográfica.

---

### 📊 Ejemplo 5: Sistema de reportes exportables (empresarial real)
Ubicación: `AbstractFactory/5.ModuleExportadorReportes`

- Exporta reportes en formatos **PDF**, **Excel** y **HTML**.
- Cada formato implementa su propia lógica de:
  - Generación de contenido (`IReportBuilder`)
  - Exportación (`IExportService`)
  - Gráficos (`IChartGenerator`)
- Ideal para sistemas empresariales que requieren informes dinámicos.

---

## 🖥️ Uso desde consola

```
Seleccione patrón:
1. Factory Method
2. Abstract Factory
3. Singleton

> 2

Seleccione ejemplo:
1. Pasarela de Pago (PayPal / Stripe)
2. Conexión a Base de Datos (SQL Server / PostgreSQL)
3. Interfaz Gráfica Multiplataforma
4. Informes financieros por región
5. Sistema de reportes exportables
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
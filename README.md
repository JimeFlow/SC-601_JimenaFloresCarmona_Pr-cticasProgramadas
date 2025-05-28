# **Tarea Programada 1 - Golden Ratio y Fibonacci**

## **Universidad Fidélitas**  
**Curso:** SC-601 - Programación Avanzada 

**Profesor:** Rojas Matey, Luis Andrés 
**Estudiante FH23014559:** Flores Carmona, Jimena 

**Laboratorio:** M (6PM - 9PM) 
**Grupo:** No. 9 
**Cuatrimestre:** II - 2025  

**Fecha de Entrega:** Miércoles 28 de mayo 2025, 6pm

---

## **Introducción**  
El **Golden Ratio** (letra griega φ) es una constante matemática (~1.618) que aparece en la naturaleza, el arte y la arquitectura. Puede calcularse mediante una fórmula matemática o aproximarse con la **Secuencia de Fibonacci**, dividiendo términos consecutivos.

En esta tarea, se implementará un programa en **C#** para calcular **φ** de dos maneras distintas y comparar la precisión de cada método.

---

## **Objetivo**  
1️⃣ Familiarizarse con el lenguaje **C#**, el entorno **.NET Framework** y el IDE **Visual Studio**.  
2️⃣ Implementar un programa en consola que calcule el **Golden Ratio** utilizando dos técnicas diferentes.  
3️⃣ Evaluar la diferencia entre los métodos y su precisión matemática.  

---

## **Especificaciones Funcionales**  
Al ejecutar el programa, se solicitará al usuario un número entero **n** en el rango de **2 a 45**. Luego, se mostrarán tres secciones en la consola:  

1️⃣ **Cálculo de φ mediante la fórmula:**  
\[
\phi = \frac{1 + \sqrt{5}}{2} \approx 1.618033988749895
\]

2️⃣ **Aproximación de φ con Fibonacci:** Se calcularán las razones entre términos consecutivos de la **Secuencia de Fibonacci** hasta n, junto con la diferencia absoluta respecto a la fórmula matemática.  

3️⃣ **Valores de Fibonacci:** Se mostrarán los valores **Fib(n)** y **Fib(n-1)**.  

---

## **Ejemplo de Salida**  
### Entrada válida donde n = 5.
![image](https://github.com/user-attachments/assets/2aa0e3d1-a2aa-4168-92d0-cd1a5b656448)

---

## Especificaciones Técnicas
- Implementación en **C# (.NET Framework 4.8.1)** con **Visual Studio Community 2022**.
- Uso de un **algoritmo iterativo** para calcular Fibonacci.
- Tipos de datos recomendados: `int` para enteros y `double` para valores flotantes.

---

## Entregables
El archivo **TP1-FH12345678.zip** comprimido `.ZIP` debe contener los siguientes archivos:
- **Program.cs** → Código fuente del programa.
- **README.md** → Este documento con la explicación detallada.

---

# Recursos Utilizados
## Repositorio del proyecto: 
 Link:
 
## Referencias y documentación
  1. Se exploro la mayoría de la información colocando en el buscador "Golden Ratio Fibonacci in Visual Studio 2022 C#"
  2. Algoritmo Serie Fibonacci C#: https://youtu.be/IGhsaPGgLyA?si=ihoT6BApNjUT7-SZ
  3. Markdown para hacer el README.md: https://www.markdownguide.org/getting-started/
  4. Guía Markdown: https://github.com/mattcone/markdown-guide/blob/master/README.md
  
## Prompts de las consultas a chatbots de IA: _Copilot_
### **🔹 Tarea Programada 1 - Golden Ratio**
#### **📌 Descripción de la consulta**  
El usuario solicita ayuda para desarrollar un programa en **C# con .NET Framework en Visual Studio Community 2022** que calcule el **Golden Ratio** utilizando la fórmula matemática y la secuencia de Fibonacci.

#### **✅ Solución propuesta**
1. **Solicitar un número entero entre 2 y 45.**  
   - Validar que la entrada sea numérica (`int.TryParse()`).
   - Asegurar que `n` esté dentro del rango correcto (`if (n >= 2 && n <= 45)`).

2. **Calcular el Golden Ratio mediante la fórmula:**  
   ```csharp
   double phi = (1 + Math.Sqrt(5)) / 2;
   Console.WriteLine($"Phi ~ {phi:F15}");
   ```

3. **Implementar la secuencia de Fibonacci iterativamente:**  
   - Guardar valores previos (`Fib(n-1)`) y actuales (`Fib(n)`).
   - Evitar el uso de recursión para mayor eficiencia.
   ```csharp
   static List<long> FibonacciCalculator(int n)
   {
       List<long> fibValues = new List<long> { 0, 1 };
       for (int i = 2; i <= n; i++)
       {
           fibValues.Add(fibValues[i - 1] + fibValues[i - 2]);
       }
       return fibValues;
   }
   ```

4. **Calcular la aproximación de Phi mediante Fibonacci:**  
   ```csharp
   double phiApprox = (double)fibNumbers[i] / fibNumbers[i - 1];
   double difference = Math.Abs(phiApprox - phi);
   Console.WriteLine($"Fib({i}) / Fib({i - 1}) ~ {phiApprox:F15} [+- {difference:F15}]");
   ```

5. **Mostrar los valores finales de Fibonacci (`Fib(n)` y `Fib(n-1)`).**  
   ```csharp
   Console.WriteLine($"Fib({n}) = {fibNumbers[n]}");
   Console.WriteLine($"Fib({n - 1}) = {fibNumbers[n - 1]}");
   ```

#### **🔹 Mejoras aplicadas al código del usuario**
✔ **Corrección en la validación de entrada.**  
✔ **Uso de `List<long>` en lugar de arrays estáticos.**  
✔ **Refactorización del método `FibonacciCalculator()`.**  
✔ **Corrección de errores tipográficos en nombres de métodos.**  
✔ **Optimización en la impresión de resultados.**  

#### **⏳ Tiempo estimado de desarrollo**
Aproximadamente **2 a 4 horas**, dependiendo del nivel de experiencia con C# y Visual Studio.

#### **📌 Problemas y soluciones**
1. **Error en la referencia `Microsoft.CodeDom.Providers.DotNetCompilerPlatform`**  
   - Solución: Reinstalar paquete con NuGet y verificar dependencias en `.csproj`.

2. **Advertencia en Visual Studio**  
   - Solución: Limpiar y reconstruir el proyecto (`Compilar > Limpiar solución`).

3. **Errores en la validación del número ingresado**  
   - Corrección: Cambiar `||` por `&&` en `if (n >= 2 && n <= 45)`.

---



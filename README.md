#  L'ENDROMEDÉ - Sistema de Gestión de Lociones y Perfumería

[![Universidad](https://img.shields.io/badge/Universidad-Dr._Andr%C3%A9s_Bello-red.svg)](https://unab.edu.sv/)
[![Materia](https://img.shields.io/badge/Asignatura-Programaci%C3%B3n_II-blue.svg)](#)
[![Estado](https://img.shields.io/badge/Estado-En_Desarrollo-green.svg)](#)

Sistema de información y gestión comercial desarrollado para la marca de fragancias y lociones **L'ENDROMEDÉ**. El sistema abarca el control de inventarios, catálogo interactivo de productos, registro de ventas presenciales y en línea, administración de clientes, seguimiento de pedidos y generación de reportes analíticos



##  Tabla de Contenidos
- [Descripción del Proyecto](#-descripción-del-proyecto)
- [Características Principales](#-características-principales)
- [Requerimientos del Sistema](#-requerimientos-del-sistema)
  - [Requerimientos Funcionales](#requerimientos-funcionales)
  - [Requerimientos No Funcionales](#requerimientos-no-funcionales)
- [Roles de Usuario](#-roles-de-usuario)
- [Modelo de Datos y Arquitectura](#-modelo-de-datos-y-arquitectura)
- [Información Académica y Créditos](#-información-académica-y-créditos)



##  Descripción del Proyecto

**L'ENDROMEDÉ** es una marca dedicada a la comercialización de lociones y fragancias diseñadas para hombres, mujeres y niños, ofreciendo una amplia variedad de aromas, presentaciones y tamaños.

Este sistema ha sido diseñado con el objetivo de optimizar la administración y organización interna de la empresa, garantizando:
- Control automatizado de existencias e inventario (entradas, salidas y alertas de stock bajo o agotado).
- Procesamiento eficiente de ventas multicanal (tienda física y pedidos en línea).
- Experiencia de usuario fluida mediante una interfaz web responsiva e intuitiva.
- Centralización de la información de clientes, pedidos y reportes estratégicos.



##  Características Principales

1. **Gestión de Catálogo (CRUD Completo):**
   - Alta, consulta, modificación y baja de fragancias según categoría, aroma, precio y tamaño.
2. **Control de Inventario en Tiempo Real:**
   - Monitoreo continuo de *stock* disponible, alertas por bajo nivel de inventario y registro de movimientos.
3. **Gestión de Ventas y Pedidos:**
   - Módulo para ventas presenciales (caja) y canal de pedidos en línea para clientes.
   - Seguimiento del estado del pedido (Registrado, En Proceso, Entregado).
4. **Administración de Clientes:**
   - Registro de información personal y direcciones para entregas a domicilio.
5. **Módulo de Reportes:**
   - Generación de reportes periódicos de ventas, nivel de inventarios, productos más vendidos y estado de pedidos.
# L'ENDROMEDÉ - Sistema de Gestión de Lociones y Perfumería

Sistema de información y gestión comercial desarrollado para la marca de fragancias y lociones **L'ENDROMEDÉ**

. El sistema abarca el control de inventario, catálogo interactivo de productos, registro de ventas presenciales y en línea, administración de clientes, seguimiento de pedidos y generación de reportes analíticos


## Tabla de Contenidos
1. [Descripción del Proyecto](#descripción-del-proyecto)
2. [Características Principales](#características-principales)
3. [Requerimientos del Sistema](#requerimientos-del-sistema)
   - [Requerimientos Funcionales](#requerimientos-funcionales)
   - [Requerimientos No Funcionales](#requerimientos-no-funcionales)
4. [Roles de Usuario](#roles-de-usuario)
5. [Arquitectura de Base de Datos](#arquitectura-de-base-de-datos)
6. [Información Académica y Créditos](#información-académica-y-créditos)

---

## Descripción del Proyecto

**L'ENDROMEDÉ** es una marca dedicada a la comercialización de lociones y fragancias diseñadas para hombres, mujeres y niños, ofreciendo una variedad de aromas, presentaciones y tamaño.

Este sistema fue diseñado para optimizar la administración y organización interna de la empresa mediante:

* Control automatizado de existencias e inventario (entradas, salidas y alertas de stock bajo o agotado).
* Procesamiento eficiente de ventas multicanal (tienda física y pedidos en línea)
* Experiencia de usuario interactiva y adaptable a diversos dispositivos
* Centralización de la información de clientes, pedidos y reportes estratégicos
  

## Características Principales

* **Gestión de Catálogo (CRUD):** Registro, consulta, modificación y baja de productos organizados por categoría, aroma, precio y tamaño
  
* **Control de Inventario:** Monitoreo continuo de stock disponible, alertas de bajo inventario y registro de movimientos
  
* **Módulo de Ventas y Pedidos:** Procesamiento de ventas presenciales (caja) y pedidos en línea con seguimiento del estado de entrega
  
* **Gestión de Clientes:** Registro de datos personales y direcciones de envío
  
* **Generación de Reportes:** Reportes detallados de ventas, inventario y productos



## Requerimientos del Sistema

### Requerimientos Funcionales

| Código | Descripción |
| :--- | :--- |
| **RF01** | Permitir registrar productos agregando nombre, aroma, tamaño, categoría, precio y cantidad disponible). |
| **RF02** | Consultar y visualizar el catálogo de lociones disponibles

| **RF03** | Modificar la información de los productos registrados

| **RF04** | Eliminar o deshabilitar productos que ya no estén disponibles para la venta
|
| **RF05** | Controlar el inventario registrando entradas y salidas de productos

| **RF06** | Registrar clientes con sus datos personales y dirección de entrega

| **RF07** | Registrar y gestionar ventas realizadas de forma presencial o en línea.
|
| **RF08** | Permitir a los clientes realizar pedidos seleccionando productos y cantidades.
|
| **RF09** | Consultar y actualizar el estado de los pedidos desde su registro hasta su entrega.
|
| **RF10** | Generar reportes de ventas, inventario, productos y pedidos

### Requerimientos No Funcionales

| Código | Descripción |
| :--- | :--- |
| **RNF01** | Interfaz intuitiva, clara y fácil de utilizar|
| **RNF02** | Tiempos de respuesta rápidos al realizar consultas y operaciones|
| **RNF03** | Garantizar la seguridad de la información almacenada|
| **RNF04** | Autenticación y control de acceso según roles de usuario |
| **RNF05** | Mantener la integridad y consistencia de los datos registrados |
| **RNF06** | Compatibilidad con los principales navegadores web actuales. |
| **RNF07** | Adaptación correcta a computadoras, tabletas y dispositivos móviles (diseño responsivo) |
| **RNF08** | Alta disponibilidad durante el horario de funcionamiento de la empresa. |
| **RNF09** | Código mantenible que permita futuras actualizaciones e incorporación de módulos |



## Roles de Usuario

* **Administrador:** Gestión del catálogo de productos, registro de usuarios, control total de inventarios y consulta de reportes.
  
* **Cajero:** Registro de ventas presenciales y emisión de comprobantes/reportes de caja.
  
* **Cliente:** Registro de cuenta, consulta del catálogo, realización de pedidos en línea y seguimiento de compras.



## Arquitectura de Base de Datos

El sistema implementa un modelo relacional compuesto por las siguientes tablas principales:

* `Usuarios` y `Clientes
  
* `Productos` e `Inventario
  
* `Ventas` y `DetalleVenta
  
* `Pedidos` y `DetallePedido`
  
* `Reportes`



## Información Académica y Créditos

* **Institución:** Universidad Dr. Andrés Bello (Regional Chalatenango)
  
* **Facultad:** Tecnología e Innovación
  
* **Asignatura:** Programación II (Grupo 1)
  
* **Catedrático:** Ing. Julio Cesar Monge Rauda
  
* **Fecha:** 25/08/2026

### Equipo de Desarrollo:

* Carlos Rubén Avelar
  
* Steven Gerrard Valle
  
* Boris Raynaldo Garcia
  
* Luis Angel Escobar
  
* Romel Jose Mancia
  
* Alisom Naomi Casco

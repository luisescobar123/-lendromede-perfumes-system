#  L'ENDROMEDÉ - Sistema de Gestión de Lociones y Perfumería

[![Universidad](https://img.shields.io/badge/Universidad-Dr._Andr%C3%A9s_Bello-red.svg)](https://unab.edu.sv/)
[![Materia](https://img.shields.io/badge/Asignatura-Programaci%C3%B3n_II-blue.svg)](#)
[![Estado](https://img.shields.io/badge/Estado-En_Desarrollo-green.svg)](#)

Sistema de información y gestión comercial desarrollado para la marca de fragancias y lociones **L'ENDROMEDÉ**[span_1](start_span)[span_1](end_span). El sistema abarca el control de inventarios, catálogo interactivo de productos, registro de ventas presenciales y en línea, administración de clientes, seguimiento de pedidos y generación de reportes analíticos[span_2](start_span)[span_2](end_span).



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

**L'ENDROMEDÉ** es una marca dedicada a la comercialización de lociones y fragancias diseñadas para hombres, mujeres y niños, ofreciendo una amplia variedad de aromas, presentaciones y tamaños[span_3](start_span)[span_3](end_span).

Este sistema ha sido diseñado con el objetivo de optimizar la administración y organización interna de la empresa, garantizando:
- Control automatizado de existencias e inventario (entradas, salidas y alertas de stock bajo o agotado)[span_4](start_span)[span_4](end_span).
- Procesamiento eficiente de ventas multicanal (tienda física y pedidos en línea)[span_5](start_span)[span_5](end_span).
- Experiencia de usuario fluida mediante una interfaz web responsiva e intuitiva[span_6](start_span)[span_6](end_span).
- Centralización de la información de clientes, pedidos y reportes estratégicos[span_7](start_span)[span_7](end_span).



##  Características Principales

1. **Gestión de Catálogo (CRUD Completo):**
   - Alta, consulta, modificación y baja de fragancias según categoría, aroma, precio y tamaño[span_8](start_span)[span_8](end_span).
2. **Control de Inventario en Tiempo Real:**
   - Monitoreo continuo de *stock* disponible, alertas por bajo nivel de inventario y registro de movimientos[span_9](start_span)[span_9](end_span).
3. **Gestión de Ventas y Pedidos:**
   - Módulo para ventas presenciales (caja) y canal de pedidos en línea para clientes[span_10](start_span)[span_10](end_span).
   - Seguimiento del estado del pedido (Registrado, En Proceso, Entregado)[span_11](start_span)[span_11](end_span).
4. **Administración de Clientes:**
   - Registro de información personal y direcciones para entregas a domicilio[span_12](start_span)[span_12](end_span).
5. **Módulo de Reportes:**
   - Generación de reportes periódicos de ventas, nivel de inventarios, productos más vendidos y estado de pedidos[span_13](start_span)[span_13](end_span).



##  Requerimientos del Sistema

### Requerimientos Funcionales

| Código | Descripción |
| :--- | :--- |
| **RF01** | Registrar productos agregando nombre, aroma, tamaño, categoría, precio y cantidad disponible[span_14](start_span)[span_14](end_span). |
| **RF02** | Consultar y visualizar el catálogo de lociones disponibles[span_15](start_span)[span_15](end_span). |
| **RF03** | Modificar la información de los productos registrados[span_16](start_span)[span_16](end_span). |
| **RF04** | Eliminar productos que ya no estén disponibles para la venta[span_17](start_span)[span_17](end_span). |
| **RF05** | Controlar el inventario registrando entradas y salidas de productos[span_18](start_span)[span_18](end_span). |
| **RF06** | Registrar clientes con datos personales y dirección de entrega[span_19](start_span)[span_19](end_span). |
| **RF07** | Registrar y gestionar ventas realizadas de forma presencial o en línea[span_20](start_span)[span_20](end_span). |
| **RF08** | Permitir a los clientes realizar pedidos seleccionando productos y cantidades[span_21](start_span)[span_21](end_span). |
| **RF09** | Consultar y actualizar el estado de los pedidos desde su registro hasta la entrega[span_22](start_span)[span_22](end_span). |
| **RF10** | Generar reportes de ventas, inventario, productos y pedidos[span_23](start_span)[span_23](end_span). |

### Requerimientos No Funcionales

| Código | Descripción |
| :--- | :--- |
| **RNF01** | Interfaz intuitiva, clara y fácil de utilizar[span_24](start_span)[span_24](end_span). |
| **RNF02** | Tiempos de respuesta rápidos en consultas y operaciones[span_25](start_span)[span_25](end_span). |
| **RNF03** | Garantía de seguridad e integridad de la información almacenada[span_26](start_span)[span_26](end_span). |
| **RNF04** | Sistema de autenticación y control de acceso basado en roles[span_27](start_span)[span_27](end_span). |
| **RNF05** | Mantener la consistencia e integridad referencial de los datos[span_28](start_span)[span_28](end_span). |
| **RNF06** | Compatibilidad con los principales navegadores web actuales[span_29](start_span)[span_29](end_span). |
| **RNF07/08** | Diseño adaptativo para computadoras, tabletas y dispositivos móviles[span_30](start_span)[span_30](end_span). |
| **RNF09** | Disponibilidad durante el horario de funcionamiento de la empresa[span_31](start_span)[span_31](end_span). |
| **RNF10** | Mantenibilidad y facilidad para incorporar futuras actualizaciones[span_32](start_span)[span_32](end_span). |



##  Roles de Usuario

* **Administrador:** Registrar productos, modificar información de catálogo, registrar usuarios y supervisión general[span_33](start_span)[span_33](end_span).
* **Cajero:** Registrar ventas y generar reportes de transacciones[span_34](start_span)[span_34](end_span).
* **Cliente:** Iniciar sesión, realizar pedidos y consultar estado de compras[span_35](start_span)[span_35](end_span).



##  Información Académica y Créditos

* **Institución:** Universidad Dr. Andrés Bello (Regional Chalatenango)[span_36](start_span)[span_36](end_span)
* **Facultad:** Tecnología e Innovación[span_37](start_span)[span_37](end_span)
* **Asignatura:** Programación II (Grupo 1)[span_38](start_span)[span_38](end_span)
* **Catedrático:** Ing. Julio Cesar Monge Rauda[span_39](start_span)[span_39](end_span)
* **Fecha:** 25/08/2026[span_40](start_span)[span_40](end_span)

###  Equipo de Desarrollo:
- Carlos Rubén Avelar[span_41](start_span)[span_41](end_span)
- Steven Gerrard Valle[span_42](start_span)[span_42](end_span)
- Boris Raynaldo Garcia[span_43](start_span)[span_43](end_span)
- Luis Angel Escobar[span_44](start_span)[span_44](end_span)
- Romel Jose Mancia[span_45](start_span)[span_45](end_span)
- Alisom Naomi Casco[span_46](start_span)[span_46](end_span)


# 🛍️ Sistema de Gestión de Productos y Categorías

Este proyecto consiste en una aplicación full-stack para la gestión de productos y sus categorías. Está compuesta por:

- Un frontend Angular
- Dos microservicios backend en Spring Boot:
  - API de Productos
  - API de Categorías
- Una base de datos MySQL

Toda la aplicación es orquestada y ejecutada mediante Docker Compose.

---

## 📁 Estructura del Proyecto

```
/frontend-gestion
/backend-products
/backend-categorias
/docker-compose.yml
/README.md
```

---

## 🚀 Tecnologías Utilizadas

| Componente         | Tecnología                     |
|--------------------|--------------------------------|
| Frontend           | Angular 17                     |
| Backend Products   | Spring Boot + JPA + MySQL      |
| Backend Categorías | Spring Boot + JPA + MySQL      |
| Base de datos      | MySQL                          |
| Contenedores       | Docker + Docker Compose        |

---

## ⚙️ Configuración del Entorno

### 🐋 Requisitos Previos

- Docker instalado
- Docker Compose
- Git

---

## 🔧 Cómo Ejecutar el Proyecto

### 1️⃣ Clonar el Repositorio

```bash
git clone 
cd tu-repositorio
```

### 2️⃣ Levantar la Aplicación con Docker Compose

```bash
docker compose up --build
```

Esto levantará los siguientes servicios:

- Frontend Angular en http://localhost:4200
- Backend Productos en http://localhost:8081/api/products
- Backend Categorías en http://localhost:8082/api/categories
- Base de datos MySQL en localhost:3307 (usuario: root, pass: admin123)

---

## 📦 Endpoints Principales

### 📌 Productos - http://localhost:8081/api/products

| Método | Endpoint          | Descripción                |
|--------|-------------------|----------------------------|
| GET    | /                 | Obtener todos los productos |
| POST   | /                 | Crear un nuevo producto     |
| GET    | /{id}             | Obtener producto por ID     |
| PUT    | /{id}             | Actualizar un producto      |
| DELETE | /{id}             | Eliminar un producto        |

### 📌 Categorías - http://localhost:8082/api/categories

| Método | Endpoint          | Descripción                 |
|--------|-------------------|-----------------------------|
| GET    | /                 | Obtener todas las categorías |
| POST   | /                 | Crear una nueva categoría    |
| GET    | /{id}             | Obtener categoría por ID     |
| PUT    | /{id}             | Actualizar una categoría     |
| DELETE | /{id}             | Eliminar una categoría       |

---

## 🧪 Probar la API

Puedes utilizar Postman para probar los endpoints. Aquí tienes ejemplos de payloads para crear:

### ✅ Producto

```json
{
  "name": "Mouse inalámbrico",
  "description": "Mouse con conexión Bluetooth",
  "price": 24.99
}
```

### ✅ Categoría

```json
{
  "name": "Accesorios de Computadora",
  "description": "Periféricos y accesorios para PC"
}
```

---

## 🐞 Problemas Comunes

- Si tienes un error al conectar con MySQL, asegúrate de que los contenedores estén en la misma red (`test-network`) y el puerto sea el correcto.
- Verifica las variables de entorno para DB_HOST y PORT en los servicios Spring Boot.

---

## 🤝 Contribuciones

¡Las contribuciones son bienvenidas! Si deseas colaborar:

1. Haz un fork del repositorio
2. Crea una nueva rama
3. Realiza tus cambios
4. Haz un pull request

---

## 📜 Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.

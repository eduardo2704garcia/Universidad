# 🧩 App Categorías - Imagen Docker

Este módulo contiene la aplicación Spring Boot **App Categorías** empacada en una imagen Docker lista para desplegarse en cualquier entorno compatible con contenedores.

---

## 🚀 Requisitos Previos

- Docker instalado [https://docs.docker.com/get-docker/](https://docs.docker.com/get-docker/)
- Cuenta en Docker Hub
- (Opcional) Maven si deseamos compilar sin Docker

---

## 🏗️ Construir la Imagen Docker

Debemos asegurarnos de que el archivo `Dockerfile` esté en la raíz del módulo `app`. Luego ejecutamos:

```bash
docker build -t img-app-categorias:V1 .

### Ejecutar el contenedor

Podemos levantar la aplicación mapeando el puerto deseado. Ejemplo usando la red test-network y una base de datos externa:

```bash
docker run -dit -p 8003:8082 --name c-app-categorias --network test-network -e DB_HOST=test-db:3306 -e PORT=8082 img-app-categorias:V1

---

## 📤 Subir la Imagen a Docker Hub

### Iniciamos  sesión en Docker Hub:
```bash
docker login

### Etiquetamos la imagen con nuestro nombre de usuario:
```bash
docker tag img-app-categorias:V1 eduardo2704garcia/app-categorias:V1

### Realizamos el push:
```bash
docker push eduardo2704garcia/app-categorias:V1

---

## 🌐 Probar en Postman o en la Red
http://localhost:8082/categories


---

## Resumen de comandos

```bash
mvn clean package
docker build -t img-app-categorias:V1 .
docker run -dit -p 8003:8082 --name c-app-categorias --network test-network -e DB_HOST=test-db:3306 -e PORT=8082 img-app-categorias:V1
docker login
docker tag img-app-categorias:V1 eduardo2704garcia/app-categorias:V1
docker push eduardo2704garcia/app-categorias:V1
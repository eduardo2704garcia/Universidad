# Dockerfile
## Etapa 1: Build de Angular
FROM node:20-alpine AS builder
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build -- --configuration production

## Etapa 2: Servidor Nginx
FROM nginx:alpine
COPY --from=builder /app/dist/P2_PC2_GarciaE/browser /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
server {
  listen 80;
  server_name localhost;

  root /usr/share/nginx/html;
  index index.html;

  location ~* \.(js|mjs|css|json|ico|png|jpg|jpeg|gif|svg|woff|woff2|ttf|eot|otf)$ {
    try_files $uri =404;
    access_log off;
    add_header Cache-Control "public, max-age=31536000";
  }

  location / {
    try_files $uri $uri/ /index.html;
  }
}
## Etapa 3: .dockerignore
node_modules
dist
.git
.gitignore
.angular
.vscode
Dockerfile
docker-compose.yml
README.md
*.log

## Etapa 4: Comandos para probar, subir y crear la imagen

### Creación de la imagen
docker build -t eduardo2704garcia/p2_pc2_garciae:v1 .
### Probar en el local
docker run -p 8082:80 --rm img-p2_pc2_garciae
### Subir a dockerhub
docker login
docker push eduardo2704garcia/p2_pc2_garciae:v1


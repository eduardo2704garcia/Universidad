# ATLAS - Proyecto Angular 19 (Standalone + Signals)

Aplicación web desarrollada con Angular 19 que permite explorar y participar en programas de voluntariado comunitario. Utiliza las últimas características del framework como **componentes standalone** y **Angular signals** para una experiencia moderna, reactiva y modular.

---

## Características principales

- Navegación fluida entre páginas usando **Angular Router**
- Componentes 100% **standalone**
- Estado reactivo con **Signals** (`signal`, `computed`)
- Diseño moderno, visualmente atractivo y adaptable (responsive)
- Gestión de participantes por programa con botones para incrementar/disminuir
- Secciones adicionales como contacto, perfil, donaciones y bienvenida

---

## Estructura del proyecto

```
src/
├── app/
│   ├── pages/
│   │   ├── home/           → Carpeta de bienvenida (contiene los componentes WelcomePage, Nav y Footer)
│   │   ├── pages/          → Carpeta de paginas (contiene los componentes volunteering y donations para hacer el forms y donaciones)
│   │   ├── products/       → Carpeta de programas (contiene la imformacion de los programas activos usando componentes card y list acopaldos con signals)
│   │   ├── user/           → Carpeta de gerente (tiene toda la inforamcion del gerente de la página)
│   ├── app.routes.ts       → Definición de rutas
│   └── app.ts              → Root component con RouterOutlet
```

---

## Tecnologías utilizadas

- **Angular 19 (standalone)**
- **Signals API** (`signal()`, `computed()`)
- **HTML + CSS personalizado**
- **Routing modular (SPA)**
- **Public organizados (imágenes en `/public/images`)**

---

## 🛠️ Instrucciones de instalación

1. Clona el repositorio:
```bash
git clone (https://github.com/eduardo2704garcia/Universidad/edit/RamaEduardo/P2_PP2_GarciaE)
```

2. Instala las dependencias:
```bash
npm install
```

3. Corre el servidor de desarrollo:
```bash
ng serve
```

4. Abre tu navegador en:
```
http://localhost:4200/
```

---

## Páginas del proyecto

### Home (`/home`)
- Página de bienvenida con imagen de fondo
- Botones para redireccionar a voluntariado y contacto
- Navbar y footer adaptativos y visualmente atractivos

### Voluntariado (`/pages/volunteering`)
- Lista de programas disponibles
- Cada programa tiene nombre, descripción, imagen y contador de participantes
- Botones para sumar o restar participantes usando `signal()`

### Usuario (`/user/info`)
- Información personal del usuario voluntario

### Contacto (`/user/contact`)
- Formulario de registro y contacto
- Campos básicos: nombre, email, mensaje

### Donaciones (`/pages/donations`)
- Sección para realizar donaciones
- Input para monto y botón de acción

---

## Ejemplo de uso de Signals

```ts
participants = signal(0);
total = computed(() => participants() * 10);

increment() {
  participants.update(p => p + 1);
}
```

---

## Ideas futuras

- Autenticación de usuarios (voluntarios)
- Backend para registrar participantes reales
- Dashboard de estadísticas con signals
- Soporte multilenguaje

---

## Autor

> Eduardo García  
> Angular Developer - P2_PP2_García_E  
> `@eduag.047`

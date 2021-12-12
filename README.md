# ISIS 4814 - Proyecto final - ReciclaYa

Aprende a reciclar de forma fácil y divertida.

![reciclaya](https://user-images.githubusercontent.com/55302468/145698368-c9f7e135-1959-454e-ace1-c88205e0b96e.png)

*Logo de reciclaje por Krdan, Dominio Público, via Wikimedia Commons*

## Sobre el proyecto

---

### Hecho por

- Juan Camilo Useche - jc.useche10@uniandes.edu.co
- Daniel Fernando Useche - df.useche@uniandes.edu.co
- Joshua Manolo Olave - jm.olave@uniandes.edu.co
- Camilo Esteban Rozo - ce.rozob@uniandes.edu.co

### Hecho con

- [Unity](https://unity.com/es)

### Descripción

*Recicla ya* es un juego en el que el objetivo es aprender a clasificar residuos correctamente entre residuos aprovechables no orgánicos, aprovechables orgánicos, y residuos no aprovechables. Para lograrlo, se inicia con una fase de tutorial, en la que el usuario es guiado por ls mecánicas del juego y se le explican los residuos que pueden haber y dónde se deben depositar para ser reciclados. Después, se le introduce el sistema de puntaje y contaminación, donde el puntaje aumenta y la contaminación disminuye conforme el usuario va depositando los residuos en los lugares adecuados. Del mismo modo, se le explica que clasificar incorrectamente los residuos no reducirá el puntaje actual pero sí aumentará la contaminación del ambiente. En dado caso que la contaminación sea demasiado alta, el juego terminará.

### Características

- Fase de entrenamiento donde se explica la metodología del juego y cómo clasificar residuos.
- Fase de juego que pone a prueba al usuario, cuya tarea es lanzar un residuo en la caneca correspondiente.
- Sistema de puntaje visisble en forma de "puntos" por anotar residuos y en el umbral de contaminación.
- Entrenamiento narrado por voz para evitar tener que leer las instrucciones.
- Residuos y canecas realistas que se asemejan a los que se presentarían en un caso real.
- dificultad agregada con canecas en movimiento.

## Instalación

---

### Pre-requisitos para desarrollo

- Unity Hub

  - [Instalación de Unity Hub](https://unity.com/es/download)

- Unity Editor Versión 2020.3.1f1

  - Instalar con Unity Hub 
    - URL: unityhub://2020.3.1f1/77a89f25062f
  - [Descargar para Windows](https://download.unity3d.com/download_unity/77a89f25062f/UnityDownloadAssistant-2020.3.1f1.exe)
  - [Descargar para MacOS](https://download.unity3d.com/download_unity/77a89f25062f/UnityDownloadAssistant-2020.3.1f1.dmg)

- Cliente Git

  - [Descargar](https://git-scm.com/downloads)
  - [Descargar GitHub Desktop](https://desktop.github.com/)
  - [Descargar GitKraken](https://www.gitkraken.com/download)

### Instalación para desarrollo

1. En Git

   - Clonar el repositorio de GitHub

   ```bash
   git clone https://github.com/Cerozob/ISIS4814-202120-ProyectoFinal-ReciclaYa.git
   ```
   
2. En Unity Hub:

   - Abrir Unity Hub

   - Seleccionar la pestaña "Projects"
 
![selecttab](https://user-images.githubusercontent.com/55302468/140423330-5a63a823-5175-4e9d-b42d-4633cf6301cc.png)

   - Usar el botón "ADD" y seleccionar la carpeta donde se clonó el repositorio.

![addbutton](https://user-images.githubusercontent.com/55302468/140423385-49f3bdd6-ff41-4f34-ae32-5207006a6a4c.png)

![selectfolderunity](https://user-images.githubusercontent.com/55302468/145699563-709f38bb-4ba6-4617-b947-e1fb14120186.png)

   - Seleccionar el proyecto agregado.
     - En este caso, el proyecto tiene el nombre de "VRTestProyect"
     - Asegurarse de que el proyecto tiene asignada la versión de Unity *2020.3.1f1*.

![reassureversion](https://user-images.githubusercontent.com/55302468/145699692-3e5df21e-31af-4485-8650-ce406190e24c.png)

#### Desplegar el proyecto desde Unity

1. Conectar un HMD Oculus al computador
2. En Unity Editor
   - Seleccionar la pestaña "File"
   
![filetab](https://user-images.githubusercontent.com/55302468/145699744-691b659f-a344-400c-a7da-e2e562aabc4b.png)

   - En el menú desplegado seleccionar la opción "Build Settings"

![image](https://user-images.githubusercontent.com/55302468/140439396-1c324bab-fd54-49ed-b876-32dca92124e1.png)

   - En el cuadro de diálogo seleccionar la plataforma Android.

![selectandroid](https://user-images.githubusercontent.com/55302468/140437717-316618f5-a2a7-4b8a-9d4c-a0b0d52ed94f.png)

   - En la opción de "Run Device", abrir la lista desplegable y elegir el HMD que se encuentra conectado.

![oculustdropdown](https://user-images.githubusercontent.com/55302468/140437836-98b0e277-46e6-46aa-9b6b-035c70eb18b1.png)

   - En la parte superior, únicamente seleccionar la escena "Scenes/VRTestScene"

![image](https://user-images.githubusercontent.com/55302468/140437900-a09f4788-08a3-4d57-8f91-a797d2c1ae16.png)

   - Seleccionar "Build and run".

![image](https://user-images.githubusercontent.com/55302468/140438024-5b5a4923-de98-4be3-8ea0-83695b88d8d8.png)

### Pre-requisitos para despliegue

- Cualquier HMD, de preferencia Oculus (Go, Quest, Quest 2) [_Probado en un Oculus Quest 2_]
- Archivo APK
  - [Descargar](https://github.com/Cerozob/ISIS4814-202120-ProyectoFinal-ReciclaYa/releases/download/v1.0/reciclaya.apk)

### Instalación para despliegue

- Opción 1: desplegar directamente a un HMD
  - [Guía de instalación para un Oculus Quest 2](https://headjack.io/knowledge-base/how-to-easily-sideload-a-vr-app-to-oculus-quest-2/)
  - [Guía de instalación para un Oculus Go](https://headjack.io/tutorial/sideload-install-app-apk-oculus-go-quest/)  
- Opción 2: desplegar desde Unity Editor:
  - [Ver Guía de instalación y despliegue para desarrollo](#instalación-para-desarrollo)

## Ejemplos de uso

---

- [Video de ejemplo 1](https://www.youtube.com/watch?v=hEyqFmwu4b4)

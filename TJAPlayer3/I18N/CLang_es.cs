using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FDK;

namespace TJAPlayer3
{
    internal class CLang_es : ILang
    {
        string ILang.GetString(int idx)
        {
            if (!dictionnary.ContainsKey(idx))
                return "[!] No se ha encontrado el índice en el diccionario.";

            return dictionnary[idx];
        }


        private static readonly Dictionary<int, string> dictionnary = new Dictionary<int, string>
        {
            [0] = "Cambia el idioma que se usa\n en el juego y menús.",
            [1] = "Idioma del sistema",
            [2] = "<< Volver al menú",
            [3] = "Volver al menú de la izquierda.",
            [4] = "Recargar lista de canciones",
            [5] = "Recarga y actualiza la lista de canciones.",
            [6] = "Número de jugadores",
            [7] = "Cambia el número de jugadores.\nAjustarlo a 2 permite jugar\n canciones regulares a dos jugadores dividiendo\n la pantalla a la mitad.",
            [8] = "Modo Kanpeki",
            [9] = "Modo Kanpeki:\nElige el número de fallos antes de\n que se considere un intento fallido.\nDejar en 0 para deshabilitar el modo Kanpeki.",
            [10] = "Velocidad de la canción",
            [11] = "Cambia la velocidad de la canción.\n" +
                "Por ejemplo, puedes jugar a mitad de\n" +
                " velocidad ajustando el valor PlaySpeed = 0.500\n" +
                " para practicar.\n" +
                "\n" +
                "Nota: También cambia el tono de la canción.\n" +
                "Si Time Stretch está encendido, puede haber\n" +
                " lag de audio si se usa en menos de x0.9.",
            [12] = "Nivel de la IA",
            [13] = "Determina que tan precisa es la IA.\n" +
                "Si se deja en 0, se desactiva.\n" +
                "Si se deja en 1 o más,\n el J2 se convierte en IA.\n" +
                "No se usa si Juego Automático J2\n se encuentra activado.",
            [14] = "Compensación global de sonido",
            [15] = "Cambia el retardo de la canción\npara todos los charts.\n" +
                "Puedes elegir entre -99 a 99ms.\n" +
                "Para disminuir el retraso de la entrada,\n disminuye este valor.\n\n" +
                "Nota: Recarga las canciones para\n" +
                "     aplicar los cambios.",
            [16] = "Tipo de interfaz",
            [17] = "Puedes cambiar la interfaz de las canciones\n mostradas en la pantalla de selección.\n" +
                "0 : Regular (Diagonal de arriba hacia abajo)\n" +
                "1 : Vertical\n" +
                "2 : Diagonal de abajo hacia arriba\n" +
                "3 : Medio circulo hacia la derecha\n" +
                "4 : Medio circulo hacia la izquierda",
            [18] = "No se está seguro de que hace esto.\nUsa más capacidad de la CPU,\n y causa lag si la velocidad de juego está\nen menos de x0.9.",
            [19] = "Modo de ventana o pantalla completa.",
            [20] = "Ajuste que proviene de DTXMania.\nEn OpenTaiko este no hace nada.",
            [21] = "Activar el uso de subcarpetas en la\n SELECCIÓN ALEATORIA.",
            [22] = "Activa la sincronización vertical.\nActivarlo limitará los FPS a 60, aumentará\nel retraso de entrada y suavizará el desplazamiento.\nDesactivarlo no limitará los FPS,\ndisminuirá el retraso de la entrada pero\nel desplazamiento se verá afectado.",
            [23] = "Usar la reproducción AVI o no.",
            [24] = "Activar BGA (animaciones de fondo) o no.",
            [25] = "Tiempo de retraso(ms) para empezar a reproducir la\ndemo de la música en la pantalla\nSELECCIONAR CANCIÓN.\nPuedes especificar de 0ms a 10000ms",
            [26] = "Ajuste que proviene de DTXMania.\nEn OpenTaiko este no hace nada.",
            [27] = "Si está activado se mostrará información extra en\nla zona de BGA. (FPS, BPM, tiempo total, etc)\nPuedes activar o desactivar los indicadores\npresionando [Del] mientras juegas.",
            [28] = "Ajuste del grado de transparencia del fondo.\n\n0=completamente transparente,\n255=sin transparencia",
            [29] = "Desactívalo si no quieres que\nse reproduzca música de fondo.",
            [30] = "Guarda tus récords en el juego.\nDesactívalo si prefieres que tus puntajes no\nse guarden automáticamente.\n",
            [31] = "Ajuste relacionado con BS1770GAIN\n y por lo mismo, inutilizable.",
            [32] = "Ajuste relacionado con BS1770GAIN\n y por lo mismo, inutilizable.",
            [33] = "Actívalo para usar el valor SONGVOL desde\n el .tja, Desactívalo si quieres usar los\ncontroles de volumen del juego.",
            [34] = "Ajusta el volumen de los efectos de sonido.\nDebes reiniciar el juego después de salir\nde la configuración para aplicar los cambios",
            [35] = "Ajusta el volumen de las voces de Don-Chan.\nDebes reiniciar el juego después de salir\nde la configuración para aplicar los cambios",
            [36] = "Ajusta el volumen de la música.\nDebes reiniciar el juego después de salir\nde la configuración para aplicar los cambios",
            [37] = "La cantidad de volumen que cambia\nal presionar las teclas de control de volumen.\nPuedes especificar desde 1 a 20.",
            [38] = "Tiempo antes de que la música comience. (ms)\n",
            [39] = "Si activas esto, se tomará una captura\n cuando obtengas un nuevo récord.",
            [40] = "Comparte la información del .tja que estas\n jugando en Discord.",
            [41] = "Cuando se activa, la entrada no tendrá pérdidas,\n pero la tasa de actualización de la entrada será menor.\nCuando se desactiva, pueden haber entradas perdidas\n pero se actualizarán con más frecuencia.",
            [42] = "Actívalo para guardar info. de depuración\n en TJAPlayer3.log cuando cierres el juego.\nAquí se guarda información del rendimiento y\n eventuales errores del simulador.",
            [43] = "ASIO:\nSolo funciona en dispositivos compatibles con ASIO.\nTiene la menor latencia de entrada.\n\nWasapi:\nDesactiva cualquier otra fuente de sonido.\nTiene la segunda menor latencia de entrada.\n\nDirect Sound:\nPermite sonido desde otras fuentes.\nTiene la mayor latencia de entrada.\n" +
                "\n" +
                "Nota: Sal de la configuración\n" +
                "     para aplicar los cambios.",
            [44] = "Cambia el buffer de sonido para Wasapi.\nDeja el número más bajo posible\n evitando problemas como congelamiento de la canción y\n timing incorrecto. Déjalo en 0 para usar un valor\n estimado, o encuentra el valor correcto para ti a base de\nprueba y error." +
                "\n" +
                "Nota: Sal de la configuración\n" +
                "     para aplicar los cambios.",
            [45] = "Dispositivo ASIO:\n" +
                    "Elige el dispositivo de audio usado con ASIO\n" +
                    "\n" +
                    "Note: Sal de la configuración\n" +
                "     para aplicar los cambios.",
            [46] = "Usar esto puede hacer que las notas se vean\n más suaves, pero puede haber lag de sonido.\nNo usarlo va a hacer que las notas se vean inestables,\n pero sin ningún tipo de lag.\n" +
                "\n" +
                "Este ajuste solo está disponible\n" +
                " usando WASAPI o ASIO.\n",
            [47] = "Mostrar imágenes del Personaje.\n",
            [48] = "Mostrar imágenes de Dancer.\n",
            [49] = "Mostrar imágenes de Mob.\n",
            [50] = "Mostrar imágenes de Runner.\n",
            [51] = "Mostrar imagen del Footer.\n",
            [52] = "Usar texturas pre-renderizadas.\n",
            [53] = "Mostrar imágenes del Puchi-Chara.\n",
            [54] = "Elige una skin desde la carpeta de skins.",
            [55] = "Menú secundario para cambiar las teclas que\nusa el juego.",
            [56] = "Juego automático",
            [57] = "Al activarlo, el carril de J1\n" +
                " se jugará automáticamente.",
            [58] = "Juego Automático J2",
            [59] = "Al activarlo, el carril de J2\n" +
                " se jugará automáticamente.",
            [60] = "Velocidad del redoble",
            [61] = "Redobles por segundo cuando se usa el\nmodo automático.\nNo tiene efecto en los globos.\nDesactivado si está en 0,\nbloqueado a un redoble por frame.",
            [62] = "VelDesplazamiento",
            [63] = "Cambiar la velocidad de desplazamiento\n" +
                " en el carril de las notas\n" +
                "Puedes ajustarlo desde x0.1 a x200.0.\n" +
                "(ScrollSpeed=x0.5 sería la mitad de velocidad)",
            [64] = "Modo Kanpeki",
            [65] = "Modo Kanpeki:\nElige el número de fallos antes de\n que se considere un intento fallido.\nDejar en 0 para deshabilitar el modo Kanpeki.",
            [66] = "Notas aleatorias",
            [67] = "Las notas Don y Ka se aleatorizan.\nCon las opciones que hay puedes cambiar la tasa\n de aleatorización.",
            [68] = "Notas ocultas",
            [69] = "DORON: Las notas están ocultas.\n" +
                "STEALTH: Las notas y el texto debajo están ocultos.",
            [70] = "Sin información",
            [71] = "Oculta la información de la canción.\n",
            [72] = "Modo estricto",
            [73] = "Solo permite las notas buenas, convirtiendo\nlas OK en fallos.",
            [74] = "Bloqueo de notas",
            [75] = "Activa si golpear en espacios vacíos\ncuenta como una falla.",
            [76] = "Combo mínimo",
            [77] = "Número mínimo para mostrar el combo\n" +
                "en el tambor.\n" +
                "Puedes elegir desde 1 a 99999.",
            [78] = "Ajuste del área de juicio",
            [79] = "Para cambiar la área del circulo de juicio de las notas.\nAumentarlo moverá la área a la derecha, y disminuirlo\n la moverá a la izquierda.\n" +
                "Puedes dejarlo desde -99 a 99ms.\n" +
                "Para disminuir el lag de la entrada,\n deja un valor negativo.",
            [80] = "Dificultad por defecto",
            [81] = "Dificultad seleccionada por defecto.\n",
            [82] = "Modo de puntuación",
            [83] = "Elige el método para calcular la puntuación\n" +
                    "TYPE-A: Puntuación de Gen-1\n" +
                    "TYPE-B: Puntuación de Gen-2\n" +
                    "TYPE-C: Puntuación de Gen-3\n",
            [84] = "Hace que todas las notas\n valgan los mismos puntos.\nUsa la fórmula de Gen-4.",
            [85] = "Guía de divisiones",
            [86] = "Activa una guía numérica para ver\n que división se elegirá.\nNo se muestra en modo automático.",
            [87] = "Animación de división",
            [88] = "Tipo de animación para las divisiones\n" +
                    "TYPE-A: Animación de Gen-2\n" +
                    "TYPE-B: Animación de Gen-3\n" +
                    " \n",
            [89] = "Modo de supervivencia",
            [90] = "Esta opción no funciona.\nImplementa un contador parecido al de Stepmania,\n pero el código está incompleto así que su\n funcionamiento es limitado.",
            [91] = "Considerar notas grandes",
            [92] = "Requerir usar los dos lados para golpear las\n notas grandes.",
            [93] = "Mostrar conteo de notas",
            [94] = "Mostrar el conteo de las notas\n" +
                "(Solo en modo de un jugador)",
            [95] = "Ajustes de controles",
            [96] = "Ajustes de los botones/pads que se usarán.",
            [97] = "Captura",
            [98] = "Botón para capturar:\nPara asignar una tecla a la captura de pantalla.\n (Solo puedes usar el teclado. No puedes\nusar un pad del tambor para tomar capturas.",
            [99] = "Rojo izquierdo",
            [10000] = "Asigna un botón o un pad para\n el Don (rojo) izquierdo.",
            [10001] = "Rojo derecho",
            [10002] = "Asigna un botón o un pad para\nel Don (rojo) derecho.",
            [10003] = "Azul izquierdo",
            [10004] = "Asigna un botón o un pad para\n el Ka (azul) izquierdo.",
            [10005] = "Azul derecho",
            [10006] = "Asigna un botón o un pad para\n el Ka (azul) derecho.",
            [10007] = "Rojo izquierdo J2",
            [10008] = "Asigna un botón o un pad para\n el Don (rojo) izquierdo del J2.",
            [10009] = "Rojo derecho J2",
            [10010] = "Asigna un botón o un pad para\n el Don (rojo) derecho del J2.",
            [10011] = "Azul izquierdo J2",
            [10012] = "Asigna un botón o un pad para\n el Ka (azul) izquierdo del J2.",
            [10013] = "Azul derecho J2",
            [10014] = "Asigna un botón o un pad para\n el Ka (azul) derecho del J2.",
            [10018] = "TimeStretch",
            [10019] = "Pantalla completa",
            [10020] = "StageFailed",
            [10021] = "Usar subcarpetas en random",
            [10022] = "Sincronización vertical",
            [10023] = "AVI",
            [10024] = "BGA",
            [10025] = "Delay de la demo",
            [10026] = "PreImageWait",
            [10027] = "Informacion Debug",
            [10028] = "Transparencia del fondo",
            [10029] = "Volumen de música de fondo",
            [10030] = "Guardar Puntuación",
            [10031] = "Apply Loudness Metadata",
            [10032] = "Target Loudness",
            [10033] = "Usar SONGVOL",
            [10034] = "Volumen de efectos",
            [10035] = "Volumen de voces",
            [10036] = "Volumen de la música",
            [10037] = "Aumento de volumen",
            [10038] = "Retardo de la música",
            [10039] = "Autoguardar Resultado",
            [10040] = "Enviar info. a Discord",
            [10041] = "Entrada con buffer",
            [10042] = "Guardar registros",
            [10043] = "Sistema de sonido",
            [10044] = "Tamaño del buffer WASAPI",
            [10045] = "Dispositivo ASIO",
            [10046] = "Usar timer del sistema",
            [10047] = "Mostrar Personaje",
            [10048] = "Mostrar Dancer",
            [10049] = "Mostrar Mob",
            [10050] = "Mostrar Runner",
            [10051] = "Mostrar Footer",
            [10052] = "Renderizado Rápido",
            [10053] = "Mostrar Puchi-Chara",
            [10054] = "Skin (Full)",
            [10055] = "Teclas del sistema",
            [10056] = "Ocultar Dans/Torres",
            [10057] = "Ocultar charts de Dans y torres\nen el menú de Modo Taiko.\n" +
                    "Nota: Recarga las canciones para\n" +
                "     aplicar los cambios.",
            [10058] = "Volumen de la demo",
            [10059] = "Ajusta el volumen de la demo de la música.\nDebes reiniciar el juego después de salir\nde la configuración para aplicar los cambios",
            [10084] = "Modo Shinuchi",

            [100] = "Modo Taiko",
            [101] = "Dan-i Dojo",
            [102] = "Torres Taiko",
            [103] = "Tienda",
            [104] = "Aventura Taiko",
            [105] = "Mi Habitación",
            [106] = "Ajustes",
            [107] = "Salir",

            [150] = "¡Juega tus canciones\nfavoritas a tu propio gusto!",
            [151] = "¡Juega varias canciones mientras cumples\nretos que te pondrán a prueba\npara completar el desafío!",
            [152] = "¡Juega canciones largas con un\nnúmero de vidas limitado y llega\na la punta de la torre!",
            [153] = "¡Compra nuevas canciones, PuchiCharas o personajes\nusando las medallas que ganaste jugando!",
            [154] = "¡Atraviesa varios obstáculos y\ndesbloquea nuevo contenido!",
            [155] = "¡Cambia la información de tu placa\n o el aspecto de tu personaje!",
            [156] = "¡Cambia tu estilo de juego\n o ajustes generales!",
            [157] = "Salir del juego.\n¡Hasta la próxima!",
            
            [200] = "Regresar",
            [201] = "Canciones jugadas recientemente",
            [202] = "¡Juega las canciones que jugaste recientemente!",
            [203] = "Canción aleatoria",

            [1000] = "Piso alcanzado",
            [1001] = "P",
            [1002] = "P",
            [1003] = "Puntuación",
            
            [1010] = "Indicador de almas",
            [1011] = "Cantidad de Perfectas",
            [1012] = "Cantidad de OK",
            [1013] = "Cantidad de Malas",
            [1014] = "Puntuación",
            [1015] = "Cantidad de redobles",
            [1016] = "Cantidad de golpes",
            [1017] = "Combo",
            [1018] = "Precisión",

            [1030] = "Regresar",
            [1031] = "Puchi-Chara",
            [1032] = "Personaje",
            [1033] = "Título de Dan",
            [1034] = "Título de la placa",
            
            [90000] = "[ERROR] Condicion no valida",
            [90001] = "Item solamente disponible en la tienda.",
            [90002] = "Precio: ",
            [90003] = "Item comprado!",
            [90004] = "Monedas insuficientes!",
            [90005] = "Esta condición: ",
        };
    }
}

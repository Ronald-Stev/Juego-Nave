internal class Program
{
    static int p1x = 11, q1x = 10, q2x = 12, p1y = 8, p2x = 40, p2y = 8, p3x = 80, p3y = 8, cord = 0, px = 3;
    static int perror1, perror2, perror3, serror1, serror2, serror3, life = 3, level = 1;
    static int xNave = 53, yNave = 22;
    static int xRect1 = 29, yRect1 = 2, xRect2 = 5, yRect2 = 5, xRect3 = 45, yRect3 = 5, xRect4 = 85, yRect4 = 5;
    static int consoleWidth = Console.WindowWidth;
    static int consoleHeight = Console.WindowHeight;
    static int marcoAncho = consoleWidth - 1, marcoAlto = consoleHeight, xMarco = 0, yMarco = 0;

    static string[,] preguntas = new string[16, 4] {
        { "Cálcula el área de un triángulo base=8cm, altura= 6cm  ", "24                 ", "48                ", "28                " },
        { "Cálcula el resultado de la siguiente operación: 10+4/2 ", "14                 ", "12                ", "7                 " },
        { "Cálcula la siguiente operación: -2+(10*4)/2            ", "20                 ", "19                ", "18                " },
        { "Cálcula la siguiente operación: 25/5-3                 ", "2                  ", "11                ", "5                 " },
        { "Cálcula la siguiente operación 2*4/4+6*10-5            ", "34                 ", "75                ", "57                " },
        { "Resuelve la ecuación:  2x + 5 = 13                     ", "9                  ", "4                 ", "3                 " },
        { "Resuelve la ecuación:  3x - 7 = 5x + 1                 ", "4                  ", "10                ", "-4                " },
        { "Resuelve la ecuación:  5x + 3 = 8x - 7                 ", "10/3               ", "-10/3             ", "5                 " },
        { "Resuelve la ecuación: 3x - x - 2x = 2 - 3 + 1          ", "2                  ", "x                 ", "0                 " },
        { "Resuelve la ecuación: 2x + 4 = (5 * 8)/2               ", "20                 ", "8                 ", "4                 " },
        { "Cálcule la derivada de f(x)= x^2 + 2                   ", "2x                 ", "2x + 2            ", "2                 " },
        { "Cálcule la derivada de f(x)= 3x^2 + 2x - 1             ", "6x+2x              ", "6x+2x             ", "6x+2              " },
        { "Cálcule la derivada de f(x)= 2x^3 + 3x^2 + 4x + 1      ", "6x^2+6x+4          ", "6x^2+6x+4x        ", "6x^2+6x+4x+1      " },
        { "Cálcule la derivada de f(x)=  4xy^3 + y^3*x^3 +5c      ", "f(x)=4y^2+y^3*3x   ", "f(x)=4y^3+y^3*3x^2", "f(x)=4y^2+3y^2*3x " },
        { "Cálcule la derivada de f(x)= sen(x^3 + 2x)             ", "(3x^2+2)Cos(x^3+2x)", "Cos(x^3+2x)       ", "(3x^2+2)sen(x^3+2x)" },
        { "", "", "", "" }};
    static int[,] valores = {
    { 11, 10, 12 },    { 48, 47, 49 },   { 88, 87, 89},   { 11, 10, 12 },      { 88, 87, 89  },
    { 48, 47, 49 },    { 88, 87, 89},    { 11, 10, 12 },   { 88, 87, 89  },  { 48, 47, 49 },
    { 11, 10, 12 },   { 88, 87, 89  },    { 11, 10, 12 },   { 48, 47, 49 },   { 11, 10, 12 }, { 0, 0,0  }
    };
    static int[,] valores_erroneos1 = {
    { 48, 47, 49 },    {11, 10, 12},   { 11, 10, 12},   { 48, 47, 49 },      { 48, 47, 49 },
    {11, 10, 12  },    { 11, 10, 12 },    {  48, 47, 49 },   { 11, 10, 12 },  { 88, 87, 89 },
    {48, 47, 49 },   { 48, 47, 49  },    { 48, 47, 49 },   { 11, 10, 12 },   { 88, 87, 89}, { 0, 0, 0 }
};
    static int[,] valores_erroneos2 = {
    { 88, 87, 89 },    { 88, 87, 89 },   { 48, 47, 49},   {88, 87, 89  },      { 11, 10, 12  },
    { 88, 87, 89  },    { 48, 47, 49},    { 88, 87, 89  },   { 48, 47, 49 },  { 11, 10, 12 },
    {  88, 87, 89 },   { 11, 10, 12  },    { 88, 87, 89 },   { 88, 87, 89 },   {  48, 47, 49  }, { 0, 0, 0 }
};
    const int anchoObjetos = 4;
    static int navex = marcoX1 + 11, navey = marcoY2 - anchoObjetos;
    const int marcoX1 = 0, marcoY1 = 0, marcoX2 = 118, marcoY2 = 29;
    public static void Main(string[] args)
    {
        menu();
    }
    static void DibujarRectangulo(int x, int y, int ancho, int alto)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < ancho; i++)
        {
            Console.SetCursorPosition(x + i, y);
            Console.Write("═");
            Console.SetCursorPosition(x + i, y + alto - 1);
            Console.Write("═");
        }
        for (int i = 0; i < alto; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write("║");
            Console.SetCursorPosition(x + ancho - 1, y + i);
            Console.Write("║");
        }
        Console.SetCursorPosition(x, y);
        Console.Write("╔");
        Console.SetCursorPosition(x + ancho - 1, y);
        Console.Write("╗");
        Console.SetCursorPosition(x, y + alto - 1);
        Console.Write("╚");
        Console.SetCursorPosition(x + ancho - 1, y + alto - 1);
        Console.Write("╝");
    }
    static void DibujarMarco(int x, int y, int ancho, int alto)
    {
        for (int i = 0; i < ancho; i++)
        {
            Console.SetCursorPosition(x + i, y);
            Console.Write("═");
            Console.SetCursorPosition(x + i, y + alto - 1);
            Console.Write("═");
        }
        for (int i = 0; i < alto; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write("║");
            Console.SetCursorPosition(x + ancho - 1, y + i);
            Console.Write("║");
        }
        Console.SetCursorPosition(x, y);
        Console.Write("╔");
        Console.SetCursorPosition(x + ancho - 1, y);
        Console.Write("╗");
        Console.SetCursorPosition(x, y + alto - 1);
        Console.Write("╚");
        Console.SetCursorPosition(x + ancho - 1, y + alto - 1);
        Console.Write("╝");
    }
    static void DibujarNave(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine("      A ");
        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine("   < {°} >  ");
        Console.SetCursorPosition(x, y + 2);
        Console.WriteLine("  ± || || ± ");
        Console.SetCursorPosition(x, y + 3);
        Console.WriteLine("     W W  ");
    }
    static void DibujarN(int x, int y)
    {
        Console.SetCursorPosition(x, y - 1);
        Console.WriteLine("             ");
    }
    static void DibujarPosicionesdeDisparo(ref int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine("             =0=                     ");
    }
    static void Disparar(int x, ref int y)
    {
        Console.SetCursorPosition(x + 6, y - 2);
        Console.Write("°");
        Console.SetCursorPosition(x + 6, y - 1);
        Console.Write(" ");
    }
    static void DisparoCasillas(int x, ref int y)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x + 3, y);
        Console.Write("▄");
        Console.SetCursorPosition(x + 9, y);
        Console.Write("▄");
        Console.SetCursorPosition(x + 3, y - 1);
        Console.Write(" ");
        Console.SetCursorPosition(x + 9, y - 1);
        Console.Write(" ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void preguntasLV11(ref int cord, ref int p1x, ref int q1x, ref int q2x, ref int perror1, ref int perror2, ref int perror3, ref int serror1, ref int serror2, ref int serror3)
    {

        if (cord >= 0 && cord < valores.GetLength(0))
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(33, 3);
            Console.WriteLine(preguntas[cord, 0]);
            Console.SetCursorPosition(15, 6);
            Console.WriteLine(preguntas[cord, 1]);
            Console.SetCursorPosition(50, 6);
            Console.WriteLine(preguntas[cord, 2]);
            Console.SetCursorPosition(90, 6);
            Console.WriteLine(preguntas[cord, 3]);
            perror1 = valores_erroneos1[cord, 0];
            perror2 = valores_erroneos1[cord, 1];
            perror3 = valores_erroneos1[cord, 2];
            serror1 = valores_erroneos2[cord, 0];
            serror2 = valores_erroneos2[cord, 1];
            serror3 = valores_erroneos2[cord, 2];
            p1x = valores[cord, 0];
            q1x = valores[cord, 1];
            q2x = valores[cord, 2];
        }
    }
    static void menu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        estrellita(4, 2);
        estrellita(67, 1);
        estrellita(37, 1);
        estrellita(100, 5);
        estrellita(2, 20);
        estrellita(100, 22);
        estrellita(15, 12);
        estrellita(87, 10);
        estrellita(36, 19);
        estrellita(70, 21);

        Console.WindowHeight = 30;
        Console.ForegroundColor = ConsoleColor.Blue;
        PNAVE(navex, navey);
        Console.ForegroundColor = ConsoleColor.Yellow;
        mmarc(marcoX1, marcoY1, marcoX2, marcoY2);
        int centro = (marcoX1 + marcoX2) / 2;
        int centroY = Console.WindowHeight / 2;
        Console.SetCursorPosition(centro - 8, centroY - 1);
        Console.WriteLine("1. JUGAR");
        Console.SetCursorPosition(centro - 8, centroY);
        Console.WriteLine("2. SALIR");
        Console.SetCursorPosition(centro - 8, centroY + 1);
        Console.WriteLine("3. INFORMACION");
        ConsoleKeyInfo opc = Console.ReadKey();
        if (opc.Key == ConsoleKey.D1)
        {
            Jugar();
        }
        else if (opc.Key == ConsoleKey.D2)
        {
            Console.Clear();
            salir(navex, navey);
            SonidoPerder();
            Thread.Sleep(2000);
        }
        else if (opc.Key == ConsoleKey.D3)
        {
            Console.Clear();
            PNAVE(navex, navey - 4);
            info();
            Console.ReadKey();
            Console.Clear();
            menu();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Opción No Válida. Presione una tecla para continuar. ");
            Console.ReadKey();
            Console.Clear();
            menu();
        }
    }
    static void vida(ref int life)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(109, 1);
        Console.WriteLine($"LIFE: {life} ");
    }
    static void nivelDelJuego(ref int level)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(5, 1);
        Console.WriteLine($"LEVEL: {level} ");
    }
    static void Jugar()
    {
        Console.Clear();
        nivelDelJuego(ref level);
        vida(ref life);
        DibujarMarco(xMarco, yMarco, marcoAncho, marcoAlto);
        DibujarRectangulo(xRect1, yRect1, 60, 3);
        DibujarRectangulo(xRect2, yRect2, 30, 3);
        DibujarRectangulo(xRect3, yRect3, 30, 3);
        DibujarRectangulo(xRect4, yRect4, 30, 3);
        preguntasLV11(ref cord, ref p1x, ref q1x, ref q2x, ref perror1, ref perror2, ref perror3, ref serror1, ref serror2, ref serror3);
        DibujarPosicionesdeDisparo(ref px, p1y);
        DibujarPosicionesdeDisparo(ref p2x, p2y);
        DibujarPosicionesdeDisparo(ref p3x, p3y);



        bool cerrar = true;
        while (cerrar == true)
        {
            LeerEntrada(ref xNave, ref yNave, marcoAncho, marcoAlto, ref cerrar, ref xNave);
        }
        Console.Clear();
    }
    static void salir(int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        mmarc(marcoX1, marcoY1, marcoX2, marcoY2);
        Console.ForegroundColor = ConsoleColor.Yellow;
        string[] salida = {
     "███████ ████  ███████ █████ ███  ███████ █████   ",
     "██      ██  █ ██   ██ ██    ███  ██   ██ ██    ",
     "██   ██ ████  ███████ ██    ███  ███████ █████  ",
     "███████ ██  █ ██   ██ █████ ███  ██   ██ ▄▄▄██   ",
     "                                                  ",
     "████   ███  ████         ██ ██  ██ ██████ ██████ ████            ",
     "██  █ ██ ██ ██  █        ██ ██  ██ ██     ██  ██ ██  █           ",
     "████  ██ ██ ████     ██  ██ ██  ██ ██  ██ ██████ ████            ",
     "██     ███  ██  █     ████   ████  ██████ ██  ██ ██  █ █         "
            };
        for (int i = 0; i < salida.Length; i++)
        {
            Console.SetCursorPosition(x + 25, y - 15 + i);
            Console.Write(salida[i]);
        }
    }
    static void mmarc(int x1, int y1, int x2, int y2)
    {
        for (int c = x1; c <= x2; c++)
        {
            Console.SetCursorPosition(c, y1);
            Console.Write("-");
            Console.SetCursorPosition(c, y2);
            Console.Write("-");
        }
        for (int f = y1; f <= y2; f++)
        {
            Console.SetCursorPosition(x1, f);
            Console.Write("║");
            Console.SetCursorPosition(x2, f);
            Console.Write("║");
        }
        Console.SetCursorPosition(x1, y1);
        Console.Write("╔");
        Console.SetCursorPosition(x1, y2);
        Console.Write("╚");
        Console.SetCursorPosition(x2, y1);
        Console.Write("╗");
        Console.SetCursorPosition(x2, y2);
        Console.Write("╝");
    }
    static void PNAVE(int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        string[] nave = {
     "███   ███  █████████ ███      ███ ███████",
     "█████ ███  ███   ███ ███      ███ ███",
     "███ █████  █████████   ███  ███   █████",
     "███  ████  ███   ███   ███  ███   ███",
     "███   ███  ███   ███     ████     ███████",
         };
        for (int i = 0; i < nave.Length; i++)
        {
            Console.SetCursorPosition(x + 27, y - 19 + i);
            Console.Write(nave[i]);
        }
    }
    static void calcl2(int x, int y)
    {
        string[] cl = {
"██████ ███████ ██     ██████ ██   ██ ██      ██████        ",
"██     ██   ██ ██     ██     ██   ██ ██     ██    ██     ",
"██     ███████ ██     ██     ██   ██ ██     ██    ██     ",
"██     ██   ██ ██   █ ██     ██   ██ ██   █ ██    ██    ",
"██████ ██   ██ ██████ ██████ ███████ ██████  ██████         ",
       };
        for (int i = 0; i < cl.Length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(cl[i]);
        }
    }
    static void nivel2(int x, int y)
    {
        string[] cl = {
"██████ ███   ██ ████████ ██████ ██████  ████    ████ ██████ ██████  ██████   ██████      ",
"  ██   ███   ██    ██    ██     ██   ██ ██ ██ ███ ██ ██     ██   ██   ██    ██    ██ ",
"  ██   ██ █████    ██    █████  █████   ██  ████  ██ █████  ██   ██   ██    ██    ██",
"  ██   ██  ████    ██    ██     ██   ██ ██   ██   ██ ██     ██   ██   ██    ██    ██",
"██████ ██   ███    ██    ██████ ██   ██ ██        ██ ██████ ██████  ██████   ██████     ",
       };
        for (int i = 0; i < cl.Length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(cl[i]);
        }
    }
    static void nivel3(int x, int y)
    {
        string[] nv3 = {
" ███████ ██    ██ ███████ ███   ██ █████ ███████ ██████   ██████        ",
" ██   ██ ██    ██ ██   ██ ██ █  ██    ██ ██   ██ ██   ██ ██    ██         ",
" ███████ ██    ██ ███████ ██  █ ██   ██  ███████ ██   ██ ██    ██",
" ██   ██  ██  ██  ██   ██ ██  ████  ██   ██   ██ ██   ██ ██    ██ ",
" ██   ██   ████   ██   ██ ██   ██  █████ ██   ██ ██████   ██████         ",
       };
        for (int i = 0; i < nv3.Length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(nv3[i]);
        }
    }
    static void borrarfiguras(int x, int y)
    {
        string[] cl = {
        "                                                                                    ",
        "                                                                                    ",
        "                                                                                    ",
        "                                                                                    ",
        "                                                                                    "
    };
        for (int i = 0; i < cl.Length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(cl[i]);
        }
    }
    static void estrellita(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine("    ▄    ");
        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine("  ▄ ▄ ▄");
        Console.SetCursorPosition(x, y + 2);
        Console.WriteLine("    ▄    ");



    }
    static void info()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(19, 9);
        Console.WriteLine("El juego trata de una Nave, que debe enfrentarse con numerosas preguntas de Cálculo");
        Console.SetCursorPosition(19, 10);
        Console.WriteLine(" para así poder seguir sobreviviendo a las maldades que la acechan, y continuar su ");
        Console.SetCursorPosition(19, 11);
        Console.WriteLine("                            Viaje por la galaxia entera.                           ");
        Console.SetCursorPosition(19, 12);
        Console.WriteLine("                                                                                   ");
        Console.SetCursorPosition(19, 14);
        Console.WriteLine("      -Creadores del juego-                         -Movimientos del Juego-        ");
        Console.SetCursorPosition(19, 15);
        Console.WriteLine("        Kevin García                                 (A) = mover izquierda         ");
        Console.SetCursorPosition(19, 16);
        Console.WriteLine("        Jose Cevallos                                (D) = mover derecha           ");
        Console.SetCursorPosition(19, 17);
        Console.WriteLine("        Jean Alava                                 (space) = disparar              ");
        Console.SetCursorPosition(19, 18);
        Console.WriteLine("        Steven Oña                                 (escape) = salir del juego      ");
        Console.SetCursorPosition(14, 21);
        Console.WriteLine("Presione cualquier tecla para volver al Menú Principal");

    }
    static void SonidoSiguienteNivel()
    {
        int delay = 120;
        reproducirNota(523, delay); // Do
        Thread.Sleep(delay);
        reproducirNota(587, delay); // Re

    }
    static void SonidoSiguienteNivel1()
    {
        int delay = 150;
        reproducirNota(523, delay); // Do
        Thread.Sleep(delay);
        reproducirNota(587, delay); // Re
        Thread.Sleep(delay);
        reproducirNota(659, delay); // Mi
        Thread.Sleep(delay);
        reproducirNota(784, delay); // Sol
        Thread.Sleep(delay);
        reproducirNota(880, delay); // La
    }
    static void SonidoPerder()
    {
        int delay = 50;
        reproducirNota(440, delay); // La
        Thread.Sleep(delay);
        reproducirNota(392, delay); // Sol
        Thread.Sleep(delay);
        reproducirNota(349, delay); // Fa
        Thread.Sleep(delay);
        reproducirNota(330, delay); // Mi
        Thread.Sleep(delay);
        reproducirNota(294, delay); // Re
        Thread.Sleep(delay);
        reproducirNota(262, delay); // Do
    }
    static void SonidoDisparar()
    {
        int delay = 30;
        reproducirNota(100, delay); // Sol
        Thread.Sleep(delay);
        reproducirNota(100, delay); // Mi
    }
    static void juegoterminado()
    {
        int delay = 100;
        reproducirNota(659, delay); // Mi
        Thread.Sleep(delay);
        reproducirNota(783, delay); // Sol
        Thread.Sleep(delay);
        reproducirNota(987, delay); // Si
        Thread.Sleep(delay);
        reproducirNota(1319, delay); // Do
        Thread.Sleep(delay);
        reproducirNota(1567, delay); // Mi
        Thread.Sleep(delay);
        reproducirNota(1975, delay); // La
        Thread.Sleep(delay);
        reproducirNota(2637, delay); // Do#
        Thread.Sleep(delay);
        reproducirNota(3136, delay); // Mi
    }
    static void SonidoDisparoBizarro()
    {
        int delay = 30;
        reproducirNota(1400, delay);
        Thread.Sleep(delay);
        reproducirNota(1600, delay);
    }
    static void reproducirNota(int frequencia, int duracion)
    {
        if (frequencia == 0)
        {
            Thread.Sleep(duracion);
        }
        else
        {
            Console.Beep(frequencia, duracion);
        }
    }
    static void LeerEntrada(ref int x, ref int y, int marcoancho, int marcoalto, ref bool cerrar, ref int xNave)
    {
        ConsoleKeyInfo tecla;
        if (Console.KeyAvailable)
        {
            int disp = yNave, dispCasilla = 9;
            tecla = Console.ReadKey(true);
            DibujarNave(xNave, yNave);
            switch (tecla.Key)
            {
                case ConsoleKey.A:
                    if (xNave > 2)
                    {
                        xNave--;
                    }
                    break;
                case ConsoleKey.D:
                    if (xNave < marcoancho - 15)
                    {
                        xNave++;

                    }
                    break;
                case ConsoleKey.Spacebar:

                    if (disp - 1 > 2)
                    {
                        while (disp - 1 > 8)
                        {

                            Disparar(xNave, ref disp);
                            DibujarPosicionesdeDisparo(ref px, p1y);
                            DibujarPosicionesdeDisparo(ref p2x, p2y);
                            DibujarPosicionesdeDisparo(ref p3x, p3y);
                            Thread.Sleep(10);
                            disp--;
                            if (disp == 9)
                            {
                                SonidoDisparar();
                            }
                            if ((disp == 9 && xNave == p1x) || (disp == 9 && xNave == q1x) || (disp == 9 && xNave == q2x))
                            {
                                SonidoSiguienteNivel();
                                cord++;
                                if (cord == 5)
                                {
                                    calcl2(15, 15);
                                    nivel2(22, 22);
                                    SonidoSiguienteNivel1();
                                    Thread.Sleep(1000);
                                    borrarfiguras(15, 15);
                                    borrarfiguras(22, 22);
                                    level++;
                                    nivelDelJuego(ref level);
                                }
                                if (cord == 10)
                                {
                                    calcl2(15, 15);
                                    nivel3(24, 22);
                                    SonidoSiguienteNivel1();
                                    Thread.Sleep(1000);
                                    borrarfiguras(15, 15);
                                    borrarfiguras(24, 22);
                                    level++;
                                    nivelDelJuego(ref level);
                                }
                                if (cord == 15)
                                {
                                    Console.Clear();
                                    salir(navex, navey);
                                    juegoterminado();
                                    Thread.Sleep(1000);
                                    cerrar = false;
                                }

                            }
                            else
                            {
                                if ((disp == 9 && xNave == perror1) || (disp == 9 && xNave == perror2) || (disp == 9 && xNave == perror3) || (disp == 9 && xNave == serror1) || (disp == 9 && xNave == serror2) || (disp == 9 && xNave == serror3))
                                {
                                    while (dispCasilla < 21)
                                    {
                                        Thread.Sleep(17);
                                        dispCasilla++;
                                        DisparoCasillas(xNave, ref dispCasilla);
                                        DibujarN(xNave, yNave);

                                        if (dispCasilla == yNave - 1)
                                        {
                                            if (life > 1)
                                            {
                                                life--;
                                                if (dispCasilla == 21)
                                                {
                                                    SonidoDisparoBizarro();
                                                }
                                                vida(ref life);
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                salir(navex, navey);
                                                SonidoPerder();
                                                Thread.Sleep(800);
                                                cerrar = false;
                                            }
                                        }
                                    }
                                }
                            }
                            preguntasLV11(ref cord, ref p1x, ref q1x, ref q2x, ref perror1, ref perror2, ref perror3, ref serror1, ref serror2, ref serror3);
                        }
                    }
                    break;
            }
            if (tecla.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                menu();
            }
        }
    }
}
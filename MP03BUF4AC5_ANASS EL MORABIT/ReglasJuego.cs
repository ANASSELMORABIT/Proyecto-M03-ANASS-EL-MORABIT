public static class ReglasJuegoMenu
{
    public static void AboutGame()
    {
        string titulo = "📜 Game Rules 📜";
        string[] reglas = {
            "1. 🎲 The player starts by playing and rolling dice.",
            "2. 🏹 The player's attack level is determined by a random roll (two 6-sided dice).",
            "3. 💡 Skill points are multiplied by 0.10 and added to the attack roll result.",
            "4. 🏆 For each enemy defeated, the player levels up by 1.",
            "5. 💪 If the player has a higher level than the enemy, they win the battle automatically.",
            "6. 🌟 Upon reaching level 15, the player can choose to become one of the 3 special characters: Wizard, Archer, or Warrior.",
            "7. ⏰ The player has a time limit to complete each map.",
            "8. ⚔️ The player must defeat all enemies in the map before time runs out."
        };

        DecoracionUtils.MostrarConBordes(titulo, reglas);
    }

   public static void GameMenu()
    {
    string titulo = "🎮 Game Menu 🎮";
    string[] menu = {
        "1. 🕹️ Play",
        "2. 📜 View Game Rules",
        "3. 🗺️ View Maps",
        "4. 👥 View Character Information",
        "5. 🚪 Exit"
    };

    DecoracionUtils.MostrarConBordes(titulo, menu);
    }

    public static int GameMenuSelection()
    {
        GameMenu();
    
        bool validInput = true;
        DecoracionUtils.MostrarMensajeEstilado("🌟 Choose an option: (1-5) ");
        int opcion = Convert.ToInt32(Console.ReadLine());
    
        while (validInput)
        {
            if (opcion >= 1 && opcion <= 5)
            {
                validInput = false;
            }
            else
            {
                Console.WriteLine("❌ Invalid option.");
                DecoracionUtils.MostrarMensajeEstilado("🌟 Choose an option: (1-5) ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
        }
    
        return opcion;
    }


public static bool IniciarCronometro(int TiempoMaximo)
{
    bool TiempoTerminado = false;
    DecoracionUtils.MostrarMensajeEstilado($"⏳ The timer has started! You have {TiempoMaximo} seconds to complete the map. ⏳");

    int TiempoTranscurrido = 0;

    while (TiempoTranscurrido < TiempoMaximo)
    {
        Thread.Sleep(1000);
        TiempoTranscurrido++;
        Console.WriteLine("Press any key to continue... ⏸️");
        Console.ReadKey();
        // DecoracionUtils.MostrarMensajeEstilado($"Time remaining: {TiempoMaximo - TiempoTranscurrido} seconds.");
        
        if (TiempoTranscurrido >= TiempoMaximo)
        {
            TiempoTerminado = true;
            break;
        }
    }

    if (TiempoTerminado)
    {
        DecoracionUtils.MostrarMensajeEstilado("⏰ The timer has ended! Time's up! ⏰");
    }

    return TiempoTerminado;
}


    



    
}

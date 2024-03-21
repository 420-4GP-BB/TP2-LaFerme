public static class ConstantesJeu
{
    // Ça représente la quantité d'énergie que le joueur perd à chaque minute
    // dans le jeu
    public const float MARCHER = 0.001f;
    public const float COURIR = 0.005f;
    public const float PLANTER = 0.002f;
    public const float CUEILLIR = 0.001f;
    public const float DORMIR = -0.005f;    // Le joueur gagne de l'énergie en dormant
    public const float IMMOBILE = 0.0001f;   

    // Ce que le joueur peut gagner en énergie
    public const float MANGER_OEUF = 0.25f;
    public const float MANGER_CHOU = 0.35f;
    
    // Constantes relatives au temps dans une journée
    public const float MINUTES_PAR_JOUR = 1440.0f;
}

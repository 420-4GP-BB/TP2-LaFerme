public static class ConstantesJeu
{
    // �a repr�sente la quantit� d'�nergie que le joueur perd � chaque minute
    // dans le jeu
    public const float MARCHER = 0.001f;
    public const float COURIR = 0.005f;
    public const float PLANTER = 0.002f;
    public const float CUEILLIR = 0.001f;
    public const float DORMIR = -0.005f;    // Le joueur gagne de l'�nergie en dormant
    public const float IMMOBILE = 0.0001f;   

    // Ce que le joueur peut gagner en �nergie
    public const float MANGER_OEUF = 0.25f;
    public const float MANGER_CHOU = 0.35f;
    
    // Constantes relatives au temps dans une journ�e
    public const float MINUTES_PAR_JOUR = 1440.0f;
}

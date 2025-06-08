# BlazorMiniCRM

Un mini-projet de gestion de la relation client (CRM) léger, développé avec Blazor et .NET 9. Ce projet met en lumière les fonctionnalités modernes de Blazor pour une application web interactive et réactive.

## 🚀 Fonctionnalités Clés

Ce projet démontre les capacités suivantes de Blazor et .NET 9 :

-   **Mode de Rendu Interactif (WebAssembly ou Auto)** : L'application tire parti de la puissance du rendu interactif de Blazor, offrant une expérience utilisateur riche et côté client. Il peut être configuré pour fonctionner en mode `Interactive WebAssembly` ou `Interactive Auto` pour une performance et une UX optimales.
-   **Composants Razor Dynamiques** : Utilisation de composants Razor dynamiques pour construire une interface utilisateur modulaire et facile à maintenir.
-   **Intégration de QuickGrid** : Le projet intègre le nouveau composant QuickGrid de Microsoft pour un affichage de données efficace et simple, notamment pour la liste des commandes. Cela inclut des fonctionnalités de pagination et de tri intégrées.
-   **Séparation Logique Claire** : Le projet suit une architecture propre avec des couches distinctes pour l'UI (Interface Utilisateur), les Services (logique métier et opérations de données) et les Models (structures de données). Cela favorise l'organisation du code, la testabilité et la maintenabilité.
-   **Gestion des Clients (CRUD)** :
    -   Ajouter de nouveaux clients.
    -   Afficher une liste des clients enregistrés.
    -   Modifier les détails des clients existants.
    -   Supprimer des clients.
-   **Gestion des Commandes (CRUD)** :
    -   Ajouter de nouvelles commandes.
    -   Afficher une liste complète des commandes avec des détails comme la date, le montant et le client associé.
    -   Modifier les détails des commandes existantes.
    -   Supprimer des commandes.
-   **Tableau de Bord Récapitulatif** : Fournit un aperçu rapide des métriques clés, incluant le nombre total de clients, de commandes, et le montant cumulé de toutes les commandes.

## 🛠️ Technologies Utilisées

-   **Blazor** : Un framework web .NET pour construire des interfaces utilisateur web interactives côté client avec C#.
-   **.NET 9** : La dernière version de la plateforme .NET, offrant des améliorations de performance et de nouvelles fonctionnalités pour le développement Blazor.
-   **QuickGrid** : Un composant de grille de données optimisé pour Blazor, faisant partie de l'écosystème .NET.
-   **C#** : Le langage de programmation principal utilisé.
-   **HTML/CSS** : Pour la structure et le style des pages web.
  ## 📈 Captures d'écran

### Tableau de Bord
![Tableau de Bord](images/Dashboard.png)
*Un aperçu du tableau de bord principal, affichant les résumés des clients, des commandes et du montant total.*

### Gestion des Clients
![Gestion des Clients](images/Clients.png)
*La page de gestion des clients, montrant les options pour ajouter de nouveaux clients et une liste des clients existants avec les opérations CRUD.*

### Gestion des Commandes
![Gestion des Commandes](images/Orders.png)
*La page de gestion des commandes, présentant le composant QuickGrid pour lister les commandes avec leurs détails et les opérations CRUD.*

## 🚀 Démarrage Rapide

Pour exécuter ce projet localement, suivez ces étapes :

1.  **Clonez le dépôt :**
    ```bash
    git clone [https://github.com/votre-nom-utilisateur/BlazorMiniCRM.git](https://github.com/votre-nom-utilisateur/BlazorMiniCRM.git)
    cd BlazorMiniCRM
    ```
2.  **Assurez-vous d'avoir le SDK .NET 9 installé :**
    Vous pouvez le télécharger depuis [dot.net](https://dotnet.microsoft.com/download/dotnet/9.0).
3.  **Restaurez les dépendances :**
    ```bash
    dotnet restore
    ```
4.  **Exécutez l'application :**
    ```bash
    dotnet run
    ```
    L'application sera généralement accessible à `https://localhost:72xx` (où `xx` est un numéro de port).

## 💡 Comment ça Marche

Le projet est structuré comme une application Blazor Web App. Les aspects clés de son implémentation incluent :

-   La configuration du projet `WebApp` (Interactive Auto) garantit que les composants Blazor sont rendus efficacement, en tirant parti du rendu côté serveur pour le chargement initial et de l'interactivité côté client selon les besoins.
-   `QuickGrid` est utilisé dans la page `Commandes` pour fournir un moyen rapide et riche en fonctionnalités d'afficher et de paginer les données des commandes.
-   Les directives `@rendermode InteractiveServer` ou `InteractiveWebAssembly` sont appliquées stratégiquement pour assurer le bon fonctionnement des composants nécessitant une interactivité côté client.

## 🤝 Contribution

N'hésitez pas à forker ce dépôt, à ouvrir des issues ou à soumettre des pull requests. Toutes les contributions sont les bienvenues !

## 📄 Licence

Ce projet est sous licence [MIT License](LICENSE) - voir le fichier `LICENSE` pour plus de détails.

---

**Connectez-vous avec moi :**
https://www.linkedin.com/in/oumaima-benabdallah/

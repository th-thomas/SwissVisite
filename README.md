                                                                                  
                                                    @@@@                        
                                                    @@@@                        
                                                    @@@@                        
                                                    @@@@                        
              @@@@@@@@@@@@@@       @@@@@@@@@@@      @@@@@@@@@@@@@@,             
           ,@@@@(       @@@@     @@@@               @@@@@       @@@@@           
          &@@@.         @@@@     @@@@               @@@@          @@@@          
          @@@@          @@@@      @@@@@@,           @@@@          #@@@          
          @@@@          @@@@          @@@@@@@,      @@@@           @@@          
          @@@@          @@@@               @@@@     @@@@          @@@@          
           &@@@@*      @@@@@               .@@@     @@@@         @@@@           
              @@@@@@@@@@@@@@     @@@@@@@@@@@@@      @@@@@@@@@@@@@@@             
                        @@@@        %%%%%                %%%%%                  
                       @@@@                                                     
           @@@@@@@@@@@@@@                                                       
           

# SwissVisite - PPE 3 GSB
## ***Une application client lourd pour la gestion des comptes-rendus des visiteurs GSB.***
  
Projet personnel encadré réalisé par **Thibault THOMAS**,  
étudiant en 2e année de **BTS Services informatiques aux organisations**.  

Professeur : Mme CHATAING  
Sup'Chassagnes - Oullins (69)  
 
---

## Sommaire
1. [Introduction](#1-introduction)  
  1.1. [Présentation de l'application](#11-pr%C3%A9sentation-de-lapplication)  
  1.2. [Technologies mises en oeuvre](#12-technologies-et-savoir-faire-mis-en-oeuvre)  
2. [Utiliser l'application](#2-utiliser-lapplication)  
  2.1. [Environnement logiciel requis](#21-environnement-logiciel-requis)  
  2.2. [Création de la base de données et de son utilisateur](#22-cr%C3%A9ation-de-la-base-de-donn%C3%A9es-et-de-son-utilisateur)  
  2.3. [Configuration de l'application pour la connexion à la base de données](#23-configuration-de-lapplication-pour-la-connexion-%C3%A0-la-base-de-donn%C3%A9es)   
  2.4. [Authentification dans l'application (formulaire de connexion)](#24-authentification-dans-lapplication-formulaire-de-connexion)   
  2.5. [Navigation entre les formulaires](#25-navigation-entre-les-formulaires)
3. [Annexes](#3-annexes)  
  3.1. [Migrer les données de Access vers MySQL](#31-migrer-les-donn%C3%A9es-de-access-vers-mysql)  
  3.2. [Modèle conceptuel de données](#32-mod%C3%A8le-conceptuel-de-donn%C3%A9es)  
  3.3. [Diagramme de classes](#33-diagramme-de-classes)  
4. [Remerciements](#4-remerciements)  

---

## 1. Introduction
### 1.1. Présentation de l'application
Les visiteurs médicaux du laboratoire GSB saisissent et consultent leurs comptes-rendus de visites dans une application Microsoft Access.  
Cependant, l'ergonomie est perfectible et on voudrait centraliser les données dans une unique base de données.  

**Une nouvelle application, développée en C# avec le framework WinForms et reposant sur une base de données MySQL, a pour but de répondre à ces besoins d'amélioration.
L'application supporte également SQL Server.**

*Pour connaître l'intégralité du contexte et le cahier des charges, consulter la* [fiche des consignes](dossier_technique/consignes_GSB_PPE_3.pdf) *du PPE 3.*  

### 1.2. Technologies et savoir-faire mis en oeuvre
+ Langage orienté objet : C#
  + Classes, classes statiques
  + Classes abstraites, interfaces
  + LINQ
  + Expressions lambda
  + Délégués, événements
+ Application avec interface graphique : WinForms
+ Autour des données 
  + (Micro-)ORM : Dapper
  + Base de données relationnelles : MySQL / MariaDB, SQL Server
    + Requêtes préparées
    + Procédures stockées
  + Migration de données depuis Access vers MySQL
  + Modélisation des données : UML, MCD
+ Système de contrôle de version :  Git
 
---

## 2. Utiliser l'application  
### 2.1. Environnement logiciel requis
+ Microsoft Windows avec .NET Framework 4.8  
+ Visual Studio (obligatoire pour le design des formulaires)  
+ Serveur de base de données SQL Server, MariaDB ou MySQL (distant ou local)

Informations sur les versions utilisées lors du développement de l'application :  
+ Windows 10 Professionnel 64-bits versions 1809, 1909 et 2004  
+ MariaDB Server 10.3.25 sur WSL 2 (Debian Buster)  
+ SQL Server 2019
+ Visual Studio 2019  

### 2.2. Création de la base de données et de son utilisateur
Exemple pour une base de données MySQL / MariaDB en local :

    CREATE DATABASE `swissvisite`;
    CREATE USER `swissuser`@`localhost` IDENTIFIED BY 'swisspwd';
    GRANT ALL ON `swissvisite`.* TO `swissuser`@`localhost`;  
    
*Libre à vous de changer le nom d'utilisateur, son mot de passe et le nom d'hôte.  
Il faudra alors modifier le fichier `app.config` du projet SwissVisiteForm. Cf. point 2.3.*  

**Les scripts pour la création des tables et l'insertion des données sont fournis, que ce soit pour MySQL / MariaDB et SQL Server.**  
(SwissVisite > SwissVisiteLibrary > DataAccess > sql)

### 2.3. Configuration de l'application pour la connexion à la base de données
#### 2.3.1. Choix de SQL Server ou MySQL, utiliser ou non les procédures stockées 
L'application peut fonctionner indifféremment **avec SQL Server ou MySQL / MariaDB, avec ou sans procédures stockées**, offrant donc quatre possibilités de configuration.   

Vous n'avez **pas besoin de modifier le code source** de l'application puis de recompiler celle-ci pour définir parmi ces possibilités celle qui vous convient.  

Il vous suffit simplement d'ouvrir avec un éditeur de texte le **fichier de configuration `app.config` du projet `SwissVisiteForm`** (et non pas celui de `SwissVisiteLibrary` !),    
puis de **modifier les valeurs associées aux clés `sourceDonnees` et `proceduresStockees` de la section `appSettings`** : 
  
| Clé                | Valeurs possibles |
|--------------------|-------------------|
| proceduresStockees | oui / non         |
| sourceDonnees      | mysql / sqlserver |

*Exemple de section `appSettings` lorsque l'application utilise MySQL sans procédures stockées (configuration par défaut) :*  

    <appSettings>
	    <add key="proceduresStockees" value="non"/>
	    <add key="sourceDonnees" value="mysql"/>
    </appSettings>

#### 2.3.2. Chaînes de connexion
Assurez-vous enfin de personnaliser la **chaîne de connexion** (`mysql_swissvisite` pour MySQL ou `sqlserver_swissvisite` pour SQL Server) afin de correspondre aux identifiants et caractéristiques de votre base de données.  

*Exemple - chaîne de connexion de MySQL (par défaut) :*

    <add name="mysql_swissvisite"
	connectionString="server=localhost;uid=swissuser;password=swisspwd;database=swissvisite"
	providerName="MySqlConnector"/>

Ces chaînes se trouvent dans la section `connectionStrings` du même fichier `app.config`.    

### 2.4. Authentification dans l'application (formulaire de connexion)  
Un visiteur médical enregistré dans la base de données peut s'authentifier dans l'application à l'aide de son identifiant et de son mot de passe.     
**Identifiant** : première lettre du prénom suivie du nom (tout en minuscules)  
**Mot de passe** : date d'embauche au format jjmmaaaa    
(cf. champs `VIS_PRENOM`, `VIS_NOM`, `VIS_DATEEMBAUCHE` de la table `visiteur`)    
  
Exemple - les identifiants et mots de passe des 3 premiers visiteurs dans la base de données (syntaxe MySQL) :  

    SELECT `VIS_PRENOM`, `VIS_NOM`, `VIS_DATEEMBAUCHE`,
       '->' AS `donnent`,
       LOWER(CONCAT(SUBSTR(`VIS_PRENOM`, 1, 1),`VIS_NOM`)) AS `Identifiant`,
       DATE_FORMAT(`VIS_DATEEMBAUCHE`, '%d%m%Y') AS `Mot de passe`
    FROM `visiteur`
    LIMIT 0,3;

| VIS_PRENOM | VIS_NOM | VIS_DATEEMBAUCHE | donnent | Identifiant | Mot de passe |
|---|---|---|---|---|---|
| Louis | Villechalane | 1992-12-11 00:00:00 | -> | lvillechalane | 11121992 |
| David | Andre | 1991-08-26 00:00:00 | -> | dandre | 26081991 |
| Christian | Bedos | 1987-07-17 00:00:00 | -> | cbedos | 17071987 |

### 2.5. Navigation entre les formulaires
#### 2.5.1. Formulaire de connexion
La première interface visible par l'utilisateur est le formulaire de connexion, qui demande au visiteur médical de saisir ses identifiant et mot de passe et les vérifie auprès de la base de données.  
+ En cas d'identifiants erronés, le formulaire en informe l'utilisateur, qui peut les saisir de nouveau ou bien quitter l'application.
+ A noter que dans le cas où le serveur de base de données est inaccessible, une fenêtre en informe l'utilisateur avant de quitter l'application. Le formulaire de connexion n'est alors pas affiché. Rappelons que l'application ne peut pas fonctionner (ni même authentifier l'utilisateur) sans base de données.  

#### 2.5.2. Formulaire principal
Une fois l'authentification réussie, l'utilisateur est amené au formulaire principal de l'application.    
L'interface utilisateur consiste donc en **une seule fenêtre**, ledit formulaire principal appelé aussi *formulaire parent*, lui-même constitué de trois éléments :
+ Le panneau du formulaire enfant (par exemple : le formulaire qui affiche les praticiens) ;  
+ Le panneau latéral gauche, qui fait office de menu principal de l'application et permet au visiteur médical, grâce à des boutons cliquables, d'afficher un formulaire enfant dans le panneau principal ;
+ Le panneau supérieur, qui affiche l'identité du visiteur médical authentifié ainsi que le titre du formulaire enfant actuellement affiché. 

L'affichage des **formulaires enfants** depuis le formulaire parent se fait comme suit :
+ Menu principal
  + **Comptes-rendus** : formulaire de consultation des comptes-rendus existants du visiteur authentifié
    + **Nouveau compte-rendu** : formulaire de saisie d'un nouveau compte-rendu de visite (accessible depuis le bouton `Nouveau`)
      + **Praticiens** : choix du praticien à l'aide de l'annuaire (acessible depuis le bouton-icône `Fiche`)(formulaire modal : s'affiche par-dessus le formulaire `Nouveau compte-rendu`)
    + **Praticien** : fiche du praticien concerné par la visite (acessible depuis le bouton-icône `Fiche`)(formulaire modal : s'affiche par-dessus le formulaire `Comptes-rendus`)
  + **Médicaments** : formulaire listant les médicaments GSB
  + **Praticiens** : annuaire des praticiens
  + **Visiteurs** : annuaire des visiteurs médicaux
  
Lorsqu'un formulaire enfant est ouvert au sein du formulaire parent, le formulaire enfant précédemment ouvert (si existant) est fermé, sauf dans le cas des formulaires modaux.   

#### 2.5.3. Minimiser, quitter ou déplacer le formulaire parent
+ La réduction à la barre des tâches se fait grâce au bouton "moins" (`-`) situé dans le coin supérieur droit.   
+ Le bouton "croix" (`x`) voisin, ainsi que le bouton `Quitter` situé en bas du panneau latéral gauche, permettent de quitter l'application (une confirmation est demandée).   
+ On peut déplacer la fenêtre du formulaire parent sur l'écran en maintenant enfoncé le clic gauche de la souris sur le panneau supérieur ou sur le panneau latéral et en déplaçant le curseur.  
+ Il n'est cependant pas possible de redimensionner la fenêtre.  

| Ecran de connexion | Affichage des comptes-rendus de visite | Saisie d'un nouveau compte-rendu de visite |  
|---|---|---|
| ![Connexion](dossier_technique/captures/swissvisite_ecran_connexion.png) | ![Comptes-rendus](dossier_technique/captures/swissvisite_rapports.png) | ![Nouveau compte-rendu](dossier_technique/captures/swissvisite_nouveau_rapport.png) |  

| Affichage des médicaments | Affichage des praticiens | Affichage des visiteurs médicaux |   
|---|---|---|
| ![Médicaments](dossier_technique/captures/swissvisite_medicaments.png) |  ![Praticiens](dossier_technique/captures/swissvisite_praticiens.png) | ![Visiteurs](dossier_technique/captures/swissvisite_visiteurs.png) |  

---

## 3. Annexes  
### 3.1. Migrer les données de Access vers MySQL  
Consulter le [guide de migration](dossier_technique/swissvisite_migration_access_vers_mysql.pdf).  
*Remarque : le répertoire* `dossier_technique` *contient, en plus de ce guide de migration, plusieurs fichiers utiles dont les fichiers Access d'origine.*  

### 3.2. Modèle conceptuel de données  
![Modèle conceptuel de données](dossier_technique/swissvisite_modele_conceptuel_de_donnees.png)  
  
### 3.3. Diagramme de classes
*N.B. 1 : par souci de simplification, on montre dans le diagramme les auto-propriétés de C# (et non pas attributs privés + accesseurs en lecture et écriture).*  
*N.B. 2 : le programme en C# n'utilise pas une classe EchantillonModel mais un Dictionary<MedicamentModel, int>.*  
![Diagramme_de_classes](dossier_technique/swissvisite_diagramme_de_classes.png) 

---

## 4. Remerciements 
Tout d'abord je souhaite remercier mes professeurs du BTS SIO aux Chassagnes et plus particulièrement **Mme CHATAING** pour ses précieux enseignements en SLAM.  

Pour la réalisation du projet, je me suis également appuyé sur des guides et tutoriels généreusement mis à disposition par des développeurs.   
Je cite donc ici ceux qui ont particulièrement contribué à l'aboutissement de ce projet :  
+ **Tim Corey** de la chaîne YouTube [IAmTimCorey](https://www.youtube.com/channel/UC-ptWR16ITQyYOglXyQmpzw)
  + [Créer une application C# de A à Z](https://www.youtube.com/watch?v=HalXZUHfKLA&list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi) (cours complet, plusieurs vidéos)  
  + [Utiliser le micro-ORM Dapper avec C#](https://www.youtube.com/watch?v=eKkh5Xm0OlU)
  + [Les procédures stockées SQL](https://www.youtube.com/watch?v=Sggdhot-MoM)
  + [Les délégués en C#](https://www.youtube.com/watch?v=R8Blt5c-Vi4)
  + [Les événements en C#](https://www.youtube.com/watch?v=-1cftB9q1kQ)  
+ la chaîne YouTube **[RJ Code Advance EN](https://www.youtube.com/channel/UCrOMiLLn857KqOzZYIqO-hQ)**
  + [Donner un style "Flat design" à une application WinForms](https://www.youtube.com/watch?v=5AsJJl7Bhvc).

  

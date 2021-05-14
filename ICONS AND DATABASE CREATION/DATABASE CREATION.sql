--creation de base de données 
CREATE DATABASE adopt

--creation table client
CREATE TABLE client (
    id_client        INT            NOT NULL Identity(1, 1),
    nom_client       NVARCHAR (100) NOT NULL,
    telephone_client INT            NOT NULL UNIQUE,
    sexe_client      NVARCHAR (6)   NOT NULL,
    adresse_client   NVARCHAR (100) NOT NULL,
    pays_client      NVARCHAR (100) NOT NULL,
	email_client     NVARCHAR(100) NOT NULL UNIQUE,
    CONSTRAINT pk_client PRIMARY KEY  (id_client)
);

--creation de la table adopt
CREATE TABLE adopt (
    id_adopt   INT NOT NULL Identity(1, 1),
    date_adopt INT NOT NULL,
    id_client INT NOT NULL,
    CONSTRAINT pk_adopt PRIMARY KEY (id_adopt)
);


--creation de table detail adopt
CREATE TABLE detail_adopt (
    id_adopt    INT NOT NULL,
    id_animal   INT NOT NULL,
    nbr_animaux INT NOT NULL
);

--creation de la table 
CREATE TABLE animal (
    id_animal       INT           Identity(1, 1) NOT NULL,
    nom_animal  NVARCHAR (100) NOT NULL,
    quantite_animal INT            NOT NULL,
    type_animal     NVARCHAR (50)  NOT NULL,
    sexe_animal     NVARCHAR (6)   NOT NULL,
    id_category    INT            NOT NULL,
    CONSTRAINT pk_animal PRIMARY KEY (id_animal )
	);


	--creation de table category
CREATE TABLE category (
    id_category   INT      Identity(1, 1)      NOT NULL,
    name_category NVARCHAR (100) NOT NULL,
    CONSTRAINT pk_category PRIMARY KEY  (id_category)
);

--creation de la table utilisateur
CREATE TABLE utilisateur (
    id_utilisateur   INT NOT NULL Identity(1, 1),
    nom_utilisateur nvarchar(100) NOT NULL,
    mot_de_passe nvarchar(100) NOT NULL,
    CONSTRAINT pk_user PRIMARY KEY (id_utilisateur)
)








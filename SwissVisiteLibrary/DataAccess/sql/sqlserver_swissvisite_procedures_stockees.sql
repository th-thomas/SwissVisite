DROP PROCEDURE IF EXISTS dbo.spFamilleMedic_GetAll;
GO
CREATE PROCEDURE dbo.spFamilleMedic_GetAll
AS
BEGIN
    SELECT FAM_CODE Code, FAM_LIBELLE Libelle
    FROM famillemedic
    ORDER BY FAM_LIBELLE;
END
GO

DROP PROCEDURE IF EXISTS dbo.spMedicament_GetAll;
GO
CREATE PROCEDURE dbo.spMedicament_GetAll
AS
BEGIN
    SELECT MED_DEPOTLEGAL DepotLegal, MED_NOMCOMMERCIAL NomCommercial, MED_COMPOSITION Composition, MED_EFFETS Effets,
            MED_CONTREINDIC ContreIndications, MED_PRIXECHANTILLON PrixEchantillon, m.FAM_CODE Code, FAM_LIBELLE Libelle
    FROM medicament m
    INNER JOIN famillemedic f ON m.FAM_CODE = f.FAM_CODE
    ORDER BY MED_NOMCOMMERCIAL;
END
GO

DROP PROCEDURE IF EXISTS dbo.spPraticien_GetAll;
GO
CREATE PROCEDURE dbo.spPraticien_GetAll
AS
BEGIN
    SELECT PRA_NUM Numero, PRA_NOM Nom, PRA_PRENOM Prenom, PRA_ADRESSE Adresse, PRA_CP CodePostal, PRA_VILLE Ville,
            PRA_COEFNOTORIETE CoeffNotoriete, t.TYP_CODE Code, TYP_LIBELLE Libelle, TYP_LIEU Lieu
    FROM praticien p
    INNER JOIN typepraticien t ON p.TYP_CODE = t.TYP_CODE
    ORDER BY PRA_NOM;
END
GO

DROP PROCEDURE IF EXISTS dbo.spRapportVisite_GetByVisiteur;
GO
CREATE PROCEDURE dbo.spRapportVisite_GetByVisiteur
    @Matricule VARCHAR(255)
AS
BEGIN
    SELECT RAP_NUM Numero, RAP_DATE Date, RAP_BILAN Bilan, RAP_MOTIF Motif
    FROM rapportvisite
    WHERE VIS_MATRICULE = @Matricule
    ORDER BY RAP_DATE;
END
GO

DROP PROCEDURE IF EXISTS dbo.spPraticien_GetByRapportVisite;
GO
CREATE PROCEDURE dbo.spPraticien_GetByRapportVisite
    @Numero VARCHAR(255)
AS
BEGIN
    SELECT p.PRA_NUM Numero, PRA_NOM Nom, PRA_PRENOM Prenom, PRA_ADRESSE Adresse, PRA_CP CodePostal, PRA_VILLE Ville, PRA_COEFNOTORIETE CoeffNotoriete,
            t.TYP_CODE Code, TYP_LIBELLE Libelle, TYP_LIEU Lieu
    FROM praticien p
    INNER JOIN typepraticien t ON t.TYP_CODE = p.TYP_CODE
    INNER JOIN rapportvisite r ON p.PRA_NUM = r.PRA_NUM
    WHERE RAP_NUM = @Numero;
END
GO

DROP PROCEDURE IF EXISTS dbo.spPresenter_GetByRapport;
GO
CREATE PROCEDURE dbo.spPresenter_GetByRapport
    @Numero VARCHAR(255)
AS
BEGIN
    SELECT m.MED_DEPOTLEGAL DepotLegal, MED_NOMCOMMERCIAL NomCommercial, MED_COMPOSITION Composition, MED_EFFETS Effets, MED_CONTREINDIC ContreIndications, MED_PRIXECHANTILLON PrixEchantillon,
            f.FAM_CODE Code, FAM_LIBELLE Libelle,
            Nombre_Echantillon
    FROM presenter p
    INNER JOIN medicament m on p.MED_DEPOTLEGAL = m.MED_DEPOTLEGAL
    INNER JOIN famillemedic f on m.FAM_CODE = f.FAM_CODE
    WHERE RAP_NUM = @Numero
    ORDER BY m.MED_NOMCOMMERCIAL;
END
GO

DROP PROCEDURE IF EXISTS dbo.spVisiteur_GetAll;
GO
CREATE PROCEDURE dbo.spVisiteur_GetAll
AS
BEGIN
    SELECT VIS_MATRICULE Matricule, VIS_NOM Nom, VIS_PRENOM Prenom, VIS_ADRESSE Adresse,
            VIS_CP CodePostal, VIS_VILLE Ville, VIS_DATEEMBAUCHE DateEmbauche
    FROM visiteur
    ORDER BY VIS_NOM;
END
GO

DROP PROCEDURE IF EXISTS dbo.spRapportVisite_Create;
GO
CREATE PROCEDURE dbo.spRapportVisite_Create
    @Date DATETIME,
    @Bilan VARCHAR(255),
    @Motif VARCHAR(255),
    @NumeroPrat INT,
    @MatriculeVis VARCHAR(255),
    @Numero VARCHAR(255) OUTPUT
AS
BEGIN
    SET @Numero = (SELECT 1 + MAX(CAST(RAP_NUM AS INTEGER)) FROM rapportvisite);
    INSERT INTO rapportvisite (RAP_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF, PRA_NUM, VIS_MATRICULE)
    VALUES (@Numero, @Date, @Bilan, @Motif, @NumeroPrat, @MatriculeVis);
    SELECT @Numero;
END
GO

DROP PROCEDURE IF EXISTS dbo.spPresenter_Create;
GO
CREATE PROCEDURE dbo.spPresenter_Create
    @Numero VARCHAR(255),
    @DepotLegal VARCHAR(255),
    @NombreEchantillon VARCHAR(255)
AS
BEGIN
    INSERT INTO presenter (RAP_NUM, MED_DEPOTLEGAL, Nombre_Echantillon)
    VALUES (@Numero, @DepotLegal, @NombreEchantillon);
END
GO

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Module
    {
        public int ModuleID { get; set; }

        [Required]
        public string ModuleNom { get; set; }

        public string ModuleGroup { get; set; }

        public virtual List<ModuleAction> ModuleActions { get; set; }

        //public ObservableCollection<string> ModuleActions => ModuleGroup != null ? new ObservableCollection<string>(ModuleGroup.Split(',')) : new ObservableCollection<string>();
    }

    public class ModuleAction
    {
        public int ModuleActionID { get; set; }
        public int? ModuleID { get; set; }
        public Resource Resource { get; set; }
        public Action Action { get; set; }
        public string ModuleActionNom { get; set; }
        public virtual Module Module { get; set; }

        //[NotMapped]
        //public virtual List<Role> Roles
        //{
        //    get
        //    {
        //        return ModuleActionRoles.Select(r => r.Role).ToList();
        //    }
        //}
        //public virtual List<ModuleActionRole> ModuleActionRoles { get; set; }
    }
    public enum Resource
    {
        [Display(Name = "Consultation")]
        [Description("Consultation")]
        Consultation = 1,
        [Display(Name = "Utilisateurs")]
        [Description("Utilisateurs")]
        Utilisateurs = 2,
        [Display(Name = "Planification")]
        [Description("Planification")]
        Planification = 3,
        [Display(Name = "Paramétrage")]
        [Description("Paramétrage")]
        Parametrage = 4,
        [Display(Name = "Patient")]
        [Description("Patient")]
        Patient = 5,
        [Display(Name = "Finance")]
        [Description("Finance")]
        Finance = 6,
        [Display(Name = "Recette")]
        [Description("Recette")]
        Recette = 7,
        [Display(Name = "Salle d'attente")]
        [Description("Salle d'attente")]
        SalleAttente = 8,
        [Display(Name = "Recette Par Consultation")]
        [Description("Recette Par Consultation")]
        RecetteParConsultation = 9,
        [Display(Name = "Recette Par Transaction")]
        [Description("Recette Par Transaction")]
        RecetteParTransaction = 10,
        [Display(Name = "Dépense")]
        [Description("Dépense")]
        Depense = 11,
        [Display(Name = "Tableau de bord")]
        [Description("Tableau de bord")]
        Dashboard = 12,
        [Display(Name = "Déclaration de caisse")]
        [Description("Déclaration de caisse")]
        CaisseDeclaration = 13,
        [Display(Name = "Vue globale de recette")]
        [Description("Vue globale de recette")]
        RecetteGlobalView = 14,
        [Description("Vue globale de recette partenaire")]
        RecettePartnerGlobalView = 15,
        [Description("Factures partenaire")]
        PartnerInvoices = 16,
        [Description("Versement partenaire")]
        PartnerVersements = 17,
        [Display(Name = "Radiologie")]
        [Description("Radiologie")]
        Radiology = 18,
        [Display(Name = "Laboratoire")]
        [Description("Laboratoire")]
        Laboratory = 19,

        [Display(Name = "Sejour")]
        [Description("Sejour")]
        Sejour = 20,

        [Display(Name = "Planification Séjours")]
        [Description("Planification Séjours")]
        SejourPlanification = 21,

        [Display(Name = "Plan de temps")]
        [Description("Plan de temps")]
        PlagePlanification = 22,

        [Display(Name = "Consultation Infos")]
        [Description("Consultation Infos")]
        ConsultationInfos = 23,

        [Display(Name = "Antécédents")]
        [Description("Antécédents")]
        Antecedents = 24,

        [Display(Name = "Examen Général")]
        [Description("Examen Général")]
        ExamenGeneral = 25,

        [Display(Name = "Demande Labo")]
        [Description("Demande Labo")]
        DemandeLabo = 26,

        [Display(Name = "Demande Radio")]
        [Description("Demande Radio")]
        DemandeRadio = 27,

        [Display(Name = "Ordonnance")]
        [Description("Ordonnance")]
        Ordonnace = 28,

        [Display(Name = "Courriers")]
        [Description("Courriers")]
        Courriers = 29,

        [Display(Name = "Diagnostics")]
        [Description("Diagnostics")]
        Diagnostics = 30,

        [Display(Name = "Actes Médicaux")]
        [Description("Actes Médicaux")]
        ActesMedicaux = 31,

        [Display(Name = "Paiement")]
        [Description("Paiement")]
        Paiement = 32,

        [Display(Name = "Historique")]
        [Description("Historique")]
        Historique = 33,

        [Display(Name = "Attachements")]
        [Description("Attachements")]
        Attachements = 34,

        [Display(Name = "Prescriptions")]
        [Description("Prescriptions")]
        Prescriptions = 35,
        [Display(Name = "Notes")]
        [Description("Notes")]
        Notes = 36,

        [Display(Name = "Plan Soin")]
        [Description("Plan Soin")]
        PlanSoin = 37,

        [Display(Name = "Recette Patient")]
        [Description("Recette Patient")]
        RecettePatient = 38,

        [Display(Name = "Recette Partenaires")]
        [Description("Recette Partenaires")]
        RecettePartenaires = 39,

        [Display(Name = "File d'attente")]
        [Description("File d'attente")]
        FileAttente = 40,

        [Display(Name = "Salle de Soin")]
        [Description("Salle de Soin")]
        SalleSoin = 41,

        [Display(Name = "Hopital de Jour")]
        [Description("Hopital de Jour")]
        HopitalJour = 42,
        [Display(Name = "Plan Hopital Jour")]
        [Description("Plan Hopital Jour")]
        HopitalJourPlan = 43,

        [Display(Name = "Questionnaire")]
        [Description("Questionnaire")]
        Questionnaire = 44,

        [Description("Type de sejour selon les opérations")]
        SejourDiagsType = 45,

        [Description("Bloc Opératoire")]
        BlocOperatoire = 46,

        [Description("Plan Radiologie")]
        RadiologyPlan = 47,

        [Display(Name = "Médicament")]
        [Description("Médicament")]
        Medicament = 48,

        [Display(Name = "Devis")]
        [Description("Devis")]
        Devis = 49,

        [Display(Name = "Medecin Adressant")]
        [Description("Medecin Adressant")]
        MedecinAdressant = 50,

        [Display(Name = "Titre Medecin")]
        [Description("Titre Medecin")]
        TitreMedecin = 51,

        [Display(Name = "Bio Tache")]
        [Description("Bio Tache")]
        BioTache = 52,

        [Display(Name = "Image Tache")]
        [Description("Image Tache")]
        ImageTache = 53,

        [Display(Name = "Medi Tache")]
        [Description("Medi Tache")]
        MediTache = 54,

        [Display(Name = "P Tache")]
        [Description("P Tache")]
        PTache = 55,

        [Display(Name = "Inject Tache")]
        [Description("inject Tache")]
        InjectTache = 56,

        [Display(Name = "Soin Tache")]
        [Description("Soin Tache")]
        SoinTache = 57,

        [Display(Name = "Question")]
        [Description("Question")]
        Question = 58,

        [Display(Name = "Consultation Anesthésiste")]
        [Description("Consultation Anesthésiste")]
        AnesthesiaConsultation = 59,

        [Display(Name = "Recette Hopital de jour")]
        [Description("Recette Hopital de jour")]
        RecetteHopitalJour = 60,

        [Description("Factures patients")]
        PatientInvoices = 61,
    }

    public enum Action
    {
        [Display(Name = "Actes Médicaux")]
        [Description("Actes Médicaux")]
        ActesMedicaux = 1,
        [Display(Name = "Type Analyse")]
        [Description("Type Analyse")]
        AnalysisType = 2,
        [Display(Name = "Antécédents")]
        [Description("Antécédents")]
        Antecedents = 3,
        [Display(Name = "Conception des rapports")]
        [Description("Conception des rapports")]
        ReportDesigner = 4,
        [Display(Name = "Convention")]
        [Description("Convention")]
        Convention = 5,
        [Display(Name = "Courriers")]
        [Description("Courriers")]
        Courriers = 6,
        [Display(Name = "Création")]
        [Description("Création")]
        Creation = 7,
        [Display(Name = "Demande Labo")]
        [Description("Demande Labo")]
        DemandeLabo = 8,
        [Display(Name = "Demande Radio")]
        [Description("Demande Radio")]
        DemandeRadio = 9,
        [Display(Name = "Diagnostics")]
        [Description("Diagnostics")]
        Diagnostics = 10,
        [Display(Name = "Examen Général")]
        [Description("Examen Général")]
        ExamenGeneral = 11,
        [Display(Name = "Filtre(surplus)")]
        [Description("Filtre(surplus)")]
        Filtre = 12,
        [Display(Name = "Infos")]
        [Description("Infos")]
        Info = 13,
        [Display(Name = "Lecture")]
        [Description("Lecture")]
        Lecture = 14,
        [Display(Name = "Liste de prix")]
        [Description("Liste de prix")]
        PriceList = 15,
        [Display(Name = "Modification")]
        [Description("Modification")]
        Modification = 16,
        [Display(Name = "Montant Clinique")]
        [Description("Montant Clinique")]
        MontantClinic = 17,
        [Display(Name = "Médicament")]
        [Description("Médicament")]
        Medicament = 18,
        [Display(Name = "Ordonnace")]
        [Description("Ordonnace")]
        Ordonnace = 19,
        [Display(Name = "Paiement")]
        [Description("Paiement")]
        Paiement = 20,
        [Display(Name = "Paramètres globaux")]
        [Description("Paramètres globaux")]
        ParamDict = 21,
        [Display(Name = "Partenaire")]
        [Description("Partenaire")]
        Partner = 22,
        [Display(Name = "Procédure")]
        [Description("Procédure")]
        Procedure = 23,
        [Display(Name = "Roles")]
        [Description("Roles")]
        Roles = 24,
        [Display(Name = "Suppression")]
        [Description("Suppression")]
        Suppression = 25,
        [Display(Name = "Total Clinique")]
        [Description("Total Clinique")]
        TotalClinic = 26,
        [Display(Name = "Tous les rendez-vous")]
        [Description("Tous les rendez-vous")]
        AllRdv = 27,
        [Display(Name = "Modèles de documents")]
        [Description("Modèles de documents")]
        ReportTemplate = 28,
        [Display(Name = "Type de Procédure radio")]
        [Description("Type de Procédure radio")]
        RadioProcedureType = 29,
        [Display(Name = "Utilisateurs")]
        [Description("Utilisateurs")]
        Utilisateurs = 30,
        [Display(Name = "Attachements")]
        [Description("Attachements")]
        Attachments = 31,
        [Display(Name = "Modules")]
        [Description("Modules")]
        Modules = 32,
        [Display(Name = "Filtre")]
        [Description("Filtre")]
        CanFilter = 33,
        [Display(Name = "Type Dépense")]
        [Description("Type Dépense")]
        DepenseType = 34,
        [Display(Name = "Motif du Rdv")]
        [Description("Motif du Rdv")]
        MotifRdv = 35,

        [Display(Name = "Voir tous")]
        [Description("Voir tous")]
        ViewAll = 36,

        [Display(Name = "Filtrer les dates")]
        [Description("Filtrer les dates")]
        CanFilterDates = 37,

        [Display(Name = "Editer les details")]
        [Description("Editer les details")]
        CanEditDetails = 38,

        [Display(Name = "Annuler")]
        [Description("Annuler")]
        Annuler = 39,

        [Display(Name = "Peut effectuer des consultations")]
        [Description("Peut effectuer des consultations")]
        CanDoConsultations = 40,

        [Display(Name = "Plan Soin")]
        [Description("Plan Soin")]
        PlanSoin = 41,

        [Display(Name = "Chambre")]
        [Description("Chambre")]
        Room = 42,
        [Display(Name = "Lit")]
        [Description("Lit")]
        Bed = 43,
        [Display(Name = "Etage")]
        [Description("Etage")]
        Floor = 44,
        [Display(Name = "Effectuer Sejours")]
        [Description("Effectuer Sejours")]
        CanDoSejour = 45,

        [Display(Name = "Prescription")]
        [Description("Prescription")]
        Prescription = 46,


        [Display(Name = "Plan de temps")]
        [Description("Plan de temps")]
        PlagePlanification = 47,


        [Display(Name = "Note")]
        [Description("Note")]
        Note = 48,
        [Display(Name = "Audit")]
        [Description("Audit")]
        Audit = 49,
        [Display(Name = "Changer Consulatation Statut")]
        [Description("Changer Consulatation Statut")]
        ChangerConsulatationStatut = 50,
        [Display(Name = "Edit Patient Has Consultation")]
        [Description("Edit Patient Has Consultation")]
        EditPatientHasConsultation = 51,
        [Display(Name = "Changer Statut Rdv")]
        [Description("Changer Statut Rdv")]
        ChangerStatutRdv = 52,
        [Display(Name = "Paramétrage")]
        [Description("Paramétrage")]
        Parametrage = 53,
        [Display(Name = "Ecran File d'Attente")]
        [Description("Ecran File d'Attente")]
        EcranFileAttente = 54,
        [Display(Name = "Action Suivant")]
        [Description("Action Suivant")]
        ActionSuivant = 55,
        [Display(Name = "Ordonnance Vierge")]
        [Description("Ordonnance Vierge")]
        OrdonnanceVierge = 56,
        [Display(Name = "Duppliquer")]
        [Description("Duppliquer")]
        Duppliquer = 57,
        [Display(Name = "Aperçu")]
        [Description("Aperçu")]
        Aperçu = 58,
        [Display(Name = "Impression")]
        [Description("Impression")]
        Impression = 59,
        [Display(Name = "Remise")]
        [Description("Remise")]
        Remise = 60,
        [Display(Name = "Changer Partenaire")]
        [Description("Changer Partenaire")]
        ChangerPartenaire = 61,
        [Display(Name = "Changer List des Prix")]
        [Description("Changer List des Prix")]
        ChangerListPrix = 62,
        [Description("Modele d'ordonnace")]
        OrdTemplate = 63,


        [Display(Name = "Salle de soins")]
        [Description("Salle de soins")]
        SalleSoins = 64,

        [Display(Name = "Questionnaire")]
        [Description("Questionnaire")]
        Questionnaire = 65,

        [Display(Name = "Spécialité")]
        [Description("Spécialité")]
        Specialite = 66,

        [Display(Name = "Catégorie Question")]
        [Description("Catégorie Question")]
        QuestionCategory = 67,

        [Display(Name = "Question")]
        [Description("Question")]
        Question = 68,

        [Display(Name = "Choix")]
        [Description("Choix")]
        Choice = 69,

        [Display(Name = "Recharger Questionnaire")]
        [Description("Recharger Questionnaire")]
        ReloadQuestionnaire = 70,

        [Display(Name = "Affectation Lits ")]
        [Description("Affectation Lits")]
        BedAffectation = 71,

        [Description("Peut Faire des Operations")]
        CanDoOperation = 72,

        [Display(Name = "Calendrier")]
        [Description("Calendrier")]
        Calendar = 73,

        [Display(Name = "Tableau")]
        [Description("Tableau")]
        Table = 74,

        [Description("Salle operatoire")]
        SalleOperatoire = 75,
        [Description("Unité radiologie")]
        RadiologyUnit = 76,
        [Description("Instruments radiologie")]
        RadiologyInstrument = 77,

        [Display(Name = "Compte Rendu")]
        [Description("Compte Rendu")]
        CompteRendu = 78,

        [Display(Name = "Recharger Prix")]
        [Description("Recharger Prix")]
        ReloadPrices = 79,

        [Display(Name = "Création Hopital Jour")]
        [Description("Création Hopital Jour")]
        HopitalJourCreation = 80,

        [Display(Name = "Bio Tache")]
        [Description("Bio Tache")]
        BioTache = 81,

        [Display(Name = "Titre Medecin")]
        [Description("Titre Medecin")]
        TitreMedecin = 82,



        [Display(Name = "Sortie Médicale")]
        [Description("Sortie Médicale")]
        SortieMedicale = 83,

        [Display(Name = "Préparation Sortie Administrative")]
        [Description("Préparation Sortie Administrative")]
        PrepSortieAdmin = 84,

        [Display(Name = "Terminer")]
        [Description("Terminer")]
        Terminate = 85,

        [Description("Imprimer interpretation radio")]
        PrintprocedureInterpretation = 86,

        [Description("Supprimer examen radio")]
        DeleteProcedure = 87,


        [Description("Procedure Execution en cours")]
        CanMakeProcedureEnCoursExecution = 88,

        [Description("Procedure Execution terminé")]
        CanMakeProcedurExecutionTermine = 89,


        [Description("Procedure redaction terminé")]
        CanMakeProcedureRedactionTermine = 90,

        [Description("Procedure Validé")]
        CanMakeProcedureValide = 91,

        [Display(Name = "Audit radiologie")]
        [Description("Audit radiologie")]
        RadiologyAudit = 92,

        [Display(Name = "Audit patient")]
        [Description("Audit patient")]
        PatientAudit = 93,

        [Display(Name = "Type opération")]
        [Description("Type opération")]
        OperationType = 94,

        [Display(Name = "Bureau")]
        [Description("Bureau")]
        Bureau = 95,

        [Display(Name = "Type de rapport")]
        [Description("Type de rapport")]
        ReportTemplateType = 96,
    }
}

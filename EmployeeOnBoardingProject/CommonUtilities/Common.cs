using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EmployeeOnBoardingProject.CommonUtilities
{
    public class Common
    {
        public static string GetConnectionString()
        {
            string str = ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;
            return (str);
        }

        #region List Of Stored Procedures
        public static string Usp_insertPersonalDetails = "Usp_insertPersonalDetails";
        public static string Usp_GetAllEmployeeDetails = "Usp_GetAllEmployeeDetails";
        public static string Usp_UpdatePersonalDetails = "Usp_UpdatePersonalDetails";
        public static string Usp_DeletePersonalDetails = "Usp_DeletePersonalDetails";
        public static string Usp_GetCountryDetailsByCountryID = "Usp_GetCountryDetailsByCountryID";
        public static string Usp_GetStatesDetailsByCountryID = "Usp_GetStatesDetailsByCountryID";
        public static string Usp_GetCityDetailsByStateID = "Usp_GetCityDetailsByStateID";
        public static string Usp_GetColoniesDetailsByCityID = "Usp_GetColoniesDetailsByCityID";
        public static string Usp_GetUniversitiesDetails = "Usp_GetUniversitiesDetails";
        public static string Usp_GetCollegesDetailsByUniversityID = "Usp_GetCollegesDetailsByUniversityID";
        public static string Usp_InsertAcademicDetails = "Usp_InsertAcademicDetails";
        public static string Usp_GetAcademicDetails = "Usp_GetAcademicDetails";
        public static string Usp_GetPersonalDetailsByEmployeeID = "Usp_GetPersonalDetailsByEmployeeID";
        public static string Usp_GetEmpNamesbyID = "Usp_GetEmpNamesbyID";
        public static string Usp_UpdateAcademicDetails = "Usp_UpdateAcademicDetails";
        public static string Usp_GetCollegesDetailsByCollegeID = "Usp_GetCollegesDetailsByCollegeID";
        public static string Usp_DeleteAcademicDetails = "Usp_DeleteAcademicDetails";
        public static string Usp_GetDesignationsDetails = "Usp_GetDesignationsDetails";
        public static string Usp_InsertExperienceDetails = "Usp_InsertExperienceDetails";
        public static string Usp_UpdateExperienceDetails = "Usp_UpdateExperienceDetails";
        public static string Usp_GetExperienceDetails = "Usp_GetExperienceDetails";
        public static string Usp_DeleteExperienceDetails = "Usp_DeleteExperienceDetails";
        public static string Usp_GetDesignationsDetailsByDesignationID = "Usp_GetDesignationsDetailsByDesignationID";
        public static string Usp_GetSkillsDetails = "Usp_GetSkillsDetails";
       
        public static string Usp_InsertSalaryBreakUpDetails = "Usp_InsertSalaryBreakUpDetails";
        public static string Usp_UpdateSalaryBreakUpDetails = "Usp_UpdateSalaryBreakUpDetails";
        public static string Usp_DeleteSalaryBreakUpDetails = "Usp_DeleteSalaryBreakUpDetails";
        public static string Usp_GetSalaryBreakUpDetails = "Usp_GetSalaryBreakUpDetails";
        public static string usp_GetAllEmpExpDetails = "usp_GetAllEmpExpDetails";

        public static string Usp_InsertOtherParticularDetails = "Usp_InsertOtherParticularDetails";
        public static string Usp_UpdateOtherParticularDetails = "Usp_UpdateOtherParticularDetails";
        public static string Usp_DeleteOtherParticularDetails = "Usp_DeleteOtherParticularDetails";
        public static string Usp_GetOtherParticularDetails = "Usp_GetOtherParticularDetails";

        public static string USP_USERREGISTERATION_INSERT = "USP_USERREGISTERATION_INSERT";
        public static string USP_USERREGISTERATION_UPDATE = "USP_USERREGISTERATION_UPDATE";
        public static string USP_USERREGISTERATION_DELETE = "USP_USERREGISTERATION_DELETE";
        public static string USP_GETALLUSERS = "USP_GETALLUSERS";


        #endregion
    }
}

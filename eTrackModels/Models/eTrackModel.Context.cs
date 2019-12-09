﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTrackModels.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TPN_CRMEntities : DbContext
    {
        public TPN_CRMEntities()
            : base("name=TPN_CRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SCM_APP_LOGINUSER_Result> AppLoginUser(string pUSERNAME, string pPASSWORD)
        {
            var pUSERNAMEParameter = pUSERNAME != null ?
                new ObjectParameter("PUSERNAME", pUSERNAME) :
                new ObjectParameter("PUSERNAME", typeof(string));
    
            var pPASSWORDParameter = pPASSWORD != null ?
                new ObjectParameter("PPASSWORD", pPASSWORD) :
                new ObjectParameter("PPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_APP_LOGINUSER_Result>("AppLoginUser", pUSERNAMEParameter, pPASSWORDParameter);
        }
    
        public virtual ObjectResult<SCM_BIND_LOCTION_Result> GetLocations(string pCOMP_CODE, string pCENT_CODE, string pLOC_CODE, string pLOC_NAME, string pEXTRA1, string pEXTRA2, string pEXTRA3)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pCENT_CODEParameter = pCENT_CODE != null ?
                new ObjectParameter("PCENT_CODE", pCENT_CODE) :
                new ObjectParameter("PCENT_CODE", typeof(string));
    
            var pLOC_CODEParameter = pLOC_CODE != null ?
                new ObjectParameter("PLOC_CODE", pLOC_CODE) :
                new ObjectParameter("PLOC_CODE", typeof(string));
    
            var pLOC_NAMEParameter = pLOC_NAME != null ?
                new ObjectParameter("PLOC_NAME", pLOC_NAME) :
                new ObjectParameter("PLOC_NAME", typeof(string));
    
            var pEXTRA1Parameter = pEXTRA1 != null ?
                new ObjectParameter("PEXTRA1", pEXTRA1) :
                new ObjectParameter("PEXTRA1", typeof(string));
    
            var pEXTRA2Parameter = pEXTRA2 != null ?
                new ObjectParameter("PEXTRA2", pEXTRA2) :
                new ObjectParameter("PEXTRA2", typeof(string));
    
            var pEXTRA3Parameter = pEXTRA3 != null ?
                new ObjectParameter("PEXTRA3", pEXTRA3) :
                new ObjectParameter("PEXTRA3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_BIND_LOCTION_Result>("GetLocations", pCOMP_CODEParameter, pCENT_CODEParameter, pLOC_CODEParameter, pLOC_NAMEParameter, pEXTRA1Parameter, pEXTRA2Parameter, pEXTRA3Parameter);
        }
    
        public virtual ObjectResult<SCM_BIND_SHOP_P_Result> GetShopkeepers(string pCOMP_CODE, string pCITY, string pLOCATION, string pTYPE, string pNAME, string pEXTRA1, string pEXTRA2, string pEXTRA3, string pEXTRA4)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pCITYParameter = pCITY != null ?
                new ObjectParameter("PCITY", pCITY) :
                new ObjectParameter("PCITY", typeof(string));
    
            var pLOCATIONParameter = pLOCATION != null ?
                new ObjectParameter("PLOCATION", pLOCATION) :
                new ObjectParameter("PLOCATION", typeof(string));
    
            var pTYPEParameter = pTYPE != null ?
                new ObjectParameter("PTYPE", pTYPE) :
                new ObjectParameter("PTYPE", typeof(string));
    
            var pNAMEParameter = pNAME != null ?
                new ObjectParameter("PNAME", pNAME) :
                new ObjectParameter("PNAME", typeof(string));
    
            var pEXTRA1Parameter = pEXTRA1 != null ?
                new ObjectParameter("PEXTRA1", pEXTRA1) :
                new ObjectParameter("PEXTRA1", typeof(string));
    
            var pEXTRA2Parameter = pEXTRA2 != null ?
                new ObjectParameter("PEXTRA2", pEXTRA2) :
                new ObjectParameter("PEXTRA2", typeof(string));
    
            var pEXTRA3Parameter = pEXTRA3 != null ?
                new ObjectParameter("PEXTRA3", pEXTRA3) :
                new ObjectParameter("PEXTRA3", typeof(string));
    
            var pEXTRA4Parameter = pEXTRA4 != null ?
                new ObjectParameter("PEXTRA4", pEXTRA4) :
                new ObjectParameter("PEXTRA4", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_BIND_SHOP_P_Result>("GetShopkeepers", pCOMP_CODEParameter, pCITYParameter, pLOCATIONParameter, pTYPEParameter, pNAMEParameter, pEXTRA1Parameter, pEXTRA2Parameter, pEXTRA3Parameter, pEXTRA4Parameter);
        }
    
        public virtual ObjectResult<SCM_BINDCITYF2_Result> GetCities(string pcountry, string pcity, string pstate_code)
        {
            var pcountryParameter = pcountry != null ?
                new ObjectParameter("pcountry", pcountry) :
                new ObjectParameter("pcountry", typeof(string));
    
            var pcityParameter = pcity != null ?
                new ObjectParameter("pcity", pcity) :
                new ObjectParameter("pcity", typeof(string));
    
            var pstate_codeParameter = pstate_code != null ?
                new ObjectParameter("Pstate_code", pstate_code) :
                new ObjectParameter("Pstate_code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_BINDCITYF2_Result>("GetCities", pcountryParameter, pcityParameter, pstate_codeParameter);
        }
    
        public virtual ObjectResult<SCM_RET_TYPE_P_Result> GetRetTypes(string pCOMP_CODE, string pEXTRA)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pEXTRAParameter = pEXTRA != null ?
                new ObjectParameter("PEXTRA", pEXTRA) :
                new ObjectParameter("PEXTRA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_RET_TYPE_P_Result>("GetRetTypes", pCOMP_CODEParameter, pEXTRAParameter);
        }
    
        public virtual ObjectResult<SCM_SEL_PROD_TYPE_Result> GetSelProdTypes(string pCOMP_CODE, string pCENT_CODE, string pPROD_CODE, string pPROD_NAME, string pEXTRA1, string pEXTRA2, string pEXTRA3)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pCENT_CODEParameter = pCENT_CODE != null ?
                new ObjectParameter("PCENT_CODE", pCENT_CODE) :
                new ObjectParameter("PCENT_CODE", typeof(string));
    
            var pPROD_CODEParameter = pPROD_CODE != null ?
                new ObjectParameter("PPROD_CODE", pPROD_CODE) :
                new ObjectParameter("PPROD_CODE", typeof(string));
    
            var pPROD_NAMEParameter = pPROD_NAME != null ?
                new ObjectParameter("PPROD_NAME", pPROD_NAME) :
                new ObjectParameter("PPROD_NAME", typeof(string));
    
            var pEXTRA1Parameter = pEXTRA1 != null ?
                new ObjectParameter("PEXTRA1", pEXTRA1) :
                new ObjectParameter("PEXTRA1", typeof(string));
    
            var pEXTRA2Parameter = pEXTRA2 != null ?
                new ObjectParameter("PEXTRA2", pEXTRA2) :
                new ObjectParameter("PEXTRA2", typeof(string));
    
            var pEXTRA3Parameter = pEXTRA3 != null ?
                new ObjectParameter("PEXTRA3", pEXTRA3) :
                new ObjectParameter("PEXTRA3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_SEL_PROD_TYPE_Result>("GetSelProdTypes", pCOMP_CODEParameter, pCENT_CODEParameter, pPROD_CODEParameter, pPROD_NAMEParameter, pEXTRA1Parameter, pEXTRA2Parameter, pEXTRA3Parameter);
        }
    
        public virtual int UpsertAppUser(string userCode, string userName, string userType, string userFname, string userLname, string userpassword, string pagency, string pdeptcode, string pbranch, string pdateformat, string defcomp, string lstcomp, string email, string prole, string pstatus, string pbranchper, string pcompanyname, string pcompagen, string userid, string pPW_EXP_DAYS, string ip, string mac, string preDNS, string type, Nullable<decimal> mobileno, string execModuleCode, string pMUTI_COMP, string pexeccode, string pextra1, string pextra2, string pextra3)
        {
            var userCodeParameter = userCode != null ?
                new ObjectParameter("UserCode", userCode) :
                new ObjectParameter("UserCode", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("UserType", userType) :
                new ObjectParameter("UserType", typeof(string));
    
            var userFnameParameter = userFname != null ?
                new ObjectParameter("UserFname", userFname) :
                new ObjectParameter("UserFname", typeof(string));
    
            var userLnameParameter = userLname != null ?
                new ObjectParameter("UserLname", userLname) :
                new ObjectParameter("UserLname", typeof(string));
    
            var userpasswordParameter = userpassword != null ?
                new ObjectParameter("Userpassword", userpassword) :
                new ObjectParameter("Userpassword", typeof(string));
    
            var pagencyParameter = pagency != null ?
                new ObjectParameter("pagency", pagency) :
                new ObjectParameter("pagency", typeof(string));
    
            var pdeptcodeParameter = pdeptcode != null ?
                new ObjectParameter("pdeptcode", pdeptcode) :
                new ObjectParameter("pdeptcode", typeof(string));
    
            var pbranchParameter = pbranch != null ?
                new ObjectParameter("pbranch", pbranch) :
                new ObjectParameter("pbranch", typeof(string));
    
            var pdateformatParameter = pdateformat != null ?
                new ObjectParameter("pdateformat", pdateformat) :
                new ObjectParameter("pdateformat", typeof(string));
    
            var defcompParameter = defcomp != null ?
                new ObjectParameter("defcomp", defcomp) :
                new ObjectParameter("defcomp", typeof(string));
    
            var lstcompParameter = lstcomp != null ?
                new ObjectParameter("lstcomp", lstcomp) :
                new ObjectParameter("lstcomp", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var proleParameter = prole != null ?
                new ObjectParameter("prole", prole) :
                new ObjectParameter("prole", typeof(string));
    
            var pstatusParameter = pstatus != null ?
                new ObjectParameter("pstatus", pstatus) :
                new ObjectParameter("pstatus", typeof(string));
    
            var pbranchperParameter = pbranchper != null ?
                new ObjectParameter("pbranchper", pbranchper) :
                new ObjectParameter("pbranchper", typeof(string));
    
            var pcompanynameParameter = pcompanyname != null ?
                new ObjectParameter("pcompanyname", pcompanyname) :
                new ObjectParameter("pcompanyname", typeof(string));
    
            var pcompagenParameter = pcompagen != null ?
                new ObjectParameter("pcompagen", pcompagen) :
                new ObjectParameter("pcompagen", typeof(string));
    
            var useridParameter = userid != null ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(string));
    
            var pPW_EXP_DAYSParameter = pPW_EXP_DAYS != null ?
                new ObjectParameter("PPW_EXP_DAYS", pPW_EXP_DAYS) :
                new ObjectParameter("PPW_EXP_DAYS", typeof(string));
    
            var ipParameter = ip != null ?
                new ObjectParameter("ip", ip) :
                new ObjectParameter("ip", typeof(string));
    
            var macParameter = mac != null ?
                new ObjectParameter("mac", mac) :
                new ObjectParameter("mac", typeof(string));
    
            var preDNSParameter = preDNS != null ?
                new ObjectParameter("PreDNS", preDNS) :
                new ObjectParameter("PreDNS", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var mobilenoParameter = mobileno.HasValue ?
                new ObjectParameter("mobileno", mobileno) :
                new ObjectParameter("mobileno", typeof(decimal));
    
            var execModuleCodeParameter = execModuleCode != null ?
                new ObjectParameter("ExecModuleCode", execModuleCode) :
                new ObjectParameter("ExecModuleCode", typeof(string));
    
            var pMUTI_COMPParameter = pMUTI_COMP != null ?
                new ObjectParameter("PMUTI_COMP", pMUTI_COMP) :
                new ObjectParameter("PMUTI_COMP", typeof(string));
    
            var pexeccodeParameter = pexeccode != null ?
                new ObjectParameter("pexeccode", pexeccode) :
                new ObjectParameter("pexeccode", typeof(string));
    
            var pextra1Parameter = pextra1 != null ?
                new ObjectParameter("pextra1", pextra1) :
                new ObjectParameter("pextra1", typeof(string));
    
            var pextra2Parameter = pextra2 != null ?
                new ObjectParameter("pextra2", pextra2) :
                new ObjectParameter("pextra2", typeof(string));
    
            var pextra3Parameter = pextra3 != null ?
                new ObjectParameter("pextra3", pextra3) :
                new ObjectParameter("pextra3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpsertAppUser", userCodeParameter, userNameParameter, userTypeParameter, userFnameParameter, userLnameParameter, userpasswordParameter, pagencyParameter, pdeptcodeParameter, pbranchParameter, pdateformatParameter, defcompParameter, lstcompParameter, emailParameter, proleParameter, pstatusParameter, pbranchperParameter, pcompanynameParameter, pcompagenParameter, useridParameter, pPW_EXP_DAYSParameter, ipParameter, macParameter, preDNSParameter, typeParameter, mobilenoParameter, execModuleCodeParameter, pMUTI_COMPParameter, pexeccodeParameter, pextra1Parameter, pextra2Parameter, pextra3Parameter);
        }
    
        public virtual int UpsertShopkeeper(string pCOMP_CODE, string pSHOP_TYPE, string pDISTSHOP_NAME, string pSALES_C_CODE, string pSHOP_KEEP_CODE, string pSHOP_KEEP_NAME, string pSHOP_KEEP_NICK, string pADD1, string pCITY_CODE, string pADD2, string pLOCATION_CODE, string pEMAIL_ID, string pPHONE, string pMOBILE, string pREMARKS, string pSTATUS, Nullable<System.DateTime> pSTATUS_DATE, string pEXTRA1, string pEXTRA2, string pEXTRA3, string pEXTRA4, string pEXTRA5, string iP, string pUSERID, string pTYPE)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pSHOP_TYPEParameter = pSHOP_TYPE != null ?
                new ObjectParameter("PSHOP_TYPE", pSHOP_TYPE) :
                new ObjectParameter("PSHOP_TYPE", typeof(string));
    
            var pDISTSHOP_NAMEParameter = pDISTSHOP_NAME != null ?
                new ObjectParameter("PDISTSHOP_NAME", pDISTSHOP_NAME) :
                new ObjectParameter("PDISTSHOP_NAME", typeof(string));
    
            var pSALES_C_CODEParameter = pSALES_C_CODE != null ?
                new ObjectParameter("PSALES_C_CODE", pSALES_C_CODE) :
                new ObjectParameter("PSALES_C_CODE", typeof(string));
    
            var pSHOP_KEEP_CODEParameter = pSHOP_KEEP_CODE != null ?
                new ObjectParameter("PSHOP_KEEP_CODE", pSHOP_KEEP_CODE) :
                new ObjectParameter("PSHOP_KEEP_CODE", typeof(string));
    
            var pSHOP_KEEP_NAMEParameter = pSHOP_KEEP_NAME != null ?
                new ObjectParameter("PSHOP_KEEP_NAME", pSHOP_KEEP_NAME) :
                new ObjectParameter("PSHOP_KEEP_NAME", typeof(string));
    
            var pSHOP_KEEP_NICKParameter = pSHOP_KEEP_NICK != null ?
                new ObjectParameter("PSHOP_KEEP_NICK", pSHOP_KEEP_NICK) :
                new ObjectParameter("PSHOP_KEEP_NICK", typeof(string));
    
            var pADD1Parameter = pADD1 != null ?
                new ObjectParameter("PADD1", pADD1) :
                new ObjectParameter("PADD1", typeof(string));
    
            var pCITY_CODEParameter = pCITY_CODE != null ?
                new ObjectParameter("PCITY_CODE", pCITY_CODE) :
                new ObjectParameter("PCITY_CODE", typeof(string));
    
            var pADD2Parameter = pADD2 != null ?
                new ObjectParameter("PADD2", pADD2) :
                new ObjectParameter("PADD2", typeof(string));
    
            var pLOCATION_CODEParameter = pLOCATION_CODE != null ?
                new ObjectParameter("PLOCATION_CODE", pLOCATION_CODE) :
                new ObjectParameter("PLOCATION_CODE", typeof(string));
    
            var pEMAIL_IDParameter = pEMAIL_ID != null ?
                new ObjectParameter("PEMAIL_ID", pEMAIL_ID) :
                new ObjectParameter("PEMAIL_ID", typeof(string));
    
            var pPHONEParameter = pPHONE != null ?
                new ObjectParameter("PPHONE", pPHONE) :
                new ObjectParameter("PPHONE", typeof(string));
    
            var pMOBILEParameter = pMOBILE != null ?
                new ObjectParameter("PMOBILE", pMOBILE) :
                new ObjectParameter("PMOBILE", typeof(string));
    
            var pREMARKSParameter = pREMARKS != null ?
                new ObjectParameter("PREMARKS", pREMARKS) :
                new ObjectParameter("PREMARKS", typeof(string));
    
            var pSTATUSParameter = pSTATUS != null ?
                new ObjectParameter("PSTATUS", pSTATUS) :
                new ObjectParameter("PSTATUS", typeof(string));
    
            var pSTATUS_DATEParameter = pSTATUS_DATE.HasValue ?
                new ObjectParameter("PSTATUS_DATE", pSTATUS_DATE) :
                new ObjectParameter("PSTATUS_DATE", typeof(System.DateTime));
    
            var pEXTRA1Parameter = pEXTRA1 != null ?
                new ObjectParameter("PEXTRA1", pEXTRA1) :
                new ObjectParameter("PEXTRA1", typeof(string));
    
            var pEXTRA2Parameter = pEXTRA2 != null ?
                new ObjectParameter("PEXTRA2", pEXTRA2) :
                new ObjectParameter("PEXTRA2", typeof(string));
    
            var pEXTRA3Parameter = pEXTRA3 != null ?
                new ObjectParameter("PEXTRA3", pEXTRA3) :
                new ObjectParameter("PEXTRA3", typeof(string));
    
            var pEXTRA4Parameter = pEXTRA4 != null ?
                new ObjectParameter("PEXTRA4", pEXTRA4) :
                new ObjectParameter("PEXTRA4", typeof(string));
    
            var pEXTRA5Parameter = pEXTRA5 != null ?
                new ObjectParameter("PEXTRA5", pEXTRA5) :
                new ObjectParameter("PEXTRA5", typeof(string));
    
            var iPParameter = iP != null ?
                new ObjectParameter("IP", iP) :
                new ObjectParameter("IP", typeof(string));
    
            var pUSERIDParameter = pUSERID != null ?
                new ObjectParameter("PUSERID", pUSERID) :
                new ObjectParameter("PUSERID", typeof(string));
    
            var pTYPEParameter = pTYPE != null ?
                new ObjectParameter("PTYPE", pTYPE) :
                new ObjectParameter("PTYPE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpsertShopkeeper", pCOMP_CODEParameter, pSHOP_TYPEParameter, pDISTSHOP_NAMEParameter, pSALES_C_CODEParameter, pSHOP_KEEP_CODEParameter, pSHOP_KEEP_NAMEParameter, pSHOP_KEEP_NICKParameter, pADD1Parameter, pCITY_CODEParameter, pADD2Parameter, pLOCATION_CODEParameter, pEMAIL_IDParameter, pPHONEParameter, pMOBILEParameter, pREMARKSParameter, pSTATUSParameter, pSTATUS_DATEParameter, pEXTRA1Parameter, pEXTRA2Parameter, pEXTRA3Parameter, pEXTRA4Parameter, pEXTRA5Parameter, iPParameter, pUSERIDParameter, pTYPEParameter);
        }
    
        public virtual ObjectResult<SCM_SCM_VISIT_STATUS_P_Result> GetVisitStatus(string pCOMP_CODE, string pEXTRA)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pEXTRAParameter = pEXTRA != null ?
                new ObjectParameter("PEXTRA", pEXTRA) :
                new ObjectParameter("PEXTRA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_SCM_VISIT_STATUS_P_Result>("GetVisitStatus", pCOMP_CODEParameter, pEXTRAParameter);
        }
    
        public virtual ObjectResult<PPC_PRODUCT_MAST_P_Result> GetProducts(string pCOMP_CODE, string pEXTRA)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pEXTRAParameter = pEXTRA != null ?
                new ObjectParameter("PEXTRA", pEXTRA) :
                new ObjectParameter("PEXTRA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PPC_PRODUCT_MAST_P_Result>("GetProducts", pCOMP_CODEParameter, pEXTRAParameter);
        }
    
        public virtual ObjectResult<SCM_BANK_P_Result> GetBanks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_BANK_P_Result>("GetBanks");
        }
    
        public virtual ObjectResult<SCM_STATE_P_Result> GetStates(string pSTATE_NAME)
        {
            var pSTATE_NAMEParameter = pSTATE_NAME != null ?
                new ObjectParameter("PSTATE_NAME", pSTATE_NAME) :
                new ObjectParameter("PSTATE_NAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_STATE_P_Result>("GetStates", pSTATE_NAMEParameter);
        }
    
        public virtual int AddMeeting(string p_COMP_CODE, string p_CENT_CODE, string p_SCM_CODE, string p_STATE_CODE, string p_CITY_CODE, string p_TYPE_CODE, string p_LOCATION_CODE, string p_DISTRIBUTOR_CODE, string p_DIST_PRODUCT, string p_DIST_REMARKS, string p_CLIENT_CODE, string p_CLIENT_NAME, string p_MOBILE, string p_VISIT_STATUS, string p_ADDR1, string p_ADDR2, Nullable<System.DateTime> p_NEXT_DATE, string p_PAY_MODE, string p_CHEQUE_NO, Nullable<System.DateTime> p_CHEQUE_DATE, string p_BANK_CODE, string p_BANK_NAME, Nullable<decimal> p_AMOUNT, string p_CLIENT_PRODUCT, string p_PHOTO_PATH, string p_ORDER_Y_N, string p_REMARKS, string p_EMI, string p_CREATED_BY, string p_EXTRA, string p_EXTRA1, string p_EXTRA2)
        {
            var p_COMP_CODEParameter = p_COMP_CODE != null ?
                new ObjectParameter("P_COMP_CODE", p_COMP_CODE) :
                new ObjectParameter("P_COMP_CODE", typeof(string));
    
            var p_CENT_CODEParameter = p_CENT_CODE != null ?
                new ObjectParameter("P_CENT_CODE", p_CENT_CODE) :
                new ObjectParameter("P_CENT_CODE", typeof(string));
    
            var p_SCM_CODEParameter = p_SCM_CODE != null ?
                new ObjectParameter("P_SCM_CODE", p_SCM_CODE) :
                new ObjectParameter("P_SCM_CODE", typeof(string));
    
            var p_STATE_CODEParameter = p_STATE_CODE != null ?
                new ObjectParameter("P_STATE_CODE", p_STATE_CODE) :
                new ObjectParameter("P_STATE_CODE", typeof(string));
    
            var p_CITY_CODEParameter = p_CITY_CODE != null ?
                new ObjectParameter("P_CITY_CODE", p_CITY_CODE) :
                new ObjectParameter("P_CITY_CODE", typeof(string));
    
            var p_TYPE_CODEParameter = p_TYPE_CODE != null ?
                new ObjectParameter("P_TYPE_CODE", p_TYPE_CODE) :
                new ObjectParameter("P_TYPE_CODE", typeof(string));
    
            var p_LOCATION_CODEParameter = p_LOCATION_CODE != null ?
                new ObjectParameter("P_LOCATION_CODE", p_LOCATION_CODE) :
                new ObjectParameter("P_LOCATION_CODE", typeof(string));
    
            var p_DISTRIBUTOR_CODEParameter = p_DISTRIBUTOR_CODE != null ?
                new ObjectParameter("P_DISTRIBUTOR_CODE", p_DISTRIBUTOR_CODE) :
                new ObjectParameter("P_DISTRIBUTOR_CODE", typeof(string));
    
            var p_DIST_PRODUCTParameter = p_DIST_PRODUCT != null ?
                new ObjectParameter("P_DIST_PRODUCT", p_DIST_PRODUCT) :
                new ObjectParameter("P_DIST_PRODUCT", typeof(string));
    
            var p_DIST_REMARKSParameter = p_DIST_REMARKS != null ?
                new ObjectParameter("P_DIST_REMARKS", p_DIST_REMARKS) :
                new ObjectParameter("P_DIST_REMARKS", typeof(string));
    
            var p_CLIENT_CODEParameter = p_CLIENT_CODE != null ?
                new ObjectParameter("P_CLIENT_CODE", p_CLIENT_CODE) :
                new ObjectParameter("P_CLIENT_CODE", typeof(string));
    
            var p_CLIENT_NAMEParameter = p_CLIENT_NAME != null ?
                new ObjectParameter("P_CLIENT_NAME", p_CLIENT_NAME) :
                new ObjectParameter("P_CLIENT_NAME", typeof(string));
    
            var p_MOBILEParameter = p_MOBILE != null ?
                new ObjectParameter("P_MOBILE", p_MOBILE) :
                new ObjectParameter("P_MOBILE", typeof(string));
    
            var p_VISIT_STATUSParameter = p_VISIT_STATUS != null ?
                new ObjectParameter("P_VISIT_STATUS", p_VISIT_STATUS) :
                new ObjectParameter("P_VISIT_STATUS", typeof(string));
    
            var p_ADDR1Parameter = p_ADDR1 != null ?
                new ObjectParameter("P_ADDR1", p_ADDR1) :
                new ObjectParameter("P_ADDR1", typeof(string));
    
            var p_ADDR2Parameter = p_ADDR2 != null ?
                new ObjectParameter("P_ADDR2", p_ADDR2) :
                new ObjectParameter("P_ADDR2", typeof(string));
    
            var p_NEXT_DATEParameter = p_NEXT_DATE.HasValue ?
                new ObjectParameter("P_NEXT_DATE", p_NEXT_DATE) :
                new ObjectParameter("P_NEXT_DATE", typeof(System.DateTime));
    
            var p_PAY_MODEParameter = p_PAY_MODE != null ?
                new ObjectParameter("P_PAY_MODE", p_PAY_MODE) :
                new ObjectParameter("P_PAY_MODE", typeof(string));
    
            var p_CHEQUE_NOParameter = p_CHEQUE_NO != null ?
                new ObjectParameter("P_CHEQUE_NO", p_CHEQUE_NO) :
                new ObjectParameter("P_CHEQUE_NO", typeof(string));
    
            var p_CHEQUE_DATEParameter = p_CHEQUE_DATE.HasValue ?
                new ObjectParameter("P_CHEQUE_DATE", p_CHEQUE_DATE) :
                new ObjectParameter("P_CHEQUE_DATE", typeof(System.DateTime));
    
            var p_BANK_CODEParameter = p_BANK_CODE != null ?
                new ObjectParameter("P_BANK_CODE", p_BANK_CODE) :
                new ObjectParameter("P_BANK_CODE", typeof(string));
    
            var p_BANK_NAMEParameter = p_BANK_NAME != null ?
                new ObjectParameter("P_BANK_NAME", p_BANK_NAME) :
                new ObjectParameter("P_BANK_NAME", typeof(string));
    
            var p_AMOUNTParameter = p_AMOUNT.HasValue ?
                new ObjectParameter("P_AMOUNT", p_AMOUNT) :
                new ObjectParameter("P_AMOUNT", typeof(decimal));
    
            var p_CLIENT_PRODUCTParameter = p_CLIENT_PRODUCT != null ?
                new ObjectParameter("P_CLIENT_PRODUCT", p_CLIENT_PRODUCT) :
                new ObjectParameter("P_CLIENT_PRODUCT", typeof(string));
    
            var p_PHOTO_PATHParameter = p_PHOTO_PATH != null ?
                new ObjectParameter("P_PHOTO_PATH", p_PHOTO_PATH) :
                new ObjectParameter("P_PHOTO_PATH", typeof(string));
    
            var p_ORDER_Y_NParameter = p_ORDER_Y_N != null ?
                new ObjectParameter("P_ORDER_Y_N", p_ORDER_Y_N) :
                new ObjectParameter("P_ORDER_Y_N", typeof(string));
    
            var p_REMARKSParameter = p_REMARKS != null ?
                new ObjectParameter("P_REMARKS", p_REMARKS) :
                new ObjectParameter("P_REMARKS", typeof(string));
    
            var p_EMIParameter = p_EMI != null ?
                new ObjectParameter("P_EMI", p_EMI) :
                new ObjectParameter("P_EMI", typeof(string));
    
            var p_CREATED_BYParameter = p_CREATED_BY != null ?
                new ObjectParameter("P_CREATED_BY", p_CREATED_BY) :
                new ObjectParameter("P_CREATED_BY", typeof(string));
    
            var p_EXTRAParameter = p_EXTRA != null ?
                new ObjectParameter("P_EXTRA", p_EXTRA) :
                new ObjectParameter("P_EXTRA", typeof(string));
    
            var p_EXTRA1Parameter = p_EXTRA1 != null ?
                new ObjectParameter("P_EXTRA1", p_EXTRA1) :
                new ObjectParameter("P_EXTRA1", typeof(string));
    
            var p_EXTRA2Parameter = p_EXTRA2 != null ?
                new ObjectParameter("P_EXTRA2", p_EXTRA2) :
                new ObjectParameter("P_EXTRA2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddMeeting", p_COMP_CODEParameter, p_CENT_CODEParameter, p_SCM_CODEParameter, p_STATE_CODEParameter, p_CITY_CODEParameter, p_TYPE_CODEParameter, p_LOCATION_CODEParameter, p_DISTRIBUTOR_CODEParameter, p_DIST_PRODUCTParameter, p_DIST_REMARKSParameter, p_CLIENT_CODEParameter, p_CLIENT_NAMEParameter, p_MOBILEParameter, p_VISIT_STATUSParameter, p_ADDR1Parameter, p_ADDR2Parameter, p_NEXT_DATEParameter, p_PAY_MODEParameter, p_CHEQUE_NOParameter, p_CHEQUE_DATEParameter, p_BANK_CODEParameter, p_BANK_NAMEParameter, p_AMOUNTParameter, p_CLIENT_PRODUCTParameter, p_PHOTO_PATHParameter, p_ORDER_Y_NParameter, p_REMARKSParameter, p_EMIParameter, p_CREATED_BYParameter, p_EXTRAParameter, p_EXTRA1Parameter, p_EXTRA2Parameter);
        }
    
        public virtual ObjectResult<SCM_APP_FETCH_Result> GetMeeting(string p_COMP_CODE, string p_CENT_CODE, string p_SCM_CODE, string p_STATE_CODE, string p_CITY_CODE, string p_TYPE_CODE, string p_LOCATION_CODE, string p_DISTRIBUTOR_CODE, string p_USER_ID, Nullable<System.DateTime> p_FROM_DATE, Nullable<System.DateTime> p_TO_DATE, string p_REPORT_TYPE, string p_EXTRA, string p_EXTRA1, string p_EXTRA2)
        {
            var p_COMP_CODEParameter = p_COMP_CODE != null ?
                new ObjectParameter("P_COMP_CODE", p_COMP_CODE) :
                new ObjectParameter("P_COMP_CODE", typeof(string));
    
            var p_CENT_CODEParameter = p_CENT_CODE != null ?
                new ObjectParameter("P_CENT_CODE", p_CENT_CODE) :
                new ObjectParameter("P_CENT_CODE", typeof(string));
    
            var p_SCM_CODEParameter = p_SCM_CODE != null ?
                new ObjectParameter("P_SCM_CODE", p_SCM_CODE) :
                new ObjectParameter("P_SCM_CODE", typeof(string));
    
            var p_STATE_CODEParameter = p_STATE_CODE != null ?
                new ObjectParameter("P_STATE_CODE", p_STATE_CODE) :
                new ObjectParameter("P_STATE_CODE", typeof(string));
    
            var p_CITY_CODEParameter = p_CITY_CODE != null ?
                new ObjectParameter("P_CITY_CODE", p_CITY_CODE) :
                new ObjectParameter("P_CITY_CODE", typeof(string));
    
            var p_TYPE_CODEParameter = p_TYPE_CODE != null ?
                new ObjectParameter("P_TYPE_CODE", p_TYPE_CODE) :
                new ObjectParameter("P_TYPE_CODE", typeof(string));
    
            var p_LOCATION_CODEParameter = p_LOCATION_CODE != null ?
                new ObjectParameter("P_LOCATION_CODE", p_LOCATION_CODE) :
                new ObjectParameter("P_LOCATION_CODE", typeof(string));
    
            var p_DISTRIBUTOR_CODEParameter = p_DISTRIBUTOR_CODE != null ?
                new ObjectParameter("P_DISTRIBUTOR_CODE", p_DISTRIBUTOR_CODE) :
                new ObjectParameter("P_DISTRIBUTOR_CODE", typeof(string));
    
            var p_USER_IDParameter = p_USER_ID != null ?
                new ObjectParameter("P_USER_ID", p_USER_ID) :
                new ObjectParameter("P_USER_ID", typeof(string));
    
            var p_FROM_DATEParameter = p_FROM_DATE.HasValue ?
                new ObjectParameter("P_FROM_DATE", p_FROM_DATE) :
                new ObjectParameter("P_FROM_DATE", typeof(System.DateTime));
    
            var p_TO_DATEParameter = p_TO_DATE.HasValue ?
                new ObjectParameter("P_TO_DATE", p_TO_DATE) :
                new ObjectParameter("P_TO_DATE", typeof(System.DateTime));
    
            var p_REPORT_TYPEParameter = p_REPORT_TYPE != null ?
                new ObjectParameter("P_REPORT_TYPE", p_REPORT_TYPE) :
                new ObjectParameter("P_REPORT_TYPE", typeof(string));
    
            var p_EXTRAParameter = p_EXTRA != null ?
                new ObjectParameter("P_EXTRA", p_EXTRA) :
                new ObjectParameter("P_EXTRA", typeof(string));
    
            var p_EXTRA1Parameter = p_EXTRA1 != null ?
                new ObjectParameter("P_EXTRA1", p_EXTRA1) :
                new ObjectParameter("P_EXTRA1", typeof(string));
    
            var p_EXTRA2Parameter = p_EXTRA2 != null ?
                new ObjectParameter("P_EXTRA2", p_EXTRA2) :
                new ObjectParameter("P_EXTRA2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SCM_APP_FETCH_Result>("GetMeeting", p_COMP_CODEParameter, p_CENT_CODEParameter, p_SCM_CODEParameter, p_STATE_CODEParameter, p_CITY_CODEParameter, p_TYPE_CODEParameter, p_LOCATION_CODEParameter, p_DISTRIBUTOR_CODEParameter, p_USER_IDParameter, p_FROM_DATEParameter, p_TO_DATEParameter, p_REPORT_TYPEParameter, p_EXTRAParameter, p_EXTRA1Parameter, p_EXTRA2Parameter);
        }
    
        public virtual int UpsertLocation(string pCOMP_CODE, string pLOC_CODE, string cITY_CODE, string pLOC_NAME, string pREMARKS, string pSTATUS, string pIP, string pCREATED_BY, string type)
        {
            var pCOMP_CODEParameter = pCOMP_CODE != null ?
                new ObjectParameter("PCOMP_CODE", pCOMP_CODE) :
                new ObjectParameter("PCOMP_CODE", typeof(string));
    
            var pLOC_CODEParameter = pLOC_CODE != null ?
                new ObjectParameter("PLOC_CODE", pLOC_CODE) :
                new ObjectParameter("PLOC_CODE", typeof(string));
    
            var cITY_CODEParameter = cITY_CODE != null ?
                new ObjectParameter("CITY_CODE", cITY_CODE) :
                new ObjectParameter("CITY_CODE", typeof(string));
    
            var pLOC_NAMEParameter = pLOC_NAME != null ?
                new ObjectParameter("PLOC_NAME", pLOC_NAME) :
                new ObjectParameter("PLOC_NAME", typeof(string));
    
            var pREMARKSParameter = pREMARKS != null ?
                new ObjectParameter("PREMARKS", pREMARKS) :
                new ObjectParameter("PREMARKS", typeof(string));
    
            var pSTATUSParameter = pSTATUS != null ?
                new ObjectParameter("PSTATUS", pSTATUS) :
                new ObjectParameter("PSTATUS", typeof(string));
    
            var pIPParameter = pIP != null ?
                new ObjectParameter("PIP", pIP) :
                new ObjectParameter("PIP", typeof(string));
    
            var pCREATED_BYParameter = pCREATED_BY != null ?
                new ObjectParameter("PCREATED_BY", pCREATED_BY) :
                new ObjectParameter("PCREATED_BY", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpsertLocation", pCOMP_CODEParameter, pLOC_CODEParameter, cITY_CODEParameter, pLOC_NAMEParameter, pREMARKSParameter, pSTATUSParameter, pIPParameter, pCREATED_BYParameter, typeParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> GenerateNextNum()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("GenerateNextNum");
        }
    }
}

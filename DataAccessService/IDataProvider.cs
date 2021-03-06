﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using AuthenticationService;
using System.IdentityModel.Tokens;

namespace DataAccessService
{
    [ServiceContract]
    interface IDataProvider
    {
        [OperationContract]
        [FaultContract(typeof(SecurityTokenException))]
        [FaultContract(typeof(AuthenticationService.DbException))]
        DataTable GetData(Selector selector, AuthenticationService.User user);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        [FaultContract(typeof(SecurityTokenException))]
        [FaultContract(typeof(AuthenticationService.DbException))]
        void UpdateData(Updater updater, DataTable table, AuthenticationService.User user);
    }
}

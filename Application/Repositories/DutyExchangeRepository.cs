﻿using Domain.Models;
using System;
using System.Collections.Generic;

namespace Application.Repositories
{
    public static class DutyExchangeRepository
    {
        private readonly static object thisLock = new object();
        private static List<DutyExchange> dutyExchanges = new List<DutyExchange>();
        public static void AddDutyExchange(DutyExchange dutyExchange)
        {
            lock (thisLock)
            {
                if (!DutyExchangeExist(dutyExchange))
                    dutyExchanges.Add(dutyExchange);
            }

        }

        public static bool DutyExchangeExist(DutyExchange dutyExchange)
        {
            bool exist = false;
            foreach (DutyExchange dutyExchange2 in dutyExchanges)
            {
                if (dutyExchange2.DutyID == dutyExchange.DutyID && dutyExchange2.EmployeeID == dutyExchange.EmployeeID)
                {
                    if (dutyExchange2.DutyExchangeID != dutyExchange.DutyExchangeID)
                    {
                        dutyExchange2.DutyExchangeID = dutyExchange.DutyExchangeID;
                    }
                    exist = true;
                }
            }
            return exist;
        }

        public static List<DutyExchange> GetDutyExchanges()
        {
            return dutyExchanges;
        }


        public static void RemoveDutyExchange(int dutyID, int employeeID)
        {
            lock (thisLock)
            {
                foreach (DutyExchange dutyExchange2 in dutyExchanges)
                {
                    if (dutyExchange2.DutyID == dutyID && dutyExchange2.EmployeeID == employeeID)
                    {
                        dutyExchanges.Remove(dutyExchange2);
                    }
                }
            }
        }
    }
}
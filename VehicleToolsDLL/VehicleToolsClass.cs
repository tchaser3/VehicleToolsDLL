/* Title:           Vehicle Tools Class
 * Date:            3-21-18
 * Author:          Terry Holmes
 * 
 * Description:     This class is for vehicle tools */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleToolsDLL
{
    public class VehicleToolsClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        VehicleToolsDataSet aVehicleToolsDataSet;
        VehicleToolsDataSetTableAdapters.vehicletoolsTableAdapter aVehicleToolsTableAdapter;

        InsertVehicleToolsEntryTableAdapters.QueriesTableAdapter aInsertVehicleToolsTableAdapter;

        UpdateOnBoardVehicleToolEntryTableAdapters.QueriesTableAdapter aUpdateOnBoardVehicleToolTableAdapter;

        UpdateVehicleToolsTransactionDateEntryTableAdapters.QueriesTableAdapter aUpdateVehicleToolTransactionDateTableAdapter;

        RemoveToolFromVehicleEntryTableAdapters.QueriesTableAdapter aRemoveToolFromVehicleTableAdapter;

        FindToolsAssignedToVehicleDataSet aFindToolsAssignedToVehicleDataSet;
        FindToolsAssignedToVehicleDataSetTableAdapters.FindToolsAssignedToVehicleTableAdapter aFindToolsAssignedToVehicleTableAdapter;

        FindToolsCurrentlyAssignedToVehicleDataSet aFindToolsCurrentByAssignedVehicleDataSet;
        FindToolsCurrentlyAssignedToVehicleDataSetTableAdapters.FindToolsCurrentlyAssignedToVehicleTableAdapter aFindToolsCurrentByAssignedVehicleTableAdapter;

        FindToolsAssignedToVehicleNotOnBoadDataSet aFindToolsAssignedToVehicleNotOnBoardDataSet;
        FindToolsAssignedToVehicleNotOnBoadDataSetTableAdapters.FindToolsAssignedToVehiclesNotOnBoardTableAdapter aFindToolsAssignedToVehicleNotOnBoardTableAdapter;

        FindVehicleToolsByToolKeyDataSet aFindVehicleToolsByToolKeyDataSet;
        FindVehicleToolsByToolKeyDataSetTableAdapters.FindVehicleToolsByToolKeyTableAdapter aFindVehicleToolsByToolKeyTableAdapter;

        public FindVehicleToolsByToolKeyDataSet FindVehicleToolsbyToolKey(int intToolKey)
        {
            try
            {
                aFindVehicleToolsByToolKeyDataSet = new FindVehicleToolsByToolKeyDataSet();
                aFindVehicleToolsByToolKeyTableAdapter = new FindVehicleToolsByToolKeyDataSetTableAdapters.FindVehicleToolsByToolKeyTableAdapter();
                aFindVehicleToolsByToolKeyTableAdapter.Fill(aFindVehicleToolsByToolKeyDataSet.FindVehicleToolsByToolKey, intToolKey); 
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Find Tools by Tool Key " + Ex.Message);
            }

            return aFindVehicleToolsByToolKeyDataSet;
        }
        public FindToolsAssignedToVehicleNotOnBoadDataSet FindToolsAssignedToVehicleNotOnBoard()
        {
            try
            {
                aFindToolsAssignedToVehicleNotOnBoardDataSet = new FindToolsAssignedToVehicleNotOnBoadDataSet();
                aFindToolsAssignedToVehicleNotOnBoardTableAdapter = new FindToolsAssignedToVehicleNotOnBoadDataSetTableAdapters.FindToolsAssignedToVehiclesNotOnBoardTableAdapter();
                aFindToolsAssignedToVehicleNotOnBoardTableAdapter.Fill(aFindToolsAssignedToVehicleNotOnBoardDataSet.FindToolsAssignedToVehiclesNotOnBoard);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Find Tools Assigned to Vehicle Not On Board " + Ex.Message);
            }

            return aFindToolsAssignedToVehicleNotOnBoardDataSet;
        }
        public FindToolsCurrentlyAssignedToVehicleDataSet FindToolsCurrentlyAssignedToVehicle(int intBJCNumber)
        {
            try
            {
                aFindToolsCurrentByAssignedVehicleDataSet = new FindToolsCurrentlyAssignedToVehicleDataSet();
                aFindToolsCurrentByAssignedVehicleTableAdapter = new FindToolsCurrentlyAssignedToVehicleDataSetTableAdapters.FindToolsCurrentlyAssignedToVehicleTableAdapter();
                aFindToolsCurrentByAssignedVehicleTableAdapter.Fill(aFindToolsCurrentByAssignedVehicleDataSet.FindToolsCurrentlyAssignedToVehicle, intBJCNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Find Tools Currently Assigned to Vehicle " + Ex.Message);
            }

            return aFindToolsCurrentByAssignedVehicleDataSet;
        }
        public FindToolsAssignedToVehicleDataSet FindToolsAssignedToVehicle(int intBJCNumber)
        {
            try
            {
                aFindToolsAssignedToVehicleDataSet = new FindToolsAssignedToVehicleDataSet();
                aFindToolsAssignedToVehicleTableAdapter = new FindToolsAssignedToVehicleDataSetTableAdapters.FindToolsAssignedToVehicleTableAdapter();
                aFindToolsAssignedToVehicleTableAdapter.Fill(aFindToolsAssignedToVehicleDataSet.FindToolsAssignedToVehicle, intBJCNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tool Class // Find Tools Assigned To Vehicle " + Ex.Message);
            }

            return aFindToolsAssignedToVehicleDataSet;
        }
        public bool RemoveToolFromVehicle(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveToolFromVehicleTableAdapter = new RemoveToolFromVehicleEntryTableAdapters.QueriesTableAdapter();
                aRemoveToolFromVehicleTableAdapter.RemoveToolFromVehicle(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Remove Tool From Vehicle " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehicleToolTransactionDate(int intTransactionID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleToolTransactionDateTableAdapter = new UpdateVehicleToolsTransactionDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleToolTransactionDateTableAdapter.UpdateVehicleToolTransactionDate(intTransactionID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Update Vehicle Transaction Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateOnBoardVehicleTool(int intTransactionID, bool blnOnBoard)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateOnBoardVehicleToolTableAdapter = new UpdateOnBoardVehicleToolEntryTableAdapters.QueriesTableAdapter();
                aUpdateOnBoardVehicleToolTableAdapter.UpdateOnBoardVehicleTool(intTransactionID, blnOnBoard);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Update On Board Vehicle Tool " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertVehicleTools(int intVehicleID, int intToolKey, DateTime datTransactionDate, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleToolsTableAdapter = new InsertVehicleToolsEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleToolsTableAdapter.InsertVehicleTools(intVehicleID, intToolKey, true, datTransactionDate, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Insert Vehicle Tools " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public VehicleToolsDataSet GetVehicleToolsInfo()
        {
            try
            {
                aVehicleToolsDataSet = new VehicleToolsDataSet();
                aVehicleToolsTableAdapter = new VehicleToolsDataSetTableAdapters.vehicletoolsTableAdapter();
                aVehicleToolsTableAdapter.Fill(aVehicleToolsDataSet.vehicletools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Get Vehicle Tools Info " + Ex.Message);
            }

            return aVehicleToolsDataSet;
        }
        public void UpdateVehicleToolsDB(VehicleToolsDataSet aVehicleToolsDataSet)
        {
            try
            {
                aVehicleToolsTableAdapter = new VehicleToolsDataSetTableAdapters.vehicletoolsTableAdapter();
                aVehicleToolsTableAdapter.Update(aVehicleToolsDataSet.vehicletools);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Tools Class // Update Vehicle Tools DB " + Ex.Message);
            }
        }
    }
}

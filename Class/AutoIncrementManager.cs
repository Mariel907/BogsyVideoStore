using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public static class AutoIncrementManager
    {
        private static int SerialNoCount;
        private static int currentCounter;
        private static int DocumentNo;
        private static int RentalCount;

        public static int GetNextEntryNo()
        {
            GetNextEntryNoFromDB();
            return currentCounter;
        }

        private static int GetNextEntryNoFromDB()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GetNextEntryNoFromDB", con);
                    object result = cmd.ExecuteScalar();

                    currentCounter = result != null? Convert.ToInt32(result) : 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return currentCounter++;
        }

        public static string GetNextDocumentNo( string prefix = "D")
        {
            GetNextDocumentNoFromDB();
            return $"{prefix}{DocumentNo}";
        }

        private static int GetNextDocumentNoFromDB()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GetNextDocumentNoFromDB", con);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string resultString = result.ToString();
                        if (resultString.StartsWith("D"))
                            DocumentNo = Convert.ToInt32(resultString.Substring(1).Trim());
                        else
                            DocumentNo = Convert.ToInt32(resultString);
                    }
                    else
                        DocumentNo = 999;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DocumentNo++;
        }

        public static int GetNextSerialID()
        {
            GetNextSerialIDFromDB();
            return SerialNoCount;
        }
        private static int GetNextSerialIDFromDB()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GetNextSerialIDFromDB", con);
                    object result = cmd.ExecuteScalar();

                    SerialNoCount = result != null ? Convert.ToInt32(result) : 99;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SerialNoCount++;
        }

        public static int GetNextRentalID()
        {
            GetNextRentalIDFromDB();
            return RentalCount;
        }

        private static int GetNextRentalIDFromDB()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("GetNextRentalID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    object result = cmd.ExecuteScalar();

                    RentalCount = result != null ? Convert.ToInt32(result) : 99999;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return RentalCount++;
        }
    }
}

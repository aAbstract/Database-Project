using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System;

namespace db_project
{
    class utils
    {
        
        // Compute SHA256 To a Givin String
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create()) // Create SHS256 Object
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData)); // Compute SHA256 Byte Array (Encoded HASH)
                // Construct String Representaion For The Computed SHA256 Byte Array (Encoded HASH)
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString(); // return String Represntaion of the HASH (Decoded HASH)
            }
        }

        // Alerts Helper Functions
        // Information Alert
        public static void show_info(string msg)
        {
            MessageBox.Show(msg, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // ERROR Alert
        public static void show_error(string msg)
        {
            MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static string role_map(int role_id)
        {
            switch (role_id)
            {
                case 0:
                    return "Super Admin";
                case 1:
                    return "Health Admin";
                case 2:
                    return "Public Admin";
                case 3:
                    return "Doctor";
                case 4:
                    return "Pharmacist";
                case 5:
                    return "Citizen";
                default:
                    return null;
            }
        }
        public static int role_map(string role_name)
        {
            switch (role_name)
            {
                case "Super Admin":
                    return 0;
                case "Health Admin":
                    return 1;
                case "Public Admin":
                    return 2;
                case "Doctor":
                    return 3;
                case "Pharmacist":
                    return 4;
                case "Citizen":
                    return 5;
                default:
                    return -1;
            }
        }

        // Export Excel Sheet
        public static void write_excel(string file_name, DataGridView source_dgv)
        {
            // Use Excel API to Create File
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true; 
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported Table";
            // Construct Table From <source_dgv> Object
            for (int i = 1; i < source_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = source_dgv.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < source_dgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < source_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = source_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }
            // Write The Constructed Object To The Disk
            workbook.SaveAs(file_name, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }

        // Write Text File
        public static void write_txt(string content, string file_name)
        {
            System.IO.File.WriteAllText(file_name, content);
        }
    }
}

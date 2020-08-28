using System;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace db_project
{
    class data_access
    {
        public static db_manager dbm = new db_manager();
        // Database Utils
        public static string login(string user_name, string password)
        {
            string query_string = "SELECT UserName,Priv FROM Users WHERE UserName = @user AND pass_hash = @pass_hash";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@user", user_name);
            cmd.Parameters.AddWithValue("@pass_hash", utils.ComputeSha256Hash(password));
            SqlDataReader reader = data_access.dbm.execute_reader(cmd);
            string output = string.Empty;
            if (reader.Read())
            {
                output = reader["UserName"] + ":" + reader["Priv"];
            }
            reader.Close();
            return output;
        }
        public static bool is_connected()
        {
            return data_access.dbm.get_conn_state() == System.Data.ConnectionState.Open ? true : false;
        }
        public static DataTable get_data_source(string view_name)
        {
            string query_string = "SELECT * FROM " + view_name;
            SqlDataAdapter data_adapter = new SqlDataAdapter(query_string, data_access.dbm.conn_obj);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataSet[] get_hospital_gi_feed(string id)
        {
            DataSet[] output_val = new DataSet[2];
            if (id != "")
            {
                string get_reg_gi_query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID IN (SELECT Government_ID FROM Governmen_Hospitals WHERE Hospital_ID = @hos_id);";
                string get_dreg_gi_query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID NOT IN (SELECT Government_ID FROM Governmen_Hospitals WHERE Hospital_ID = @hos_id);";
                output_val = new DataSet[2];
                SqlCommand cmd = new SqlCommand(get_reg_gi_query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@hos_id", id);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                output_val[1] = ds;
                cmd = new SqlCommand(get_dreg_gi_query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@hos_id", id);
                data_adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                data_adapter.Fill(ds);
                output_val[0] = ds;
            } 
            else
            {
                output_val[0] = data_access.get_data_source("gov_insu_info").DataSet;
                output_val[1] = null;
            }
            return output_val;
        }
        public static DataSet[] get_med_conf_feed(string id)
        {
            DataSet[] output_val = new DataSet[2];
            if (id != "")
            {
                string get_reg_gi_query_string = "SELECT * FROM Medicines WHERE Medicines.ID IN (SELECT Confluct_ID FROM Conflict_Medicine WHERE Medicine_ID = @med_id);";
                string get_dreg_gi_query_string = "SELECT * FROM Medicines WHERE Medicines.ID NOT IN (SELECT Confluct_ID FROM Conflict_Medicine WHERE Medicine_ID = @med_id);";
                output_val = new DataSet[2];
                SqlCommand cmd = new SqlCommand(get_reg_gi_query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                output_val[1] = ds;
                cmd = new SqlCommand(get_dreg_gi_query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                data_adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                data_adapter.Fill(ds);
                output_val[0] = ds;
            }
            else
            {
                output_val[0] = data_access.get_data_source("Medicines").DataSet;
                output_val[1] = null;
            }
            return output_val;
        }
        public static DataSet[] get_med_insu_feed(string id)
        {
            DataSet[] output_val = new DataSet[2];
            if (id != "")
            {
                string get_reg_gi_query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID IN (SELECT Governmnet_ID FROM Government_Medicine WHERE Medicine_ID = @med_id);";
                string get_dreg_gi_query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID NOT IN (SELECT Governmnet_ID FROM Government_Medicine WHERE Medicine_ID = @med_id);";
                output_val = new DataSet[2];
                SqlCommand cmd = new SqlCommand(get_reg_gi_query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                output_val[1] = ds;
                cmd = new SqlCommand(get_dreg_gi_query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                data_adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                data_adapter.Fill(ds);
                output_val[0] = ds;
            }
            else
            {
                output_val[0] = data_access.get_data_source("gov_insu_info").DataSet;
                output_val[1] = null;
            }
            return output_val;
        }
        public static void create_backup(string file_name)
        {
            string query_string = "BACKUP DATABASE health_db TO DISK = '" + file_name + "'";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void load_backup(string file_name)
        {
            string query_string = "RESTORE health_db FROM DISK = '" + file_name + "'";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            data_access.dbm.execute_nonreader(cmd);
        }
        public static DataSet[] get_med_phr_feed(string id)
        {
            DataSet[] output_val = new DataSet[2];
            string phr_reg_med = "SELECT * FROM Medicines WHERE Medicines.ID IN (SELECT Pharmacy_Medicine.Medicine_ID FROM Pharmacy_Medicine WHERE Pharmacy_Medicine.Pharmacy_ID = @id)";
            string phr_dreg_med = "SELECT * FROM Medicines WHERE Medicines.ID NOT IN (SELECT Pharmacy_Medicine.Medicine_ID FROM Pharmacy_Medicine WHERE Pharmacy_Medicine.Pharmacy_ID = @id)";
            output_val = new DataSet[2];
            SqlCommand cmd = new SqlCommand(phr_reg_med, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            output_val[1] = ds;
            cmd = new SqlCommand(phr_dreg_med, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@id", id);
            data_adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            data_adapter.Fill(ds);
            output_val[0] = ds;
            return output_val;
        }
        // Universal Database Utils
        public static DataTable uni_search_engine(string db_channel, string seed)
        {
            string query_string = "SELECT * FROM " + data_access.channel_veiw_map(db_channel) + " WHERE ";
            switch (db_channel)
            {
                case "Citizens":
                    query_string += data_access.construct_seed_parameter(new string[] { "SSN", "Name", "BirthDate", "Address", "Phone", "[GOV INSU ADDRESS]", "[GOV INSU NAME]" });
                    break;
                case "Doctors":
                    query_string += data_access.construct_seed_parameter(new string[] { "SSN", "Name", "BirthDate", "Address", "Phone", "Specialization", "[GOV INSU ADDRESS]", "[GOV INSU NAME]" });
                    break;
                case "Clinics":
                    query_string += data_access.construct_seed_parameter(new string[] { "DOCTOR NAME", "Address", "Phone", "Specializtion" });
                    break;
                case "Governmental Insurance":
                    query_string += data_access.construct_seed_parameter(new string[] { "ID", "Name", "Phone", "Address" });
                    break;
                case "Hospitals":
                    query_string += data_access.construct_seed_parameter(new string[] { "ID", "Name", "Phone", "Manager", "Address", "Specialization", "[GOV INSU ADDRESS]", "[GOV INSU NAME]" });
                    break;
                case "Medicines":
                    query_string += data_access.construct_seed_parameter(new string[] { "ID", "Name", "Active_Ingredient" });
                    break;
                case "Pharmacist":
                    query_string += data_access.construct_seed_parameter(new string[] { "SSN", "Name", "BirthDate", "Phone", "Address", "Specialization" });
                    break;
                case "Pharmacy":
                    query_string += data_access.construct_seed_parameter(new string[] { "ID", "Name", "Phone", "OWNER NAME", "[OWNER PHONE]" });
                    break;
                case "System Admins":
                    query_string += data_access.construct_seed_parameter(new string[] { "SSN", "Username", "role_name", "email" });
                    break;
                default:
                    return null;
            }
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@seed", seed);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        private static string construct_seed_parameter(string[] params_name)
        {
            string output = "" ;
            for (int i = 0; i < params_name.Length; i++)
            {
                if (i == params_name.Length - 1)
                {
                    output += (params_name[i] + " LIKE @seed + '%'");
                }
                else
                {
                    output += (params_name[i] + " LIKE @seed + '%' OR ");
                }
            }
            return output;
        }
        private static string channel_veiw_map(string channel)
        {
            switch (channel)
            {
                case "Citizens":
                    return "citizens_info";
                case "Doctors":
                    return "doctors_info";
                case "Clinics":
                    return "clinics_info";
                case "Governmental Insurance":
                    return "gov_insu_info";
                case "Hospitals":
                    return "hospitals_info";
                case "Pharmacy":
                    return "pharmacies_info";
                case "System Admins":
                    return "admins_info";
                case "Medicines":
                case "Pharmacist":
                    return channel;
                default:
                    return null;
            }
        }
        public static void uni_delete(string db_channel, string id, string[] extra_params)
        {
            string query_string = "DELETE FROM " + data_access.channel_mt_map(db_channel) + " WHERE ";
            switch (db_channel)
            {
                case "Citizens":
                case "Doctors":
                case "Pharmacist":
                case "System Admins":
                    query_string += "SSN = @id";
                    break;
                case "Governmental Insurance":
                case "Hospitals":
                case "Medicines":
                case "Pharmacy":
                    query_string += "ID = @id";
                    break;
                case "Clinics":
                    query_string += "Doctor_SSN = @id AND Address = @arga";
                    break;
                default:
                    return;
            }
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            if (extra_params.Length == 0)
            {
                cmd.Parameters.AddWithValue("@id", id);
            }
            else
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@arga", extra_params[0]);
            }
            data_access.dbm.execute_nonreader(cmd);
        }
        private static string channel_mt_map(string channel)
        {
            switch (channel)
            {
                case "Citizens":
                    return "Citizen";
                case "Doctors":
                    return "Doctor";
                case "Clinics":
                    return "Clinic";
                case "Governmental Insurance":
                    return "Government_Insurance";
                case "Hospitals":
                    return "Hospital";
                case "Pharmacy":
                    return "Pharmacy";
                case "System Admins":
                    return "Users";
                case "Medicines":
                case "Pharmacist":
                    return channel;
                default:
                    return null;
            }
        }
        public static string uni_report(bool is_brief, string channel, string id)
        {
            StringBuilder output = new StringBuilder("");
            switch (channel)
            {
                case "Citizens":
                    output.Append("\t\tCitizen Detailed Report\n");
                    string query_string = "SELECT * FROM citizens_info WHERE SSN = @id";
                    SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                    cmd.Parameters.AddWithValue("@id", id);
                    DataSet res = new DataSet();
                    new SqlDataAdapter(cmd).Fill(res);
                    for (int i = 0; i < res.Tables[0].Columns.Count; i++)
                    {
                        output.Append(res.Tables[0].Columns[i].ColumnName + ": " + res.Tables[0].Rows[0][i].ToString() + "\n");
                    }
                    if (!is_brief)
                    {
                        query_string = "SELECT Name, StartDate, EndDate FROM Disease WHERE Citizen_SSN = @id";
                        cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                        cmd.Parameters.AddWithValue("@id", id);
                        res = new DataSet();
                        new SqlDataAdapter(cmd).Fill(res);
                        output.Append("Citizen Disease History:\n");
                        output.Append("\tName\tFrom\tTo\n");
                        for (int i = 0; i < res.Tables[0].Rows.Count; i++)
                        {
                            output.Append("\t" + res.Tables[0].Rows[i][0].ToString().Trim() + "\t" + res.Tables[0].Rows[i][1].ToString().Trim() + "\t" + res.Tables[0].Rows[i][2].ToString().Trim() + "\n");
                        }
                        query_string = "SELECT Medicines.Name, Citizen_Medicine.Date, Citizen_Medicine.date_end FROM Citizen_Medicine INNER JOIN Medicines ON Citizen_Medicine.Medicine_ID = Medicines.ID WHERE Citizen_Medicine.Citizen_SSN = @id";
                        cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                        cmd.Parameters.AddWithValue("@id", id);
                        res = new DataSet();
                        new SqlDataAdapter(cmd).Fill(res);
                        output.Append("Citizen Medicine History:\n");
                        output.Append("\tName\tFrom\tTo\n");
                        for (int i = 0; i < res.Tables[0].Rows.Count; i++)
                        {
                            output.Append("\t" + res.Tables[0].Rows[i][0].ToString().Trim() + "\t" + res.Tables[0].Rows[i][1].ToString().Trim() + "\t" + res.Tables[0].Rows[i][2].ToString().Trim() + "\n");
                        }
                    }
                    break;
                case "Doctors":
                    output.Append("\t\tDoctor Detailed Report\n");
                    query_string = "SELECT * FROM doctors_info WHERE SSN = @id";
                    cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                    cmd.Parameters.AddWithValue("@id", id);
                    res = new DataSet();
                    new SqlDataAdapter(cmd).Fill(res);
                    for (int i = 0; i < res.Tables[0].Columns.Count; i++)
                    {
                        output.Append(res.Tables[0].Columns[i].ColumnName + ": " + res.Tables[0].Rows[0][i].ToString() + "\n");
                    }
                    if (!is_brief)
                    {
                        query_string = "SELECT * FROM clinics_info WHERE clinics_info.[DOCTOR NAME] = (SELECT Doctor.Name FROM Doctor WHERE Doctor.SSN = @id)";
                        cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                        cmd.Parameters.AddWithValue("@id", id);
                        res = new DataSet();
                        new SqlDataAdapter(cmd).Fill(res);
                        output.Append("Clinics\n");
                        output.Append("\tAddress\tPhone\tSpecializtion\n");
                        DataSet temp = new DataSet();
                        SqlCommand temp_cmd = new SqlCommand("SELECT Citizen.Name, Citizen_Clinic.Rate FROM Citizen_Clinic INNER JOIN Citizen ON Citizen_Clinic.Citizen_SSN = Citizen.SSN WHERE Citizen_Clinic.Doctor_SSN = @id AND Citizen_Clinic.Address = @addr", data_access.dbm.conn_obj);
                        SqlCommand temp_cmd2 = new SqlCommand("SELECT AVG(Citizen_Clinic.Rate) FROM Citizen_Clinic INNER JOIN Citizen ON Citizen_Clinic.Citizen_SSN = Citizen.SSN WHERE Citizen_Clinic.Doctor_SSN = @id AND Citizen_Clinic.Address = @addr", data_access.dbm.conn_obj);
                        for (int i = 0; i < res.Tables[0].Rows.Count; i++)
                        {
                            output.Append("\t" + res.Tables[0].Rows[i][1].ToString().Trim() + "\t" + res.Tables[0].Rows[i][2].ToString().Trim() + "\t" + res.Tables[0].Rows[i][3].ToString().Trim() + "\n");
                            temp_cmd.Parameters.AddWithValue("@id", data_access.get_doctor_id(res.Tables[0].Rows[i][0].ToString()));
                            temp_cmd.Parameters.AddWithValue("@addr", res.Tables[0].Rows[i][1].ToString());
                            new SqlDataAdapter(temp_cmd).Fill(temp);
                            output.Append("\t\tCitizen Name\tRate\n");
                            for (int j = 0; j < temp.Tables[0].Rows.Count; j++)
                            {
                                output.Append("\t\t" + res.Tables[0].Rows[j][0].ToString().Trim() + "\t" + res.Tables[0].Rows[j][1].ToString().Trim() + "\n");
                            }
                            temp_cmd2.Parameters.AddWithValue("@id", data_access.get_doctor_id(res.Tables[0].Rows[i][0].ToString()));
                            temp_cmd2.Parameters.AddWithValue("@addr", res.Tables[0].Rows[i][1].ToString());
                            new SqlDataAdapter(temp_cmd2).Fill(temp);
                            output.Append("\t\t AVG_RATE: " + temp.Tables[0].Rows[0][0].ToString().Trim() + "\n");
                        }
                        output.Append("Hospitals Worked For\n");
                        temp_cmd = new SqlCommand("SELECT Hospital.Name, Rate FROM Hospita_Employee INNER JOIN Hospital ON Hospital.ID = Hospita_Employee.Hospital_ID WHERE Hospita_Employee.Doctor_SSN = @id", data_access.dbm.conn_obj);
                        temp_cmd.Parameters.AddWithValue("@id", id);
                        new SqlDataAdapter(temp_cmd).Fill(temp);
                        output.Append("\tHospital Name\tRate\n");
                        for (int j = 0; j < temp.Tables[0].Rows.Count; j++)
                        {
                            output.Append("\t" + temp.Tables[0].Rows[j][0].ToString().Trim() + "\t" + res.Tables[0].Rows[j][1].ToString().Trim() + "\n");
                        }
                    }
                    break;
                case "Hospitals":
                    output.Append("\tHospital Detailed Report\n");
                    query_string = "SELECT * FROM hospitals_info WHERE ID = @id";
                    cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                    cmd.Parameters.AddWithValue("@id", id);
                    res = new DataSet();
                    new SqlDataAdapter(cmd).Fill(res);
                    for (int i = 0; i < res.Tables[0].Columns.Count - 2; i++)
                    {
                        output.Append(res.Tables[0].Columns[i].ColumnName + ": " + res.Tables[0].Rows[0][i].ToString() + "\n");
                    }
                    if (!is_brief)
                    {
                        output.Append("\tEmployee\tRate\n");
                        query_string = "SELECT Doctor.Name, Hospita_Employee.Rate FROM Hospita_Employee INNER JOIN Doctor ON Hospita_Employee.Doctor_SSN = Doctor.SSN WHERE Hospita_Employee.Hospital_ID = @id;";
                        cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                        cmd.Parameters.AddWithValue("@id", id);
                        res = new DataSet();
                        new SqlDataAdapter(cmd).Fill(res);
                        for (int j = 0; j < res.Tables[0].Rows.Count; j++)
                        {
                            output.Append("\t" + res.Tables[0].Rows[j][0].ToString().Trim() + "\t" + res.Tables[0].Rows[j][1].ToString().Trim() + "\n");
                        }
                    }
                    break;
                case "Pharmacy":
                    output.Append("\tPharmay Detaild Report\n");
                    query_string = "SELECT * FROM pharmacies_info WHERE ID = @id";
                    cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                    cmd.Parameters.AddWithValue("@id", id);
                    res = new DataSet();
                    new SqlDataAdapter(cmd).Fill(res);
                    for (int i = 0; i < res.Tables[0].Columns.Count - 2; i++)
                    {
                        output.Append(res.Tables[0].Columns[i].ColumnName + ": " + res.Tables[0].Rows[0][i].ToString() + "\n");
                    }
                    if (!is_brief)
                    {
                        output.Append("\tAvailable Medicine\n");
                        query_string = "SELECT Medicines.Name FROM Pharmacy_Medicine INNER JOIN Medicines ON Pharmacy_Medicine.Medicine_ID = Medicines.ID WHERE Pharmacy_Medicine.Pharmacy_ID = @id";
                        cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                        cmd.Parameters.AddWithValue("@id", id);
                        res = new DataSet();
                        new SqlDataAdapter(cmd).Fill(res);
                        for (int j = 0; j < res.Tables[0].Rows.Count; j++)
                        {
                            output.Append("\t\t" + res.Tables[0].Rows[j][0].ToString().Trim() + "\n");
                        }
                        output.Append("\tPharmacy Activity Report\n");
                        output.Append("\t\tCitzen Name\tDoctor Name\tRate\n");
                        query_string = "SELECT Citizen.Name, Doctor.Name, Rate FROM Citizen_Pharmacy INNER JOiN Citizen ON Citizen_Pharmacy.Citize_SSN = Citizen.SSN INNER JOIN Doctor ON Citizen_Pharmacy.Doctor_SSN = Doctor.SSN WHERE Citizen_Pharmacy.Pharmacy_ID = @id";
                        cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                        cmd.Parameters.AddWithValue("@id", id);
                        res = new DataSet();
                        new SqlDataAdapter(cmd).Fill(res);
                        for (int j = 0; j < res.Tables[0].Rows.Count; j++)
                        {
                            output.Append("\t\t" + res.Tables[0].Rows[j][0].ToString().Trim() + "\t" + res.Tables[0].Rows[j][1].ToString().Trim() + "\t" + res.Tables[0].Rows[j][2].ToString().Trim() + "\n");
                        }
                    }
                    break;
                default:
                    return null;
            }
            return output.ToString();
        }
        // Database CRUD Operations
        public static void cu_citizen(bool flag, string ssn, string name, string dob, string address, string phone, string gov_insu_id)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_citizen" : "add_citizen", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ssn", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@dob", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@gov_insu_id", SqlDbType.Int));
            cmd.Parameters["@ssn"].Value = int.Parse(ssn);
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@dob"].Value = dob;
            cmd.Parameters["@address"].Value = address;
            cmd.Parameters["@phone"].Value = phone;
            cmd.Parameters["@gov_insu_id"].Value = (gov_insu_id == "" ? -1 : int.Parse(gov_insu_id));
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cu_doctor(bool flag, string ssn, string name, string dob, string address, string phone, string spec, string gov_insu_id)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_doctor" : "add_doctor", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ssn", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@dob", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@spec", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@gov_insu_id", SqlDbType.Int));
            cmd.Parameters["@ssn"].Value = int.Parse(ssn);
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@dob"].Value = dob;
            cmd.Parameters["@address"].Value = address;
            cmd.Parameters["@phone"].Value = phone;
            cmd.Parameters["@spec"].Value = spec;
            cmd.Parameters["@gov_insu_id"].Value = (gov_insu_id == "" ? -1 : int.Parse(gov_insu_id));
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cu_clinic(bool flag, string doc_name, string address, string phone, string spec)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_clinic" : "add_clinic", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@dssn", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@spec", SqlDbType.NChar));
            cmd.Parameters["@dssn"].Value = int.Parse(doc_name);
            cmd.Parameters["@address"].Value = address;
            cmd.Parameters["@phone"].Value = phone;
            cmd.Parameters["@spec"].Value = spec;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cu_gov_inus(bool flag, string id, string name, string phone, string address)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_gov_insu" : "add_gov_insu", data_access.dbm.conn_obj);   
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
            cmd.Parameters["@id"].Value = int.Parse(id);
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@address"].Value = address;
            cmd.Parameters["@phone"].Value = phone;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cu_phramacist(bool flag, string ssn, string name, string dob, string phone, string address, string spec)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_pharmacist" : "add_pharmacist", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ssn", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@dob", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@spec", SqlDbType.NChar));
            cmd.Parameters["@ssn"].Value = int.Parse(ssn);
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@dob"].Value = dob;
            cmd.Parameters["@phone"].Value = phone;
            cmd.Parameters["@address"].Value = address;
            cmd.Parameters["@spec"].Value = spec;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cu_pharmacy(bool flag, string id, string name, string phone, string owner_ssn)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_pharmacy" : "add_pharmacy", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@owner_ssn", SqlDbType.Int));
            cmd.Parameters["@id"].Value = int.Parse(id);
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@phone"].Value = phone;
            cmd.Parameters["@owner_ssn"].Value = int.Parse(owner_ssn);
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cu_hospital(bool flag, string id, string name, string phone, string manager, string address, string spec)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_hospital" : "add_hospital", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@manager", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@spec", SqlDbType.NChar));
            cmd.Parameters["@id"].Value = int.Parse(id);
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@phone"].Value = phone;
            cmd.Parameters["@manager"].Value = manager;
            cmd.Parameters["@address"].Value = address;
            cmd.Parameters["@spec"].Value = spec;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cd_hos_gov(bool flag, string[] hos_id, string[] gov_id)
        {
            SqlCommand cmd = new SqlCommand(flag ? "rem_hospital_inus" : "add_hospital_inus", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@hos_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@gov_id", SqlDbType.Int));
            for (int i = 0; i < hos_id.Length; i++)
            {
                cmd.Parameters["@hos_id"].Value = int.Parse(hos_id[i]);
                cmd.Parameters["@gov_id"].Value = int.Parse(gov_id[i]);
                data_access.dbm.execute_nonreader(cmd);
            }
        }
        public static void cu_medicine(bool flag, string id, string name, string ai)
        {
            SqlCommand cmd = new SqlCommand(flag ? "update_medicine" : "add_medicine", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@ai", SqlDbType.NChar));
            cmd.Parameters["@id"].Value = int.Parse(id);
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@ai"].Value = ai;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cd_med_conf(bool flag, string[] med_id, string[] conf_id)
        {
            SqlCommand cmd = new SqlCommand(flag ? "rem_med_conf" : "add_med_conf", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@med_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@conf_id", SqlDbType.Int));
            for (int i = 0; i < med_id.Length; i++)
            {
                cmd.Parameters["@med_id"].Value = int.Parse(med_id[i]);
                cmd.Parameters["@conf_id"].Value = int.Parse(conf_id[i]);
                data_access.dbm.execute_nonreader(cmd);
            }
        }
        public static void cd_med_gov(bool flag, string[] med_id, string[] gov_id)
        {
            SqlCommand cmd = new SqlCommand(flag ? "rem_med_insu" : "add_med_insu", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@med_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@insu_id", SqlDbType.Int));
            for (int i = 0; i < med_id.Length; i++)
            {
                cmd.Parameters["@med_id"].Value = int.Parse(med_id[i]);
                cmd.Parameters["@insu_id"].Value = int.Parse(gov_id[i]);
                data_access.dbm.execute_nonreader(cmd);
            }
        }
        // Searching Functions
        public static DataTable gov_insu_search(string seed)
        {
            string query_string = "SELECT * FROM Government_Insurance WHERE ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Phone LIKE @seed + '%' OR Address LIKE @seed + '%'";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@seed", seed);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable med_search(string seed)
        {
            string query_string = "SELECT * FROM Medicines WHERE ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Active_Ingredient LIKE @seed + '%'";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@seed", seed);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable doctor_search(string seed)
        {
            string query_string = "SELECT * FROM Doctor WHERE SSN LIKE @seed + '%' OR Name LIKE @seed + '%' OR BirthDate LIKE @seed + '%' OR Phone LIKE @seed + '%' OR Address LIKE @seed + '%' OR Specialization LIKE @seed + '%'";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@seed", seed);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable phist_search(string seed)
        {
            string query_string = "SELECT * FROM Pharmacist WHERE SSN LIKE @seed + '%' OR Name LIKE @seed + '%' OR BirthDate LIKE @seed + '%' OR Phone LIKE @seed + '%' OR Address LIKE @seed + '%' OR Specialization LIKE @seed + '%'";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@seed", seed);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable dreg_hgi_search(string id, string seed)
        {
            if (id == "")
            {
                return data_access.gov_insu_search(seed);
            }
            else
            {
                string query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID NOT IN (SELECT Government_ID FROM Governmen_Hospitals WHERE Hospital_ID = @hos_id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Phone LIKE @seed + '%' OR Address LIKE @seed + '%');";
                SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@hos_id", id);
                cmd.Parameters.AddWithValue("@seed", seed);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public static DataTable dreg_mcgi_search(string id, string seed)
        {
            if (id == "")
            {
                return data_access.gov_insu_search(seed);
            }
            else
            {
                string query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID NOT IN (SELECT Governmnet_ID FROM Government_Medicine WHERE Medicine_ID = @med_id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Phone LIKE @seed + '%' OR Address LIKE @seed + '%');";
                SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                cmd.Parameters.AddWithValue("@seed", seed);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public static DataTable reg_hgi_search(string id, string seed)
        {
            if (id == "")
            {
                return null;
            }
            else
            {
                string query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID IN (SELECT Government_ID FROM Governmen_Hospitals WHERE Hospital_ID = @hos_id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Phone LIKE @seed + '%' OR Address LIKE @seed + '%');";
                SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@hos_id", id);
                cmd.Parameters.AddWithValue("@seed", seed);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public static DataTable reg_mgi_search(string id, string seed)
        {
            if (id == "")
            {
                return null;
            }
            else
            {
                string query_string = "SELECT * FROM gov_insu_info WHERE gov_insu_info.ID IN (SELECT Governmnet_ID FROM Government_Medicine WHERE Medicine_ID = @med_id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Phone LIKE @seed + '%' OR Address LIKE @seed + '%');";
                SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                cmd.Parameters.AddWithValue("@seed", seed);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public static DataTable nrmc_search(string id, string seed)
        {
            if (id == "")
            {
                return data_access.med_search(seed);
            }
            else
            {
                string query_string = "SELECT * FROM Medicines WHERE Medicines.ID NOT IN (SELECT Confluct_ID FROM Conflict_Medicine WHERE Medicine_ID = @med_id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Active_Ingredient LIKE @seed + '%');";
                SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                cmd.Parameters.AddWithValue("@seed", seed);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public static DataTable rmc_search(string id, string seed)
        {
            if (id == "")
            {
                return null;
            }
            else
            {
                string query_string = "SELECT * FROM Medicines WHERE Medicines.ID IN (SELECT Confluct_ID FROM Conflict_Medicine WHERE Medicine_ID = @med_id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Active_Ingredient LIKE @seed + '%');";
                SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
                cmd.Parameters.AddWithValue("@med_id", id);
                cmd.Parameters.AddWithValue("@seed", seed);
                SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data_adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public static DataTable get_dis_his_by_id(string id)
        {
            string query_string = "SELECT * FROM Disease WHERE Disease.Citizen_SSN = @id";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable get_dis_his_by_id_search(string id, string seed)
        {
            string query_string = "SELECT * FROM Disease WHERE Disease.Citizen_SSN = @id AND (Disease.Name LIKE @seed + '%' OR Disease.Citizen_SSN LIKE @seed + '%' OR Disease.StartDate LIKE @seed + '%' OR Disease.EndDate LIKE @seed + '%')";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@seed", seed);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static void add_med_cit_rel(string cit_id, string med_id, string ds, string de)
        {
            SqlCommand cmd = new SqlCommand("add_med_cit_rel", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cit_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@med_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ds", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@de", SqlDbType.Date));
            cmd.Parameters["@cit_id"].Value = cit_id;
            cmd.Parameters["@med_id"].Value = med_id;
            cmd.Parameters["@ds"].Value = ds;
            cmd.Parameters["@de"].Value = de;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void add_dis_cit_rel(string dis_name, string cit_id, string ds, string de)
        {
            SqlCommand cmd = new SqlCommand("add_dis_cit_rel", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@dis_name", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@cit_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ds", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@de", SqlDbType.Date));
            cmd.Parameters["@dis_id"].Value = dis_name;
            cmd.Parameters["@cit_id"].Value = cit_id;
            cmd.Parameters["@ds"].Value = ds;
            cmd.Parameters["@de"].Value = de;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void add_user(string user_name, string pass, int priv, string ssn, string email)
        {
            SqlCommand cmd = new SqlCommand("add_user", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NChar));
            cmd.Parameters.Add(new SqlParameter("@pass_hash", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@priv", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@ssn", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
            cmd.Parameters["@user_name"].Value = user_name;
            cmd.Parameters["@pass_hash"].Value = utils.ComputeSha256Hash(pass);
            cmd.Parameters["@priv"].Value = priv;
            cmd.Parameters["@ssn"].Value = int.Parse(ssn);
            cmd.Parameters["@email"].Value = email;
            data_access.dbm.execute_nonreader(cmd);
        }
        public static void cd_med_phr_rel(bool flag, string med_id, string phr_id)
        {
            SqlCommand cmd = new SqlCommand(flag ? "rem_phr_med_rel" : "add_phr_med_rel", data_access.dbm.conn_obj);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@med_id", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@phr_id", SqlDbType.Int));
            cmd.Parameters["@med_id"].Value = int.Parse(med_id);
            cmd.Parameters["@phr_id"].Value = int.Parse(phr_id);
            data_access.dbm.execute_nonreader(cmd);
        }
        public static DataSet[] med_phr_search(string id, string seed)
        {
            DataSet[] output_val = new DataSet[2];
            string phr_reg_med = "SELECT * FROM Medicines WHERE Medicines.ID IN (SELECT Pharmacy_Medicine.Medicine_ID FROM Pharmacy_Medicine WHERE Pharmacy_Medicine.Pharmacy_ID = @id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Active_Ingredient LIKE @seed + '%')";
            string phr_dreg_med = "SELECT * FROM Medicines WHERE Medicines.ID NOT IN (SELECT Pharmacy_Medicine.Medicine_ID FROM Pharmacy_Medicine WHERE Pharmacy_Medicine.Pharmacy_ID = @id) AND (ID LIKE @seed + '%' OR Name LIKE @seed + '%' OR Active_Ingredient LIKE @seed + '%')";
            output_val = new DataSet[2];
            SqlCommand cmd = new SqlCommand(phr_reg_med, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@seed", seed);
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data_adapter.Fill(ds);
            output_val[1] = ds;
            cmd = new SqlCommand(phr_dreg_med, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@seed", seed);
            data_adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            data_adapter.Fill(ds);
            output_val[0] = ds;
            return output_val;
        }
        // Mapping Fetch Functions
        public static string get_insu_id(string insu_name)
        {
            string query_string = "SELECT ID FROM Government_Insurance WHERE Name = @name";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@name", insu_name.Trim());
            SqlDataReader reader = data_access.dbm.execute_reader(cmd);
            string output = string.Empty;
            if (reader.Read())
            {
                output = reader["ID"].ToString();
            }
            reader.Close();
            return output;
        }
        public static string get_doctor_id(string doc_name)
        {
            string query_string = "SELECT SSN FROM Doctor WHERE Name = @name";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@name", doc_name.Trim());
            SqlDataReader reader = data_access.dbm.execute_reader(cmd);
            string output = string.Empty;
            if (reader.Read())
            {
                output = reader["SSN"].ToString();
            }
            reader.Close();
            return output;
        }
        public static string get_phist_id(string phist_name)
        {
            string query_string = "SELECT SSN FROM Pharmacist WHERE Name = @name";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@name", phist_name.Trim());
            SqlDataReader reader = data_access.dbm.execute_reader(cmd);
            string output = string.Empty;
            if (reader.Read())
            {
                output = reader["SSN"].ToString();
            }
            reader.Close();
            return output;
        }
        // User Information Access
        public static string get_user_info(string user_name, string req)
        {
            string query_string = "SELECT " + req + " FROM Users WHERE Username = @user_name";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@user_name", user_name.Trim());
            SqlDataReader reader = data_access.dbm.execute_reader(cmd);
            string output = string.Empty;
            if (reader.Read())
            {
                output = reader[req].ToString();
            }
            reader.Close();
            switch (req)
            {
                case "Priv":
                    return utils.role_map(int.Parse(output));
                case "SSN":
                case "pass_hash":
                case "email":
                    return output;
                default:
                    return null;
            }
        }
        public static void reset_user_data(string user_name, string target, string new_value)
        {
            string query_string = "UPDATE Users SET " + target + " = @new_value WHERE Username = @user_name";
            SqlCommand cmd = new SqlCommand(query_string, data_access.dbm.conn_obj);
            cmd.Parameters.AddWithValue("@new_value", new_value.Trim());
            cmd.Parameters.AddWithValue("@user_name", user_name.Trim());
            data_access.dbm.execute_nonreader(cmd);
        }
    }
}

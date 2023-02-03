using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelDAL
{
    public class ToolsDAL
    {
        #region Doldur

        public void ComboDoldur(ComboBox cbx , string spname, string sqlType)
        {
            List<KeyValuePair<int,string>> c = new List<KeyValuePair<int,string>>();
            
            SqlDataReader cbxdeneme = BilgiHotelHelperSQL.myExecuteReader(spname, null, sqlType);

            while (cbxdeneme.Read())
            {
                c.Add(new KeyValuePair<int, string>((int)cbxdeneme[0], (string)cbxdeneme[1]));
            }

            cbx.DataSource= c.ToList();
            cbx.ValueMember = "Key";
            cbx.DisplayMember = "Value";
            cbx.SelectedIndex = -1;

            cbxdeneme.Close();
        }

        public void IntComboDoldur(ComboBox cbx, string spname, string sqlType)
        {
            List<KeyValuePair<int, int>> c = new List<KeyValuePair<int, int>>();

            SqlDataReader cbxoda = BilgiHotelHelperSQL.myExecuteReader(spname, null, sqlType);

            while (cbxoda.Read())
            {
                c.Add(new KeyValuePair<int, int>((int)cbxoda[0], (int)cbxoda[1]));
            }

            cbx.DataSource = c.ToList();
            cbx.ValueMember = "Key";
            cbx.DisplayMember = "Value";
            cbx.SelectedIndex = -1;

            cbxoda.Close();
        }

        public void PersonelComboDoldur(ComboBox cbx , string spname, string sqlType)
        {

            List<KeyValuePair<string, string>> c = new List<KeyValuePair<string, string>>();
            SqlDataReader cbxpersonel = BilgiHotelHelperSQL.myExecuteReader(spname, null, sqlType);

            while (cbxpersonel.Read())
            {
                c.Add(new KeyValuePair<string, string>((string)cbxpersonel[0], (string)cbxpersonel[1]));
            }

            cbx.DataSource = c.ToList();
            cbx.ValueMember = "Key";
            cbx.DisplayMember = "Value";
            cbx.SelectedIndex = -1;

            cbxpersonel.Close();
        }

        public void ListViewDoldur(ListView List, string spname, SqlParameter[] sqlParameters, string sptype)
        {
            List.Items.Clear();
            List.Columns.Clear();
            List.GridLines = true;
            List.FullRowSelect= true;
            List.View = View.Details;

            SqlDataReader read = BilgiHotelHelperSQL.myExecuteReader(spname, sqlParameters, sptype);

            for (int i = 0; i < read.FieldCount; i++)
            {
                List.Columns.Add(read.GetName(i), 100);
            }
            while (read.Read())
            {
                ListViewItem ekleme = new ListViewItem(read[0].ToString());
                for (int i = 1; i < read.FieldCount; i++)
                {
                    ekleme.SubItems.Add(read[i].ToString());
                }
                List.Items.Add(ekleme);
            }
            read.Close();
        }

        public void FormDoldur(string cmdtext, string cmdtype, Form frm)
        {
            SqlDataReader read = BilgiHotelHelperSQL.myExecuteReader(cmdtext, null,cmdtype);

            read.Read();

            foreach (Control item in frm.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = read[(item as TextBox).TabIndex].ToString();
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = read[(item as MaskedTextBox).TabIndex].ToString();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = Convert.ToInt32(read[(item as ComboBox).TabIndex]) - 1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = Convert.ToBoolean(read[(item as CheckBox).TabIndex]);

                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = Convert.ToBoolean(read[(item as RadioButton).TabIndex]); ;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = Convert.ToDateTime(read[(item as DateTimePicker).TabIndex]);
                }
                
                else if (item is GroupBox)
                {
                    GroupBoxDoldur(cmdtext, cmdtype, (GroupBox)item);
                }
            }
        }
        public void GroupBoxDoldur(string cmdtext, string cmdtype, GroupBox gb)
        {
            SqlDataReader read = BilgiHotelHelperSQL.myExecuteReader(cmdtext, null, cmdtype);

            read.Read();

            foreach (Control item in gb.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = read[(item as TextBox).TabIndex].ToString();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = Convert.ToInt32(read[(item as ComboBox).TabIndex])-1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = Convert.ToBoolean(read[(item as CheckBox).TabIndex]);

                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = Convert.ToBoolean(read[(item as RadioButton).TabIndex]); ;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = Convert.ToDateTime(read[(item as DateTimePicker).TabIndex]);
                }
                else if (item is GroupBox)
                {
                    GroupBoxDoldur( cmdtext,  cmdtype,  gb);
                }
            }

            
        }
        public void ListBoxDoldur(string cmdtext, string cmdtype, ListBox lb)
        {
            SqlDataReader read = BilgiHotelHelperSQL.myExecuteReader(cmdtext, null, cmdtype);

            read.Read();

            foreach (Control item in lb.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = read[(item as TextBox).TabIndex].ToString();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = Convert.ToInt32(read[(item as ComboBox).TabIndex]) - 1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = Convert.ToBoolean(read[(item as CheckBox).TabIndex]);

                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = Convert.ToBoolean(read[(item as RadioButton).TabIndex]); ;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = Convert.ToDateTime(read[(item as DateTimePicker).TabIndex]);
                }
               
            }

        }
        public static void Temizle(Control cl)
        {
            foreach (var item in cl.Controls)
            {
                if (item is TextBox) ((TextBox)item).Text = String.Empty;
                if (item is NumericUpDown) ((NumericUpDown)item).Value = 0;
                if (item is MaskedTextBox) ((MaskedTextBox)item).Text = String.Empty;
                if (item is DateTimePicker) ((DateTimePicker)item).Value= DateTime.Now;
                if (item is ListBox) ((ListBox)item).SelectedIndex= 0;
                if (item is ListView) ((ListView)item).Items.Clear();
            }
        }

       
    }
    #endregion


}

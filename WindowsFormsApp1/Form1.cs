using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 
{
	public partial class Form1 : Form
    {
        private Queue queue = new Queue();
        static int count = 1;
		public Form1() 
		{
			InitializeComponent();
		}
        public void resetForm() 
		{
            for (int i = Controls.Count - 1; i != 0; i--)
            {
                if (Controls[i].Name.Equals("Patient_button2"))
                {
                    Controls[i].Dispose();
                    break;
                }
            }
			for (int i = Controls.Count - 1; i != 0; i--) {
				if (Controls[i] is Label || Controls[i] is TextBox || Controls[i] is ComboBox) {
					Controls[i].Dispose();
				}
			}
			for (int i = Controls.Count - 1; i != 0; i--) {
				if (Controls[i] is Button && Controls[i].Text.Contains("Dr")) {
					Controls[i].Dispose();
				}
			}
		}
		public void drawPatientForm() 
		{
			resetForm();
			Patient_textBox1 = new TextBox();
            Patient_button2 = new Button();
			Patient_label1 = new Label();
			Patient_label2 = new Label();
			Patient_label3 = new Label();
			Patient_label4 = new Label();
			Patient_comboBox1 = new ComboBox();
			Patient_comboBox2 = new ComboBox();
			Patient_comboBox3 = new ComboBox();

            // 
            // Patient_button2
            // 
            this.Patient_button2.Location = new System.Drawing.Point(167, 200);
            this.Patient_button2.Name = "Patient_button2";
            this.Patient_button2.Size = new System.Drawing.Size(75, 23);
            this.Patient_button2.TabIndex = 2;
            this.Patient_button2.Text = "Add Record";
            this.Patient_button2.UseVisualStyleBackColor = true;
            this.Patient_button2.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // textBox1
            // 
            this.Patient_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.Patient_textBox1.Location = new System.Drawing.Point(167, 72);
			this.Patient_textBox1.Name = "textBox1";
			this.Patient_textBox1.Size = new System.Drawing.Size(294, 20);
			this.Patient_textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.Patient_label1.AutoSize = true;
			this.Patient_label1.Location = new System.Drawing.Point(87, 75);
			this.Patient_label1.Name = "label1";
			this.Patient_label1.Size = new System.Drawing.Size(74, 13);
			this.Patient_label1.TabIndex = 3;
			this.Patient_label1.Text = "Patient Name:";
			// 
			// label2
			// 
			this.Patient_label2.AutoSize = true;
			this.Patient_label2.Location = new System.Drawing.Point(86, 115);
			this.Patient_label2.Name = "label2";
			this.Patient_label2.Size = new System.Drawing.Size(75, 13);
			this.Patient_label2.TabIndex = 4;
			this.Patient_label2.Text = "Disease Type:";
			// 
			// label3
			// 
			this.Patient_label3.AutoSize = true;
			this.Patient_label3.Location = new System.Drawing.Point(97, 150);
			this.Patient_label3.Name = "label3";
			this.Patient_label3.Size = new System.Drawing.Size(64, 13);
			this.Patient_label3.TabIndex = 5;
			this.Patient_label3.Text = "Blood Type:";
			// 
			// label4
			// 
			this.Patient_label4.AutoSize = true;
			this.Patient_label4.Location = new System.Drawing.Point(116, 177);
			this.Patient_label4.Name = "label4";
			this.Patient_label4.Size = new System.Drawing.Size(45, 13);
			this.Patient_label4.TabIndex = 6;
			this.Patient_label4.Text = "Gender:";
			// 
			// comboBox1
			// 
			this.Patient_comboBox1.AllowDrop = true;
			this.Patient_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Patient_comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Patient_comboBox1.FormattingEnabled = true;
			this.Patient_comboBox1.Items.AddRange(new object[] {
			"A+",
			"A-",
			"B+",
			"B-",
			"AB+",
			"AB-",
			"O+",
			"O-"});
			this.Patient_comboBox1.Location = new System.Drawing.Point(167, 147);
			this.Patient_comboBox1.Name = "comboBox1";
			this.Patient_comboBox1.Size = new System.Drawing.Size(121, 21);
			this.Patient_comboBox1.TabIndex = 7;
			// 
			// comboBox2
			// 
			this.Patient_comboBox2.AllowDrop = true;
			this.Patient_comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Patient_comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Patient_comboBox2.FormattingEnabled = true;
			this.Patient_comboBox2.Items.AddRange(new object[] {
			"Oncologist",
			"Cardiovascular",
			"Neurologist",
			"Psychiatrist",
			"Dermatoligist"});
			this.Patient_comboBox2.Location = new System.Drawing.Point(167, 112);
			this.Patient_comboBox2.Name = "comboBox2";
			this.Patient_comboBox2.Size = new System.Drawing.Size(121, 21);
			this.Patient_comboBox2.TabIndex = 8;
			// 
			// comboBox3
			// 
			this.Patient_comboBox3.AllowDrop = true;
			this.Patient_comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Patient_comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Patient_comboBox3.FormattingEnabled = true;
			this.Patient_comboBox3.Items.AddRange(new object[] {
			"Male",
			"Female",
			"Non Binary"});
			this.Patient_comboBox3.Location = new System.Drawing.Point(167, 174);
			this.Patient_comboBox3.Name = "comboBox3";
			this.Patient_comboBox3.Size = new System.Drawing.Size(121, 21);
			this.Patient_comboBox3.TabIndex = 9;
			this.Controls.Add(this.Patient_comboBox3);
			this.Controls.Add(this.Patient_comboBox2);
			this.Controls.Add(this.Patient_comboBox1);
            this.Controls.Add(this.Patient_button2);
			this.Controls.Add(this.Patient_label4);
			this.Controls.Add(this.Patient_label3);
			this.Controls.Add(this.Patient_label2);
			this.Controls.Add(this.Patient_label1);
			this.Controls.Add(this.Patient_textBox1);
		}

		public void drawAdminForm() {
			resetForm();
			tableLayoutPanel1 = new TableLayoutPanel();
			Admin_button1 = new Button();
			Admin_button2 = new Button();
			Admin_button3 = new Button();
			Admin_button4 = new Button();
			Admin_button5 = new Button();

			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((AnchorStyles) Top | (AnchorStyles) Left);
			this.tableLayoutPanel1.Padding = new Padding(40);
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.Admin_button5, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.Admin_button4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.Admin_button3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.Admin_button2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Admin_button1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 70);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1119, 368);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// button1
			// 
			this.Admin_button1.Location = new System.Drawing.Point(3, 3);
			this.Admin_button1.Name = "Admin_button1";
			this.Admin_button1.Size = new System.Drawing.Size(218, 362);
			this.Admin_button1.TabIndex = 3;
			this.Admin_button1.Text = "Dr Johnny";
			this.Admin_button1.UseVisualStyleBackColor = true;
            this.Admin_button1.Click += new System.EventHandler(this.abutton1_Click);
            // 
            // button2
            // 
            this.Admin_button2.Location = new System.Drawing.Point(227, 3);
			this.Admin_button2.Name = "Admin_button2";
			this.Admin_button2.Size = new System.Drawing.Size(218, 362);
			this.Admin_button2.TabIndex = 4;
			this.Admin_button2.Text = "Dr Hitler";
			this.Admin_button2.UseVisualStyleBackColor = true;
            this.Admin_button2.Click += new System.EventHandler(this.abutton2_Click);
            // 
            // button3
            // 
            this.Admin_button3.Location = new System.Drawing.Point(451, 3);
			this.Admin_button3.Name = "Admin_button3";
			this.Admin_button3.Size = new System.Drawing.Size(218, 362);
			this.Admin_button3.TabIndex = 5;
			this.Admin_button3.Text = "Dr Sunny";
			this.Admin_button3.UseVisualStyleBackColor = true;
            this.Admin_button3.Click += new System.EventHandler(this.abutton3_Click);
            // 
            // button4
            // 
            this.Admin_button4.Location = new System.Drawing.Point(675, 3);
			this.Admin_button4.Name = "Admin_button4";
			this.Admin_button4.Size = new System.Drawing.Size(218, 362);
			this.Admin_button4.TabIndex = 6;
			this.Admin_button4.Text = "Dr Bhutto";
			this.Admin_button4.UseVisualStyleBackColor = true;
            this.Admin_button4.Click += new System.EventHandler(this.abutton4_Click);
            // 
            // button5
            // 
            this.Admin_button5.Location = new System.Drawing.Point(899, 3);
			this.Admin_button5.Name = "Admin_button5";
			this.Admin_button5.Size = new System.Drawing.Size(217, 362);
			this.Admin_button5.TabIndex = 7;
			this.Admin_button5.Text = "Dr Babar Awaan";
			this.Admin_button5.UseVisualStyleBackColor = true;
            this.Admin_button5.Click += new System.EventHandler(this.abutton5_Click);


            this.Controls.Add(Admin_button1);
			this.Controls.Add(Admin_button2);
			this.Controls.Add(Admin_button3);
			this.Controls.Add(Admin_button4);
			this.Controls.Add(Admin_button5);
		}

        private void abutton1_Click(Object sender, EventArgs e)
        {
            string title = "Dr. Johnny's patients";
            string msg = "";
            for (int i = 0; i < queue.size; i++)
            {
                if (queue.at(i).key.data.getData().Contains("Oncologist"))
                {
                    msg = msg + (queue.at(i).key.data.getData() + '\n');
                }
            }
            MessageBox.Show(msg, title);
        }
        private void abutton2_Click(Object sender, EventArgs e)
        {
            string title = "Dr. Hitler's patients";
            string msg = "";
            for (int i = 0; i < queue.size; i++)
            {
                if (queue.at(i).key.data.getData().Contains("Cardiovascular"))
                {
                    msg = msg + (queue.at(i).key.data.getData() + '\n');
                }
            }
            MessageBox.Show(msg, title);
        }
        private void abutton3_Click(Object sender, EventArgs e)
        {
            string title = "Dr. Sunny's patients";
            string msg = "";
            for (int i = 0; i < queue.size; i++)
            {
                if (queue.at(i).key.data.getData().Contains("Neurologist"))
                {
                    msg = msg + (queue.at(i).key.data.getData() + '\n');
                }
            }
            MessageBox.Show(msg, title);
        }
        private void abutton4_Click(Object sender, EventArgs e)
        {
            string title = "Dr. Bhutto's patients";
            string msg = "";
            for (int i = 0; i < queue.size; i++)
            {
                if (queue.at(i).key.data.getData().Contains("Dermatoligist"))
                {
                    msg = msg + (queue.at(i).key.data.getData() + '\n');
                }
            }
            MessageBox.Show(msg, title);
        }
        private void abutton5_Click(Object sender, EventArgs e)
        {
            string title = "Dr. Babar's patients";
            string msg = "";
            for (int i = 0; i < queue.size; i++)
            {
                if (queue.at(i).key.data.getData().Contains("Psychiatrist"))
                {
                    msg = msg + (queue.at(i).key.data.getData() + '\n');
                }
            }
            MessageBox.Show(msg, title);
        }
        private void PatientButton_Click(Object sender, EventArgs e) 
		{
			drawPatientForm();
		}
        private void AddPatient_Click(Object sender, EventArgs e)
        {
            if ((Patient_textBox1.Text.Length == 0) || 
                (Patient_comboBox1.Text.Length == 0) ||
                (Patient_comboBox2.Text.Length == 0) || 
                (Patient_comboBox3.Text.Length == 0))
            {
                MessageBox.Show("Form incomplete", "Error occured!");
                return;
            }
            Patient temp = new Patient();
            temp.Dataentry(Patient_textBox1.Text.ToString(),
            Patient_comboBox1.Text.ToString(),
            Patient_comboBox2.Text.ToString(),
            Patient_comboBox3.Text.ToString(), count);
            count++;
            Patient_textBox1.Text = null;
            Patient_comboBox1.Text = null;
            Patient_comboBox2.Text = null;
            Patient_comboBox3.Text = null;
            queue.enqueue(new Node(temp));
        }
        private void AdminButton_Click(Object sender, EventArgs e) 
		{
			drawAdminForm();
		}
	}
}

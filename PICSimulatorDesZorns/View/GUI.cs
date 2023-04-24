using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PICsim.Model;
using PICsim.Controller;
using System.Threading;

namespace PICsim.View
{
    public partial class GUI : Form
    {

        private Label[] a_alMemory = new Label[0x100];
        private Thread a_tRun;
        private InstructionExecuter a_oInstructon;
        private String a_sPath;

        public GUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// aktualisieren der Oberfläche
        /// </summary>
        public void updateGUI()
        {
            //Memorygroup
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    //RAM
                    a_alMemory[i * 16 + j].Invoke(new MethodInvoker(delegate () { a_alMemory[i * 16 + j].Text = a_oInstructon.Memory.Memory[i * 16 + j].ToString("X"); }));
                }
            }
            a_alMemory[0].Invoke(new MethodInvoker(delegate () { a_alMemory[0].Text = "0"; }));

            //Statusgroup
            gui_lWReg.Invoke(new MethodInvoker(delegate () { gui_lWReg.Text = a_oInstructon.Status.WRegister.ToString("X"); }));
            checkedListBox1.Invoke(new MethodInvoker(delegate () { checkedListBox1.SetSelected(a_oInstructon.ProgramMemory.Opcode[a_oInstructon.Status.PC][2], true); }));
            gui_lPC.Invoke(new MethodInvoker(delegate () { gui_lPC.Text = a_oInstructon.Status.PC.ToString("X"); }));

            gui_lStatus0.Invoke(new MethodInvoker(delegate () { gui_lStatus0.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 0); }));
            gui_lStatus1.Invoke(new MethodInvoker(delegate () { gui_lStatus1.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 1); }));
            gui_lStatus2.Invoke(new MethodInvoker(delegate () { gui_lStatus2.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 2); }));
            gui_lStatus3.Invoke(new MethodInvoker(delegate () { gui_lStatus3.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 3); }));
            gui_lStatus4.Invoke(new MethodInvoker(delegate () { gui_lStatus4.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 4); }));
            gui_lStatus5.Invoke(new MethodInvoker(delegate () { gui_lStatus5.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 5); }));
            gui_lStatus6.Invoke(new MethodInvoker(delegate () { gui_lStatus6.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 6); }));
            gui_lStatus7.Invoke(new MethodInvoker(delegate () { gui_lStatus7.Text = setValue0or1(a_oInstructon.Memory.Memory[3], 7); }));

            //Stackgroup
            gui_lStack0.Invoke(new MethodInvoker(delegate () { gui_lStack0.Text = a_oInstructon.Status.getStack(0).ToString("X"); }));
            gui_lStack1.Invoke(new MethodInvoker(delegate () { gui_lStack1.Text = a_oInstructon.Status.getStack(1).ToString("X"); }));
            gui_lStack2.Invoke(new MethodInvoker(delegate () { gui_lStack2.Text = a_oInstructon.Status.getStack(2).ToString("X"); }));
            gui_lStack3.Invoke(new MethodInvoker(delegate () { gui_lStack3.Text = a_oInstructon.Status.getStack(3).ToString("X"); }));
            gui_lStack4.Invoke(new MethodInvoker(delegate () { gui_lStack4.Text = a_oInstructon.Status.getStack(4).ToString("X"); }));
            gui_lStack5.Invoke(new MethodInvoker(delegate () { gui_lStack5.Text = a_oInstructon.Status.getStack(5).ToString("X"); }));
            gui_lStack6.Invoke(new MethodInvoker(delegate () { gui_lStack6.Text = a_oInstructon.Status.getStack(6).ToString("X"); }));
            gui_lStack7.Invoke(new MethodInvoker(delegate () { gui_lStack7.Text = a_oInstructon.Status.getStack(7).ToString("X"); }));

            //IOGroup
            gui_bRA0.Invoke(new MethodInvoker(delegate () { gui_bRA0.Text = setValue0or1(a_oInstructon.Memory.Memory[5], 0); }));
            gui_bRA1.Invoke(new MethodInvoker(delegate () { gui_bRA1.Text = setValue0or1(a_oInstructon.Memory.Memory[5], 1); }));
            gui_bRA2.Invoke(new MethodInvoker(delegate () { gui_bRA2.Text = setValue0or1(a_oInstructon.Memory.Memory[5], 2); }));
            gui_bRA3.Invoke(new MethodInvoker(delegate () { gui_bRA3.Text = setValue0or1(a_oInstructon.Memory.Memory[5], 3); }));
            gui_bRA4.Invoke(new MethodInvoker(delegate () { gui_bRA4.Text = setValue0or1(a_oInstructon.Memory.Memory[5], 4); }));
            gui_bRB0.Invoke(new MethodInvoker(delegate () { gui_bRB0.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 0); }));
            gui_bRB1.Invoke(new MethodInvoker(delegate () { gui_bRB1.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 1); }));
            gui_bRB2.Invoke(new MethodInvoker(delegate () { gui_bRB2.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 2); }));
            gui_bRB3.Invoke(new MethodInvoker(delegate () { gui_bRB3.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 3); }));
            gui_bRB4.Invoke(new MethodInvoker(delegate () { gui_bRB4.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 4); }));
            gui_bRB5.Invoke(new MethodInvoker(delegate () { gui_bRB5.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 5); }));
            gui_bRB6.Invoke(new MethodInvoker(delegate () { gui_bRB6.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 6); }));
            gui_bRB7.Invoke(new MethodInvoker(delegate () { gui_bRB7.Text = setValue0or1(a_oInstructon.Memory.Memory[6], 7); }));

            gui_lRA0.Invoke(new MethodInvoker(delegate () { gui_lRA0.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x85], 0); }));
            gui_lRA1.Invoke(new MethodInvoker(delegate () { gui_lRA1.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x85], 1); }));
            gui_lRA2.Invoke(new MethodInvoker(delegate () { gui_lRA2.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x85], 2); }));
            gui_lRA3.Invoke(new MethodInvoker(delegate () { gui_lRA3.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x85], 3); }));
            gui_lRA4.Invoke(new MethodInvoker(delegate () { gui_lRA4.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x85], 4); }));
            gui_lRB0.Invoke(new MethodInvoker(delegate () { gui_lRB0.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 0); }));
            gui_lRB1.Invoke(new MethodInvoker(delegate () { gui_lRB1.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 1); }));
            gui_lRB2.Invoke(new MethodInvoker(delegate () { gui_lRB2.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 2); }));
            gui_lRB3.Invoke(new MethodInvoker(delegate () { gui_lRB3.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 3); }));
            gui_lRB4.Invoke(new MethodInvoker(delegate () { gui_lRB4.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 4); }));
            gui_lRB5.Invoke(new MethodInvoker(delegate () { gui_lRB5.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 5); }));
            gui_lRB6.Invoke(new MethodInvoker(delegate () { gui_lRB6.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 6); }));
            gui_lRB7.Invoke(new MethodInvoker(delegate () { gui_lRB7.Text = setValueToIOLabel(a_oInstructon.Memory.Memory[0x86], 7); }));

            //Infogroup
            gui_lTime.Invoke(new MethodInvoker(delegate () { gui_lTime.Text = "Laufzeit: " + a_oInstructon.Status.Steps.ToString() + " µs"; }));
        }

        /// <summary>
        /// Oberfläche erstellen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GUI_Load(object sender, EventArgs e)
        {
            int l_iPage = 0;
            for (int i = 0; i < 16; i++)
            {
                if (i == 8)
                {
                    l_iPage = 15;
                }
                Label l_oLabel = new Label();
                l_oLabel.Parent = gui_gbMemory;
                l_oLabel.AutoSize = true;
                l_oLabel.Location = new Point(17 * i + 40, 20);
                l_oLabel.Text = i.ToString("X");

                l_oLabel = new Label();
                l_oLabel.Parent = gui_gbMemory;
                l_oLabel.AutoSize = true;
                l_oLabel.Location = new Point(10, 15 * i + 40 + l_iPage);
                l_oLabel.Text = ((int)(i * 0x10)).ToString("X");

                if (i < 4)
                {
                    l_oLabel = new Label();
                    l_oLabel.Parent = gui_gbMemory;
                    l_oLabel.AutoSize = true;
                    l_oLabel.Location = new Point(10, 15 * i + 40 + l_iPage);
                    l_oLabel.Text = ((int)(i * 0x10)).ToString("X");
                }

                for (int j = 0; j < 16; j++)
                {
                    //RAM
                    a_alMemory[i * 16 + j] = new Label();
                    a_alMemory[i * 16 + j].Parent = gui_gbMemory;
                    a_alMemory[i * 16 + j].AutoSize = true;
                    a_alMemory[i * 16 + j].Location = new Point(17 * j + 40, 15 * i + 40 + l_iPage);
                    a_alMemory[i * 16 + j].Name = "Memory" + (i * 16 + j).ToString();
                }
            }
        }

        /// <summary>
        /// Datei von Öffnendialog einlesen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "LST Dateien (*.LST)|*.LST";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.ToLower().EndsWith("lst"))
                {
                    a_sPath = openFileDialog1.FileName;
                    if (a_oInstructon != null)
                    {
                        a_oInstructon.Run = false;
                    }
                    a_oInstructon = new InstructionExecuter(a_sPath, this);
                    checkedListBox1.Items.Clear();
                    checkedListBox1.Items.AddRange(a_oInstructon.ProgramMemory.CodeList);
                    //Oberfköche aktivieren
                    resetButtons();
                    gui_gbIO.Enabled = true;
                    gui_gbInfo.Enabled = true;
                    gui_gbMemory.Enabled = true;
                    gui_gbStack.Enabled = true;
                    gui_gbStatus.Enabled = true;
                    updateGUI();
                }
                else
                {
                    MessageBox.Show("Kein gültige Datei!");
                    //throw new Exception("Keine gültige Datei");
                }
            }
        }

        /// <summary>
        /// Einzelschrittbutton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gui_bStep_Click(object sender, EventArgs e)
        {
            gui_bStart.Enabled = false;
            a_oInstructon.doInstructionCycle();
            gui_bStart.Enabled = true;
        }

        /// <summary>
        /// Button zum Starten der Simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gui_bStart_Click(object sender, EventArgs e)
        {
            gui_bStart.Enabled = false;
            gui_bStep.Enabled = false;
            gui_bPause.Enabled = true;
            gui_bReset.Enabled = true;
            a_tRun = new Thread(new ThreadStart(a_oInstructon.run));
            a_tRun.Start();
        }

        /// <summary>
        /// Button zum Unterbrechen der Simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gui_bPause_Click(object sender, EventArgs e)
        {
            a_oInstructon.Run = false;
            resetButtons();
        }

        /// <summary>
        /// Buttom zum Resetten der Simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gui_bReset_Click(object sender, EventArgs e)
        {
            powerOnResetToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Breakpoints auswerten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_SelectedIndexChanged(object sender, ItemCheckEventArgs e)
        {
            bool l_bIsDone = false;
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i <= e.Index && i < a_oInstructon.ProgramMemory.Opcode.Length; i++)
                {
                    if (e.Index == a_oInstructon.ProgramMemory.Opcode[i][2])
                    {
                        a_oInstructon.BreakpointList.Add(a_oInstructon.ProgramMemory.Opcode[i][0]);
                        l_bIsDone = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i <= e.Index && i < a_oInstructon.ProgramMemory.Opcode.Length; i++)
                {
                    if (e.Index == a_oInstructon.ProgramMemory.Opcode[i][2])
                    {
                        a_oInstructon.BreakpointList.Remove(a_oInstructon.ProgramMemory.Opcode[i][0]);
                        l_bIsDone = true;
                    }
                }
            }
            if (!l_bIsDone)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        /// <summary>
        /// Ausgang RA in Instruction aktualisieren
        /// </summary>
        private void updateIORA()
        {
            int l_iRA = 0;
            l_iRA = Tools.setBitOnPosition(l_iRA, 0, getValueFromIOControl(gui_bRA0));
            l_iRA = Tools.setBitOnPosition(l_iRA, 1, getValueFromIOControl(gui_bRA1));
            l_iRA = Tools.setBitOnPosition(l_iRA, 2, getValueFromIOControl(gui_bRA2));
            l_iRA = Tools.setBitOnPosition(l_iRA, 3, getValueFromIOControl(gui_bRA3));
            l_iRA = Tools.setBitOnPosition(l_iRA, 4, getValueFromIOControl(gui_bRA4));
            a_oInstructon.IOFromGuiA = l_iRA;
        }

        /// <summary>
        /// Ausgang RB in Instruction aktualisieren
        /// </summary>
        private void updateIORB()
        {
            int l_iRB = 0;
            l_iRB = Tools.setBitOnPosition(l_iRB, 0, getValueFromIOControl(gui_bRB0));
            l_iRB = Tools.setBitOnPosition(l_iRB, 1, getValueFromIOControl(gui_bRB1));
            l_iRB = Tools.setBitOnPosition(l_iRB, 2, getValueFromIOControl(gui_bRB2));
            l_iRB = Tools.setBitOnPosition(l_iRB, 3, getValueFromIOControl(gui_bRB3));
            l_iRB = Tools.setBitOnPosition(l_iRB, 4, getValueFromIOControl(gui_bRB4));
            l_iRB = Tools.setBitOnPosition(l_iRB, 5, getValueFromIOControl(gui_bRB5));
            l_iRB = Tools.setBitOnPosition(l_iRB, 6, getValueFromIOControl(gui_bRB6));
            l_iRB = Tools.setBitOnPosition(l_iRB, 7, getValueFromIOControl(gui_bRB7));
            a_oInstructon.IOFromGuiB = l_iRB;
        }

        /// <summary>
        /// Umwandlung "1" = true / "0" = false oder "I" = true / "O" = false
        /// </summary>
        /// <param name="p_oButton"></param>
        /// <returns></returns>
        private bool getValueFromIOControl(Control p_oControl)
        {
            if (p_oControl.Text.CompareTo("1") == 0 || p_oControl.Text.CompareTo("I") == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Umwandlung true = "1" / false = "0"
        /// </summary>
        /// <param name="p_iValue"></param>
        /// <param name="p_iBit"></param>
        /// <returns></returns>
        private String setValue0or1(int p_iValue, int p_iBit)
        {
            if (Tools.getBitOnPosition(p_iValue, p_iBit))
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        /// <summary>
        /// Umwandlung true = "I" / false = "O"
        /// </summary>
        /// <param name="p_iValue"></param>
        /// <param name="p_iBit"></param>
        /// <returns></returns>
        private String setValueToIOLabel(int p_iValue, int p_iBit)
        {
            if (Tools.getBitOnPosition(p_iValue, p_iBit))
            {
                return "I";
            }
            else
            {
                return "0";
            }
        }

        /// <summary>
        /// Button bei Click aktualisieren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gui_bRA_Click(object sender, EventArgs e)
        {
            responseIOClick((Button)sender);
            updateIORA();
        }

        /// <summary>
        /// Button bei Click aktualisieren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gui_bRB_Click(object sender, EventArgs e)
        {
            responseIOClick((Button)sender);
            updateIORB();
        }

        /// <summary>
        /// schreibt 0 auf Button, wenn 1 war und 1, wenn 0 war
        /// </summary>
        /// <param name="sender"></param>
        private void responseIOClick(Button sender)
        {
            if (sender.Text.CompareTo("0") == 0)
            {
                sender.Text = "1";
            }
            else
            {
                sender.Text = "0";
            }
        }

        /// <summary>
        /// Datei neu einlesen bei Power-on-Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void powerOnResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a_tRun != null)
            {
                a_oInstructon.Run = false;
            }
            a_oInstructon = new InstructionExecuter(a_sPath, this);
            updateGUI();
            resetButtons();
        }

        /// <summary>
        /// laufenden Thread beim Programmende beenden
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            if (a_tRun != null)
            {
                a_tRun.Abort();
            }
        }

        /// <summary>
        /// setzt Buttons zurück
        /// </summary>
        internal void resetButtons()
        {
            gui_bPause.Invoke(new MethodInvoker(delegate () { gui_bPause.Enabled = false; }));
            gui_bStart.Invoke(new MethodInvoker(delegate () { gui_bStart.Enabled = true; }));
            gui_bStep.Invoke(new MethodInvoker(delegate () { gui_bStep.Enabled = true; }));
            gui_bReset.Invoke(new MethodInvoker(delegate () { gui_bReset.Enabled = true; }));
        }

        /// <summary>
        /// Schließt Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
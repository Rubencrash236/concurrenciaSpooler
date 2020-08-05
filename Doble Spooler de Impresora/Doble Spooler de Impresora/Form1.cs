using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doble_Spooler_de_Impresora
{
    public partial class Form1 : Form
    {
        private int typeA, typeB, num;
        static int[] queueSize = { 0, 0, 0 };
        static Queue<Work> works = new Queue<Work>();
        static Printer[] printers;
        public Button[] btn;

        Thread printing;  
        Thread worker;
        public Form1()
        {
            
            InitializeComponent();
            PanelPrincipal.Visible = false;
            PanelTipoA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            PanelTipoB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTipos_Click(object sender, EventArgs e)
        {
            if(txtTipoA.Text.Length > 0 && txtTipoB.Text.Length > 0)
            {
                typeA = Int32.Parse(txtTipoA.Text);
                typeB = Int32.Parse(txtTipoB.Text);
                PanelCantidad.Visible = false;
                PanelPrincipal.Visible = true;
                printers = new Printer[typeA + typeB];
                btn = new Button[typeA + typeB];
                int n = 0,left = -85;
                for (int i = 0; i < typeA; i++)
                {
                    printers[i] = new Printer(i, 1);
                    
                    btn[i] = new Button();
                   
                    n = i + 1;
                    left += 85;
                    btn[i].Text = "Impresora " + n;
                    btn[i].Width = 75;
                    btn[i].Height = 60;
                    btn[i].Left = left;
                    btn[i].BackColor = Color.Azure;
                    
                    PanelTipoA.Controls.Add(btn[i]);
                    
                }
                n = 0;
                left = -85;
                for (int i = typeA; i < printers.Length; i++)
                {
           
                    printers[i] = new Printer(i, 2);
                   
                    btn[i] = new Button();

                    n++;
                    left += 85;
                    btn[i].Text = "Impresora " + n;
                    btn[i].Width = 75;
                    btn[i].Height = 60;
                    btn[i].Left = left;
                    btn[i].BackColor = Color.Azure;


                    PanelTipoB.Controls.Add(btn[i]);
                }
            }
        }

        private void txtTipoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                
                e.Handled = true;
            }
        }

        private void PanelTipoA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTipoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                
                e.Handled = true;
            }
        }

         void searchPrinter(Work myWork)
        {
            int num1 = 0;
            while (true)
            {
                
                foreach (Printer printer in printers)
                {
                    if (myWork != null && printer.ready && (printer.type == myWork.type || myWork.type == 3))
                    {
                        num1 = printer.id;
                        printer.myWork = myWork;
                        myWork = null;
                        printer.printing = true;
                        btn[printer.id].Invoke(new MethodInvoker(delegate { btn[printer.id].BackColor = Color.Red; }));
                        printer.startPrint();
                        
                        String details;
                        details = "Impresora tipo: " + printer.type.ToString() + " Mensaje: " + printer.myWork.work;
                        //Console.WriteLine(details);
                        
                        LSImpresos.Invoke(new MethodInvoker(delegate { LSImpresos.Items.Add(details); }));
                        //Thread.Sleep(1000);
                        btn[printer.id].Invoke(new MethodInvoker(delegate { btn[printer.id].BackColor = Color.Azure; }));
                        break;
                    }
                  

                    
                }
                 
            }
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CBXTipotrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXTipotrabajo.SelectedIndex = 0;
        }

         void addWork(Work myWork)
        {
            works.Enqueue(myWork);
        }

        private void BTNImprimir_Click(object sender, EventArgs e)
        {
           
            if(txtmensaje.Text.Length > 2 && CBXTipotrabajo.SelectedIndex > 0)
            {
                try
                {
                    worker = new Thread(workGenerator);
                    printing = new Thread(startPrint);
                    worker.Start();
                    printing.Start();

                }
                catch (BigQueueException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                  

            }
        }

        private void txtmensaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBXTipotrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = CBXTipotrabajo.SelectedIndex;
            //Console.WriteLine(num);
        }

        private void LSImpresos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void workGenerator()
        {
            Work work = new Work(4, null);
            work = new Work(4, null);
            work.type = num;
            work.work = txtmensaje.Text;
            //addWork(work);
           
            if (work.type != 4)
            {
                ///EXCEPCION
                if(queueSize[work.type] < 20)
                {
                    works.Enqueue(work);
                    queueSize[num]++;
                    work = null;

                }
                else
                {
                    throw new BigQueueException("La cola de tipo " + work.type + "ha llegado a 20");
                }
                
            }
        }

        public void startPrint()
        {
            Work myWork;
            while (true)
            {
                if (works.Count > 0 )
                {
                    myWork = works.Dequeue();
                    searchPrinter(myWork);
                    queueSize[myWork.type]--;
                    
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

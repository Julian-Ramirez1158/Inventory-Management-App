using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Task1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        // Quesitons for Dr. Brewer

        // Verify that everything is okay up to this point
        // What is the difference between Show and ShowDialog
        // What is the difference between Hide() and Close()
        // search for a part or product and display matching result
        // How do I integrate the Inhouse vs Outsourced radio button functions into the add parts form
        // How do I populate the modify forms with the selected product or part
        // Is the parts datagrid populated correctly on the modify and add products form
        // Which data is supposed to go in the second datagrid on the modify and add parts form

    }
}

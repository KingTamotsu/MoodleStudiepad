using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoodleStudiepad.BU;
using MoodleStudiepad.CC;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.Forms.MdiChildren
{
    public partial class PrestationIndicatorOverview : Form
    {
        SeePrestationIndicators seePrestationIndicators = new SeePrestationIndicators();
        List<PrestationIndicator> temp = new List<PrestationIndicator>();

        public PrestationIndicatorOverview()
        {
            InitializeComponent();
            createListview();
            fillListview();
        }

        public void createListview()
        {
            // Set the view to show details.
            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;

            listView1.Columns.Add("courseId");
            listView1.Columns.Add("piCode");
            listView1.Columns.Add("grade");
        }
        public void fillListview()
        {
            temp = seePrestationIndicators.getPrestationIndicators(2);
            foreach (PrestationIndicator item in temp)
            {
                listView1.Items.Add(new ListViewItem(new string[] { item.courseId.ToString(), item.piCode.ToString(), item.grade.ToString()}));
            }
        }
    }
}

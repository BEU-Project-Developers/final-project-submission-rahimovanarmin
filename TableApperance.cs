using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskSchudler
{
    internal class TableApperance
    {
        public static void ApplyCellFormatting(DataGridView gridView, DataGridViewCellFormattingEventArgs e)
        {
            gridView.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            // Check if the column name is "Importance"
            if (gridView.Columns[e.ColumnIndex].Name == "Importance" && e.RowIndex >= 0)
            {
                var importanceValue = gridView.Rows[e.RowIndex].Cells["Importance"].Value;

                if (importanceValue != null)
                {
                    string importance = importanceValue.ToString();

                    // Set the row color based on the Importance level
                    if (importance == "Low")
                    {
                        gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#dcdcdc"); // Grey
                    }
                    else if (importance == "Medium")
                    {
                        gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CA9C47"); // Gold-like
                    }
                    else if (importance == "High")
                    {
                        gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#CB4752"); // Red
                    }
                    else
                    {
                        gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Default
                    }
                }
                else
                {
                    // Neutral color for null importance
                    gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                }
            }
        }
    
}
}

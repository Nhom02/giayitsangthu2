using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QL_giayit
{
    public class Report
    {

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public void ExportToExcel_ban(DataGridView danhsachbanhang, TextBox tongsoluong, TextBox tongtien, ComboBox thang, ComboBox nam)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet1 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            Excel.Worksheet xlWorkSheet2 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            Excel.Worksheet xlWorkSheet3 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            xlWorkSheet1 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet1.Name = "Thống kê bán hàng";
            xlWorkSheet1.Cells[1, 1] = "GiayIT Shop";
            xlWorkSheet1.get_Range("A1", "D1").Merge(true);
            xlWorkSheet1.get_Range("A1", "D1").Font.Bold = true;
            xlWorkSheet1.get_Range("A1", "D1").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A1", "D1").Font.Color = 100;

            xlWorkSheet1.Cells[2, 1] = "Địa chỉ: 273 An Dương Vương, Quận 5, Tp. Hồ Chí Minh";
            xlWorkSheet1.get_Range("A2", "D2").Merge(true);
            xlWorkSheet1.get_Range("A2", "D2").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A2", "D2").Font.Color = 100;

            xlWorkSheet1.Cells[3, 1] = "Số điện thoại: (84)166.757.3377";
            xlWorkSheet1.get_Range("A3", "D3").Merge(true);
            xlWorkSheet1.get_Range("A3", "D3").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A3", "D3").Font.Color = 100;

            xlWorkSheet1.Cells[5, 4] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            xlWorkSheet1.get_Range("D5", "F5").Merge(true);
            xlWorkSheet1.get_Range("D5", "F5").HorizontalAlignment = Excel.XlVAlign.xlVAlignJustify;
            xlWorkSheet1.get_Range("D5", "F5").Font.Italic = true;


            xlWorkSheet1.Cells[6, 1] = "THỐNG KÊ BÁN HÀNG";
            xlWorkSheet1.get_Range("A6", "F6").Merge(true);
            xlWorkSheet1.get_Range("A6", "F6").Font.Size = 13;
            xlWorkSheet1.get_Range("A6", "F6").Font.Bold = true;
            xlWorkSheet1.get_Range("A6", "F6").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A6", "F6").Font.Color = 480145006;

            /*if ("".Equals(thang.Text) || !IsNumber(thang.Text))
                xlWorkSheet1.Cells[7, 1] = "Năm " + nam.Text;
            else
                xlWorkSheet1.Cells[7, 1] = "Tháng " + thang.Text + " năm " + nam.Text;
            xlWorkSheet1.get_Range("A7", "F7").Merge(true);
            xlWorkSheet1.get_Range("A7", "F7").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;*/

            xlWorkSheet1.Cells[9, 2] = "Tổng số lượng bán: " + tongsoluong.Text;
            xlWorkSheet1.get_Range("B9", "E9").Merge(true);

            xlWorkSheet1.Cells[10, 2] = "Tổng tiền: " + tongtien.Text;
            xlWorkSheet1.get_Range("B10", "E10").Merge(true);
            int i = 0;
            int j = 0;
            xlWorkSheet1.Cells[12, 2] = "STT";
            xlWorkSheet1.Cells[12, 3] = "Ngày";
            xlWorkSheet1.Cells[12, 4] = "Số lượng bán";
            xlWorkSheet1.Cells[12, 5] = "Tổng tiền";
            xlWorkSheet1.get_Range("B12", "E12").Font.Bold = true;
            int x = danhsachbanhang.Rows.Count + 12;
            for (i = 0; i <= danhsachbanhang.RowCount - 1; i++)
            {
                for (j = 0; j <= danhsachbanhang.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = danhsachbanhang[j, i];
                    xlWorkSheet1.Cells[i + 13, j + 2] = cell.Value;
                    if (danhsachbanhang.Rows[i].Cells[0].Value == null)
                        break;
                }
            }

            xlWorkSheet1.get_Range("B12", "E" + x).Borders.Color = 0;
            string a = DateTime.Now.ToString("ddmmyyhhmmss");
            xlWorkBook.SaveAs("D:\\Thongkebanhang" + a + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet1);
            releaseObject(xlWorkSheet2);
            releaseObject(xlWorkSheet3);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Tập tin được lưu tại địa chỉ E:\\Thongkebanhang" + a + ".xls");
        }

        public void ExportToExcel_nhap(DataGridView danhsachmuahang, TextBox tongsoluong, TextBox tongtien, ComboBox thang, ComboBox nam)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet1 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            Excel.Worksheet xlWorkSheet2 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            Excel.Worksheet xlWorkSheet3 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            xlWorkSheet1 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet1.Name = "Thống kê mua hàng";
            xlWorkSheet1.Cells[1, 1] = "GiayIT Shop";
            xlWorkSheet1.get_Range("A1", "D1").Merge(true);
            xlWorkSheet1.get_Range("A1", "D1").Font.Bold = true;
            xlWorkSheet1.get_Range("A1", "D1").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A1", "D1").Font.Color = 100;

            xlWorkSheet1.Cells[2, 1] = "Địa chỉ: 273 An Dương Vương, Quận 5, Tp. Hồ Chí Minh";
            xlWorkSheet1.get_Range("A2", "D2").Merge(true);
            xlWorkSheet1.get_Range("A2", "D2").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A2", "D2").Font.Color = 100;

            xlWorkSheet1.Cells[3, 1] = "Số điện thoại: (84)166.757.3377";
            xlWorkSheet1.get_Range("A3", "D3").Merge(true);
            xlWorkSheet1.get_Range("A3", "D3").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A3", "D3").Font.Color = 100;

            xlWorkSheet1.Cells[5, 4] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            xlWorkSheet1.get_Range("D5", "F5").Merge(true);
            xlWorkSheet1.get_Range("D5", "F5").HorizontalAlignment = Excel.XlVAlign.xlVAlignJustify;
            xlWorkSheet1.get_Range("D5", "F5").Font.Italic = true;


            xlWorkSheet1.Cells[6, 1] = "THỐNG KÊ NHẬP HÀNG";
            xlWorkSheet1.get_Range("A6", "F6").Merge(true);
            xlWorkSheet1.get_Range("A6", "F6").Font.Size = 13;
            xlWorkSheet1.get_Range("A6", "F6").Font.Bold = true;
            xlWorkSheet1.get_Range("A6", "F6").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A6", "F6").Font.Color = 480145006;

            /*if("".Equals(thang.Text) || !IsNumber(thang.Text))
                xlWorkSheet1.Cells[7, 1] = "Năm " + nam.Text;
            else
                xlWorkSheet1.Cells[7, 1] = "Tháng " + thang.Text + " năm " + nam.Text;
            xlWorkSheet1.get_Range("A7", "F7").Merge(true);
            xlWorkSheet1.get_Range("A7", "F7").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;*/

            xlWorkSheet1.Cells[9, 2] = "Tổng số lượng nhập: " + tongsoluong.Text;
            xlWorkSheet1.get_Range("B9", "E9").Merge(true);

            xlWorkSheet1.Cells[10, 2] = "Tổng tiền: " + tongtien.Text;
            xlWorkSheet1.get_Range("B10", "E10").Merge(true);
            int i = 0;
            int j = 0;
            xlWorkSheet1.Cells[12, 2] = "STT";
            xlWorkSheet1.Cells[12, 3] = "Ngày";
            xlWorkSheet1.Cells[12, 4] = "Số lượng nhập";
            xlWorkSheet1.Cells[12, 5] = "Tổng tiền";
            xlWorkSheet1.get_Range("B12", "E12").Font.Bold = true;
            int x = danhsachmuahang.Rows.Count + 12;
            for (i = 0; i <= danhsachmuahang.RowCount - 1; i++)
            {
                for (j = 0; j <= danhsachmuahang.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = danhsachmuahang[j, i];
                    xlWorkSheet1.Cells[i + 13, j + 2] = cell.Value;
                    if (danhsachmuahang.Rows[i].Cells[0].Value == null)
                        break;
                }
            }

            xlWorkSheet1.get_Range("B12", "E" + x).Borders.Color = 0;

            string a = DateTime.Now.ToString("ddmmyyhhmmss");
            xlWorkBook.SaveAs("D:\\Thongkenhaphang" + a + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet1);
            releaseObject(xlWorkSheet2);
            releaseObject(xlWorkSheet3);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Tập tin được lưu tại địa chỉ D:\\Thongkenhaphang" + a + ".xls");
        }

        public void ExportToExcel_dssp(DataGridView danhsachtonkho, Label tongsoluongtonkho)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet1 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            Excel.Worksheet xlWorkSheet2 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            Excel.Worksheet xlWorkSheet3 = xlWorkBook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing)
                        as Excel.Worksheet;
            xlWorkSheet1 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet1.Name = "Thống kê tồn kho";
            xlWorkSheet1.Cells[1, 1] = "GiayIT Shop";
            xlWorkSheet1.get_Range("A1", "D1").Merge(true);
            xlWorkSheet1.get_Range("A1", "D1").Font.Bold = true;
            xlWorkSheet1.get_Range("A1", "D1").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A1", "D1").Font.Color = 100;

            xlWorkSheet1.Cells[2, 1] = "Địa chỉ: 273 An Dương Vương, Quận 5, Tp. Hồ Chí Minh";
            xlWorkSheet1.get_Range("A2", "D2").Merge(true);
            xlWorkSheet1.get_Range("A2", "D2").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A2", "D2").Font.Color = 100;

            xlWorkSheet1.Cells[3, 1] = "Số điện thoại: (84)166.757.3377";
            xlWorkSheet1.get_Range("A3", "D3").Merge(true);
            xlWorkSheet1.get_Range("A3", "D3").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A3", "D3").Font.Color = 100;

            xlWorkSheet1.Cells[5, 4] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            xlWorkSheet1.get_Range("D5", "F5").Merge(true);
            xlWorkSheet1.get_Range("D5", "F5").HorizontalAlignment = Excel.XlVAlign.xlVAlignJustify;
            xlWorkSheet1.get_Range("D5", "F5").Font.Italic = true;


            xlWorkSheet1.Cells[6, 1] = "THỐNG KÊ TỒN KHO THEO DANH SÁCH SẢN PHẨM";
            xlWorkSheet1.get_Range("A6", "F6").Merge(true);
            xlWorkSheet1.get_Range("A6", "F6").Font.Size = 13;
            xlWorkSheet1.get_Range("A6", "F6").Font.Bold = true;
            xlWorkSheet1.get_Range("A6", "F6").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet1.get_Range("A6", "F6").Font.Color = 480145006;

            /*if ("".Equals(thang.Text) || !IsNumber(thang.Text))
                xlWorkSheet1.Cells[7, 1] = "Năm " + nam.Text;
            else
                xlWorkSheet1.Cells[7, 1] = "Tháng " + thang.Text + " năm " + nam.Text;
            xlWorkSheet1.get_Range("A7", "F7").Merge(true);
            xlWorkSheet1.get_Range("A7", "F7").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;*/

            xlWorkSheet1.Cells[9, 2] = "Tổng số lượng tồn kho: " + tongsoluongtonkho.Text;
            xlWorkSheet1.get_Range("B9", "E9").Merge(true);

            int i = 0;
            int j = 0;
            xlWorkSheet1.Cells[12, 2] = "Ngày nhập kho";
            xlWorkSheet1.Cells[12, 3] = "Mã sản phẩm";
            xlWorkSheet1.Cells[12, 4] = "Tên sản phẩm";
            xlWorkSheet1.Cells[12, 5] = "Loại sản phẩm";
            xlWorkSheet1.Cells[12, 6] = "Giá bán (VNĐ)";
            xlWorkSheet1.Cells[12, 7] = "Số lượng";
            xlWorkSheet1.get_Range("B12", "G12").Font.Bold = true;
            int x = danhsachtonkho.Rows.Count + 12;
            for (i = 0; i <= danhsachtonkho.RowCount - 1; i++)
            {
                for (j = 0; j <= danhsachtonkho.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = danhsachtonkho[j, i];
                    xlWorkSheet1.Cells[i + 13, j + 2] = cell.Value;
                    if (danhsachtonkho.Rows[i].Cells[0].Value == null)
                        break;
                }
            }

            xlWorkSheet1.get_Range("B12", "G" + x).Borders.Color = 0;

            string a = DateTime.Now.ToString("ddmmyyhhmmss");
            xlWorkBook.SaveAs("D:\\Thongketonkho" + a + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            releaseObject(xlWorkSheet1);
            releaseObject(xlWorkSheet2);
            releaseObject(xlWorkSheet3);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Tập tin được lưu tại địa chỉ E:\\Thongketonkho" + a + ".xls");
        }
    }
}

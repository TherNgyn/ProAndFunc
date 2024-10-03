using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProAndFunc
{
    public partial class Form1 : Form
    {
        String strCon = @"Data Source=DESKTOP-0PJCAJ8\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HienThiThongTin(string isbn)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand sqlCom = new SqlCommand();
                // Gọi thủ tục: pro_lietKe
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "pro_lietKe";
                sqlCom.Connection = sqlCon;
                // đưa giá trị của isbn vào tham số tên @isbn
                sqlCom.Parameters.AddWithValue("@isbn", isbn);
                // Thực thi câu lệnh gọi thủ tục và trả về kết quả
                SqlDataReader sqlRe = sqlCom.ExecuteReader();
                // Xóa dữ liệu cũ trong listView1
                listView1.Items.Clear();
                // Đọc dữ liệu từ sqlRe và hiển thị lên listView1
                if (!sqlRe.HasRows)
                {
                    MessageBox.Show("Không tìm thấy sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (sqlRe.Read())
                {
                    // sqlRe["ma_tuasach"] là cột ma_tuasach trong kết quả trả về
                    // ToString () chuyển giá trị của cột ma_tuasach sang kiểu chuỗi
                    ListViewItem item = new ListViewItem(sqlRe["ma_tuasach"].ToString());
                    // SubItems.Add thêm các cột còn lại vào item
                    item.SubItems.Add(sqlRe["ngonngu"].ToString());
                    item.SubItems.Add(sqlRe["bia"].ToString());
                    item.SubItems.Add(sqlRe["trangthai"].ToString());
                    item.SubItems.Add(sqlRe["tuasach"].ToString());
                    item.SubItems.Add(sqlRe["tacgia"].ToString());
                    item.SubItems.Add(sqlRe["tomtat"].ToString());
                    item.SubItems.Add(sqlRe["SLSachChuaMuon"].ToString());
                    // Thêm item vào listView1
                    listView1.Items.Add(item);
                }
                sqlRe.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của ISBN từ textBox1
            string isbn = textBox1.Text;
            if (!string.IsNullOrEmpty(isbn))
            {
                // Gọi hàm HienThiThongTin với tham số là isbn
                HienThiThongTin(isbn);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ISBN hợp lệ.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tuasach = textBox2.Text;
            if (!string.IsNullOrEmpty(tuasach))
            {
                DemSoCuonSach(tuasach);
            }
            
            else
            {
                MessageBox.Show("Vui lòng nhập tựa sách hợp lệ.");
            }
        }

        private void DemSoCuonSach(string tuasach)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT * FROM dbo.TongSoCuonSach(@tuasach)";
                sqlComm.Connection = sqlCon;
                sqlComm.Parameters.AddWithValue("@tuasach", tuasach);
                
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlComm);

                    // Tạo đối tượng DataTable để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();

                    // Điền dữ liệu vào DataTable
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tựa sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dataGridView1.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
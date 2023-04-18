using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbhandling
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 1. 연결 문자열 생성
            string connectionString = "Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=1234";
            
            // 2. DB 연결을 위한 Connection 객체 생성
            SqlConnection conn = new SqlConnection(connectionString);
            conn.ConnectionString = connectionString;

            // 3. 객체 통해 DB 연결
            conn.Open();

            // 4. DB 처리를 위한 쿼리 작성
            // 5. SqlDataAdapter 생성
            string selQuery = @"SELECT CustomerID
                                  , CompanyName
                                  , ContactName
                                  , ContactTitle
                                  , Address
                                  , City
                                  , Region
                                  , PostalCode
                                  , Country
                                  , Phone
                                  , Fax
                              FROM Customers";
            // SqlCommand selcmd = new SqlCommand(selQuery, conn);
            // selCmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(selQuery, conn);

            
            // 5. 리더객체 생성, 값 넘겨줌
            //SqlDataReader reader = selcmd.ExecuteReader();

            // 6. 데이터리더에 있는 데이터를 데이터셋으로 보내기
            DataSet ds = new DataSet(); // 테이블 여러 개 담을 수 있음
            adapter.Fill(ds);

            // 7. 데이터그리드뷰에 바인딩하기 위한 BindingSource 생성
            BindingSource source = new BindingSource();

            // 7. 데이터그리드뷰의 DataSource에 데이터셋 할당
            source.DataSource = ds.Tables[0];
            DgvNorthwind.DataSource = source;

            // 8. DB 닫기
            conn.Close();
        }
    }
}

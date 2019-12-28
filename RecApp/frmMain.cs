using RecDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RecApp
{
    public partial class frmMain : Form
    {
        // Создать главный объект, который включает в себя все нужные объекты
        public MathLib ml = new MathLib();
        // Создать объект для формирования отчета
        public frmReport frmRpt;

        public frmMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ProgramExit();         
        }


        private void ProgramExit()
        {
            string path = Application.UserAppDataPath.ToString();

            // Сохранить данные объекта на диск для последующего вызова
            ml.SaveData(ml, path + @"\\default.xml");

            #region -- сохранить параметры отчета в файле: исходные данные в отчет
            //XmlSerializer xmls = new XmlSerializer(typeof(List<NumberSum.Param>));
            //FileStream fs = null;
            //try
            //{
            //    fs = new FileStream("cfgInputToRep.xml", FileMode.Create);
            //    xmls.Serialize(fs, _allParamsInput);
            //}
            //catch
            //{
            //}
            //finally
            //{
            //    if (fs != null) fs.Close();
            //}
            #endregion

            #region -- сохранить параметры отчета в файле: результаты в отчет
            //XmlSerializer xmlsOut = new XmlSerializer(typeof(List<NumberSum.Param>));
            //FileStream fsOut = null;
            //try
            //{
            //    fsOut = new FileStream("cfgOutputToRep.xml", FileMode.Create);
            //    xmlsOut.Serialize(fsOut, _allParamsOutput);
            //}
            //catch
            //{
            //}
            //finally
            //{
            //    if (fsOut != null) fsOut.Close();
            //}
            #endregion

            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\default.xml");

            if (fileDefaultUserAppDataPath.Exists)  // если файл найден, то десериализовать его
            {
                MathLib mll = new MathLib();
                this.ml = mll.LoadData(fileDefaultUserAppDataPath.ToString());
            }
            else  // если файла нет, то сформировать его и сериализовать в указанный каталог для последующего вызова
            {
                #region -- Загрузка первоначальных значений
                ml.Fbl = 0.161;
                ml.Fv = 0.013;
                ml.Fd = 0.0274;
                ml.decvi = 0.0565;
                ml.decvidi = 0.158;
                ml.Q = 6700;
                ml.tv1 = 20;
                ml.tv2 = 500;
                ml.B = 9.335;
                ml.α = 1.05;
                ml.Lα = 1.54;
                ml.Vα = 2.37;
                ml.Vl = 3;
                ml.td1 = 1070;
                ml.j = 0.1;
                ml.deltat = 1;
                ml.K = 1716;
                ml.Сv1 = 1.29;
                ml.Сv2 = 1.34;
                ml.η = 0.9;
                ml. td2 = 765;
                ml.εΔt = 0.98;
                ml.Z1 = 24;
                ml.Z2 = 20;
                ml.Z3 = 30;
                ml.nд = 2;
                ml.nв = 1;
                ml.Wо_ддоп = 4;
                ml.Wо_вдоп = 2;
                ml.a = 4.617;
                ml.b = 0.00415;
                ml.α1dl = 23;
                ml.Кт = 0.91;
                ml.с = 0.9;
                ml.d = 0.00048;
                ml.S = 0.02;
                ml.tст = 589;
                ml.B1 = 0.0001;
                ml.Kтп = 0.9 + 2.3;
                ml.e = 0.75;
                ml.g = 1000;






                #endregion -- Загрузка первоначальных значений

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                ml.SaveData(ml, fileDefaultUserAppDataPath.ToString());
            }

            // Настроить элементы формы
            FormOptionDefault();

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 625);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(0, 3060.8);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
        }


        /// <summary>
        /// Первоначальная настройка элементов управления формы
        /// </summary>  
        private void FormOptionDefault()
        {
            // Показать в заголовке главного окна номер текущей версии и пользвателя
            this.Text = this.Text + " [версия " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]";

            // Установить редактируемый объект в PropertyGrid
            propertyGrid.SelectedObject = new DataInput(ml);

            #region -- Заполнить перечень показателей в отчет: исходные данные
            //if (File.Exists("cfgInputToRep.xml"))
            //{
            //    XmlSerializer xmls = new XmlSerializer(typeof(List<NumberSum.Param>));
            //    FileStream fs = null;
            //    try
            //    {
            //        fs = new FileStream("cfgInputToRep.xml", FileMode.Open);
            //        _allParamsInput = (List<NumberSum.Param>)xmls.Deserialize(fs);
            //    }
            //    catch
            //    {
            //    }
            //    finally
            //    {
            //        if (fs != null) fs.Close();
            //    }
            //}
            //else
            //{
            //    PropertyInfo[] pArr = propertyGrid.SelectedObject.GetType().GetProperties();
            //    if (pArr != null)
            //        foreach (PropertyInfo p in pArr)
            //        {
            //            string descr = "";
            //            object[] attr = p.GetCustomAttributes(false);
            //            if (attr != null)
            //                foreach (object a in attr)
            //                {
            //                    if (a is DisplayNameAttribute) descr += (a as DisplayNameAttribute).DisplayName;
            //                    if (a is CategoryAttribute) descr = descr.Insert(0, (a as CategoryAttribute).Category + ". ");
            //                }
            //            NumberSum.Param par = new NumberSum.Param(0);
            //            par.Description = descr;
            //            par.IsReport = false;
            //            par.PropertyName = p.Name;
            //            _allParamsInput.Add(par);
            //        }
            //}
            #endregion

            #region -- Заполнить перечень показателей в отчет: результаты расчета
            //if (File.Exists("cfgOutputToRep.xml"))
            //{
            //    XmlSerializer xmls = new XmlSerializer(typeof(List<NumberSum.Param>));
            //    FileStream fsOut = null;
            //    try
            //    {
            //        fsOut = new FileStream("cfgOutputToRep.xml", FileMode.Open);
            //        _allParamsOutput = (List<NumberSum.Param>)xmls.Deserialize(fsOut);
            //    }
            //    catch
            //    {
            //    }
            //    finally
            //    {
            //        if (fsOut != null) fsOut.Close();
            //    }
            //}
            //else
            //{
            //    DataOutput _dataOut = new DataOutput(s);
            //    PropertyInfo[] pArrOut = _dataOut.GetType().GetProperties();
            //    if (pArrOut != null)
            //        foreach (PropertyInfo p in pArrOut)
            //        {
            //            string descrOut = "";
            //            object[] attrOut = p.GetCustomAttributes(false);
            //            if (attrOut != null)
            //                foreach (object a in attrOut)
            //                {
            //                    if (a is DisplayNameAttribute) descrOut += (a as DisplayNameAttribute).DisplayName;
            //                    if (a is CategoryAttribute) descrOut = descrOut.Insert(0, (a as CategoryAttribute).Category + ", ");
            //                }
            //            NumberSum.Param parOut = new NumberSum.Param(0);
            //            parOut.Description = descrOut;
            //            parOut.IsReport = false;
            //            parOut.PropertyName = p.Name;
            //            _allParamsOutput.Add(parOut);
            //        }
            //}
            #endregion
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdecvi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdecvidi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtta2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lbltv1_Click(object sender, EventArgs e)
        {

        }

        private void lbla_Click(object sender, EventArgs e)
        {

        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvRachetdan.Rows.Clear();

            //dgvRachetdan.Rows.Add("dbdddfdfVв'", "м3/с", Math.Round(ml.tv1, 0), "количество воздуха,поступающее в рекуператор");


            dgvRachetdan.Rows.Add("Vв'", "м3/с", Math.Round(ml.get_Vв1(), 4), "количество воздуха,поступающее в рекуператор");
            dgvRachetdan.Rows.Add("Vв.пр", "м3/с", Math.Round(ml.get_Vv_pr(), 5), "количество воздуха,просасываемое через неплотности на сторону дыма в рекуп.");
            dgvRachetdan.Rows.Add("Vд'", "м3/с", Math.Round(ml.get_Vд1(), 4), "количество дыма,поступающее в рекуператор");
            dgvRachetdan.Rows.Add("iд'", "кДж/м3", Math.Round(ml.get_iд1()), "теплосодержание дыма до рекуператора");
            dgvRachetdan.Rows.Add("iв'", "кДж/м3", Math.Round(ml.get_iв1(), 1), "теплосодержание воздуха до рекуператора");
            dgvRachetdan.Rows.Add("iв''", "кДж/м3", Math.Round(ml.get_iв2()), "теплосодержание воздуха после рекуператора");
            dgvRachetdan.Rows.Add("iд''", "кДж/м3", Math.Round(ml.get_iд2(), 2), "теплосодержание дыма после рекуператора");
            dgvRachetdan.Rows.Add("Δt'", "°C", Math.Round(ml.get_Δt1(), 3), "предварительное значение средней логарифмической разности температур");
            dgvRachetdan.Rows.Add("P", "", Math.Round(ml.get_P(), 5), "вспомогательная величина");
            dgvRachetdan.Rows.Add("R", "", Math.Round(ml.get_R(), 5), "вспомогательная величина");
            dgvRachetdan.Rows.Add("Δt", "°C", Math.Round(ml.get_Δt(), 3), "действительная средняя логарифмическая разность температур в рекуператоре");
            dgvRachetdan.Rows.Add("Z", "шт", Math.Round(ml.get_Z()), "общее число блоков");
            dgvRachetdan.Rows.Add("Wод", "м/с", Math.Round(ml.get_Wод(), 5), "скорость дыма в рекуператоре");
            dgvRachetdan.Rows.Add("Wов", "м/с", Math.Round(ml.get_Wов(), 5), "скорость воздуха в рекуператоре");
            dgvRachetdan.Rows.Add("tд", "°C", Math.Round(ml.get_tд(), 4), "средняя температура дыма в рекуператоре");
            dgvRachetdan.Rows.Add("αд.к", "Вт/м2град", Math.Round(ml.get_αд_к(), 4), "коэффициент конвективного теплообмена между дымом и стенкой рекуператора");
            dgvRachetdan.Rows.Add("αд.л", "Вт/м2град", Math.Round(ml.get_αд_л(), 2), "значение коэффициента лучистого теплообмена");
            dgvRachetdan.Rows.Add("αд", "Вт/м2град", Math.Round(ml.get_αд(), 4), "коэффициент теплообмена на стороне дыма");
            dgvRachetdan.Rows.Add("tв", "°C", Math.Round(ml.get_tв()), "средняя температура воздуха");
            dgvRachetdan.Rows.Add("tст", "°C", Math.Round(ml.get_tst(), 2), "средняя температура стенки");
            dgvRachetdan.Rows.Add("tв'", "°C", Math.Round(ml.get_tV1(), 3), "средняя температура воздуха в пограничном слое");
            dgvRachetdan.Rows.Add("Δt", "°C", Math.Round(ml.get_ΔT(), 2), "температурный напор");
            dgvRachetdan.Rows.Add("αв", "Вт/м2град", Math.Round(ml.get_αв(), 5), "коэффициент теплоотдачи от стенки к воздуху");
            dgvRachetdan.Rows.Add("lш", "Вт/м2град", Math.Round(ml.get_lш(), 5), "коэффициент теплопроводности материала стенки");
            dgvRachetdan.Rows.Add("K", "Вт/м2град", Math.Round(ml.get_k(), 5), "коэффициент теплопередачи в рекуператоре");
            dgvRachetdan.Rows.Add("Qв", "Вт", Math.Round(ml.get_Qв()), "количество теплоты,передаваемое воздуху в рекуператоре");
            dgvRachetdan.Rows.Add("F", "м2", Math.Round(ml.get_F(), 2), "поверхность нагрева");
            dgvRachetdan.Rows.Add("F'", "м2", Math.Round(ml.get_F1(), 1), "поверхность рекуператора,принятого при компоновке");
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            PlotSurface2DDemo _p = new PlotSurface2DDemo(ml);
            _p.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CreateReportViewer();
        }

        /// <summary>
        /// Создать отчет ReportViewer
        /// </summary>         
        private void CreateReportViewer()
        {
            frmRpt = new frmReport();

            #region Подготовить данные для вывода в отчет

            // Исходные данные в отчет только те, которые отметил пользователь (IsReport=true)
            List<cReportList> RepListInput = new List<cReportList>();
            RepListInput.Add(new cReportList("Поверхность нагрева, м2", ml.Fbl.ToString()));
            RepListInput.Add(new cReportList("Сечение для прохода воздуха, м2", ml.Fv.ToString()));
            RepListInput.Add(new cReportList("Сечение для прохода дыма, м2", ml.Fd.ToString()));
            RepListInput.Add(new cReportList("Эквивалентный диаметр воздушного канала, м", ml.decvi.ToString()));
            RepListInput.Add(new cReportList("Эквивалентный диаметр дымового канала, м", ml.decvidi.ToString()));
            RepListInput.Add(new cReportList("Теплота сгорания, Дж/м3", ml.Q.ToString()));
            RepListInput.Add(new cReportList("Начальная температура, C", ml.tv1.ToString()));
            RepListInput.Add(new cReportList("Конечная температура, С", ml.tv2.ToString()));
            RepListInput.Add(new cReportList("Расход топлива на печь, м3/с", ml.B.ToString()));
            RepListInput.Add(new cReportList("Характеристика горения топлива", ml.Lα.ToString()));
            RepListInput.Add(new cReportList("Характеристика горения топлива", ml.Vα.ToString()));
            RepListInput.Add(new cReportList("Характеристика горения топлива", ml.Vl.ToString()));
            RepListInput.Add(new cReportList("Температура продуктов горения, уходящих из печи", ml.td1.ToString()));
            RepListInput.Add(new cReportList("Переменная j", ml.j.ToString()));
            RepListInput.Add(new cReportList("Переменная бt", ml.deltat.ToString()));
            RepListInput.Add(new cReportList("Переменная K", ml.K.ToString()));
            RepListInput.Add(new cReportList("Средняя теплоемкость воздуха, кДж/м3", ml.Сv1.ToString()));
            RepListInput.Add(new cReportList("Средняя теплоемкость воздуха, кДж/м3", ml.Сv2.ToString()));
            RepListInput.Add(new cReportList("Коэффициент, учитывающий потери теплоты", ml.η.ToString()));
            RepListInput.Add(new cReportList("Температура дыма, С", ml.td2.ToString()));
            RepListInput.Add(new cReportList("Поправочный множитель", ml.εΔt.ToString()));
            RepListInput.Add(new cReportList("Число блоков по ширине печи", ml.Z1.ToString()));
            RepListInput.Add(new cReportList("Число блоков по высоте печи, шт", ml.Z2.ToString()));
            RepListInput.Add(new cReportList("Число блоков по длине печи, шт", ml.Z3.ToString()));
            RepListInput.Add(new cReportList("Число ходов по дыму", ml.nд.ToString()));
            RepListInput.Add(new cReportList("Число ходов по воздуху", ml.nв.ToString()));
            RepListInput.Add(new cReportList("Допустимая скорость дыма в рекуператоре, м/с", ml.Wо_ддоп.ToString()));
            RepListInput.Add(new cReportList("Допустимая скорость воздуха в рекуператоре, м/с", ml.Wо_вдоп.ToString()));
            RepListInput.Add(new cReportList("Переменная а", ml.a.ToString()));
            RepListInput.Add(new cReportList("Переменная b", ml.b.ToString()));
            RepListInput.Add(new cReportList("Предварительное значение коэффициента лучистого теплообмена, Вт/м2град", ml.α1dl.ToString()));
            RepListInput.Add(new cReportList("Поправочный коэффициент", ml.Кт.ToString()));
            RepListInput.Add(new cReportList("Переменная с", ml.с.ToString()));
            RepListInput.Add(new cReportList("Переменная d", ml.d.ToString()));
            RepListInput.Add(new cReportList("Толщина стенки стандартного блока, м", ml.S.ToString()));
            RepListInput.Add(new cReportList("Средняя температура, C", ml.tст.ToString()));
            RepListInput.Add(new cReportList("Переменная В1", ml.B1.ToString()));
            RepListInput.Add(new cReportList("Коэффициент теплопроводности, Вт/м2град", ml.Kтп.ToString()));
            RepListInput.Add(new cReportList("Переменная e", ml.e.ToString()));
            RepListInput.Add(new cReportList("Переменная g", ml.g.ToString()));














            //foreach (NumberSum.Param par in _allParamsInput)
            //{
            //    if (par.IsReport)
            //    {
            //        double d = Math.Round(Convert.ToDouble(
            //            propertyGrid.SelectedObject.GetType().GetProperty(par.PropertyName).GetValue(
            //            propertyGrid.SelectedObject, null)), 3);
            //        RepListInput.Add(new NumberSum.cReportList(par.Description, d.ToString()));
            //    }
            //}



            // Результаты расчета в отчет только те, которые отметил пользователь (IsReport=true)
            //DataOutput _dataOutput = new DataOutput(s);
            List<cReportList> RepListOutput = new List<cReportList>();
            RepListOutput.Add(new cReportList("Количество воздуха,поступающее в рекуператор, м3/с", Math.Round(ml.get_Vв1(),2).ToString()));
            RepListOutput.Add(new cReportList("Количество воздуха,просасываемое через неплотности на сторону дыма в рекуп., м3/с", Math.Round(ml.get_Vv_pr(), 2).ToString()));
            RepListOutput.Add(new cReportList("Количество дыма,поступающее в рекуператор, м3/с", Math.Round(ml.get_Vд1(), 2).ToString()));
            RepListOutput.Add(new cReportList("Теплосодержание дыма до рекуператора, кДж/м3", Math.Round(ml.get_iд1()).ToString()));
            RepListOutput.Add(new cReportList("Теплосодержание воздуха до рекуператора, кДж/м3", Math.Round(ml.get_iв1(), 1).ToString()));
            RepListOutput.Add(new cReportList("Теплосодержание воздуха после рекуператора, кДж/м3", Math.Round(ml.get_iв2()).ToString()));
            RepListOutput.Add(new cReportList("Теплосодержание дыма после рекуператора, кДж/м3", Math.Round(ml.get_iд2(), 2).ToString()));
            RepListOutput.Add(new cReportList("Предварительное значение средней логарифмической разности температур, °C", Math.Round(ml.get_Δt1(), 1).ToString()));
            RepListOutput.Add(new cReportList("Вспомогательная величина", Math.Round(ml.get_P(), 2).ToString()));
            RepListOutput.Add(new cReportList("Вспомогательная величина", Math.Round(ml.get_R(), 2).ToString()));
            RepListOutput.Add(new cReportList("Действительная средняя логарифмическая разность температур в рекуператоре, °C", Math.Round(ml.get_Δt(), 2).ToString()));
            RepListOutput.Add(new cReportList("Общее число блоков, шт", Math.Round(ml.get_Z()).ToString()));
            RepListOutput.Add(new cReportList("Скорость дыма в рекуператоре, м/с", Math.Round(ml.get_Wод(), 2).ToString()));
            RepListOutput.Add(new cReportList("Скорость воздуха в рекуператоре, м/с", Math.Round(ml.get_Wов(), 2).ToString()));
            RepListOutput.Add(new cReportList("Средняя температура дыма в рекуператоре, °C", Math.Round(ml.get_tд()).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент конвективного теплообмена между дымом и стенкой рекуператора, Вт/м2град", Math.Round(ml.get_αд_к(), 2).ToString()));
            RepListOutput.Add(new cReportList("Значение коэффициента лучистого теплообмена, Вт/м2град", Math.Round(ml.get_αд_л(), 2).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент теплообмена на стороне дыма, Вт/м2град", Math.Round(ml.get_αд(), 2).ToString()));
            RepListOutput.Add(new cReportList("Средняя температура воздуха,  °C", Math.Round(ml.get_tв()).ToString()));
            RepListOutput.Add(new cReportList("Средняя температура стенки,  °C", Math.Round(ml.get_tst(), 2).ToString()));
            RepListOutput.Add(new cReportList("Средняя температура воздуха в пограничном слое,  °C", Math.Round(ml.get_tV1(), 2).ToString()));
            RepListOutput.Add(new cReportList("Температурный напор,  °C", Math.Round(ml.get_ΔT(), 2).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент теплоотдачи от стенки к воздуху,  Вт/м2град", Math.Round(ml.get_αв(), 2).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент теплопроводности материала стенки, Вт/м2град", Math.Round(ml.get_lш(), 2).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент теплопередачи в рекуператоре, Вт/м2град", Math.Round(ml.get_k(), 2).ToString()));
            RepListOutput.Add(new cReportList("Коэффициент теплопроводности материала стенки, Вт/м2град", Math.Round(ml.get_Qв()).ToString()));
            RepListOutput.Add(new cReportList("Поверхность нагрева, м2", Math.Round(ml.get_F(), 2).ToString()));
            RepListOutput.Add(new cReportList("Поверхность рекуператора,принятого при компоновке, м2", Math.Round(ml.get_F1(), 1).ToString()));
            











            //foreach (NumberSum.Param par in _allParamsOutput)
            //{
            //    if (par.IsReport)
            //    {
            //        double d = Math.Round(Convert.ToDouble(
            //            _dataOutput.GetType().GetProperty(par.PropertyName).GetValue(_dataOutput, null)), 3);
            //        RepListOutput.Add(new NumberSum.cReportList(par.Description, d.ToString()));
            //    }
            //}
            #endregion

            // Указать отчету источники данных                
            frmRpt.cReportInputBindingSource.DataSource = RepListInput;
            frmRpt.cReportOutputBindingSource.DataSource = RepListOutput;

            // Показать окно отчета на весь экран
            frmRpt.WindowState = FormWindowState.Maximized;
            frmRpt.ShowDialog(this);
        }

        private void btnPostr_Graf_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.Series[0].Points.AddXY(25, 19.9);
            chart1.Series[0].Points.AddXY(50, 107.8);
            chart1.Series[0].Points.AddXY(75, 197.6);
            chart1.Series[0].Points.AddXY(100, 289.5);
            chart1.Series[0].Points.AddXY(125, 383.5);
            chart1.Series[0].Points.AddXY(150, 479.7);
            chart1.Series[0].Points.AddXY(175, 578.4);
            chart1.Series[0].Points.AddXY(200, 679.7);
            chart1.Series[0].Points.AddXY(225, 783.7);
            chart1.Series[0].Points.AddXY(250, 890.7);
            chart1.Series[0].Points.AddXY(275, 1000.8);
            chart1.Series[0].Points.AddXY(300, 1114.4);
            chart1.Series[0].Points.AddXY(350, 1352.6);
            chart1.Series[0].Points.AddXY(375, 1477.8);
            chart1.Series[0].Points.AddXY(400, 1607.5);
            chart1.Series[0].Points.AddXY(425, 1742.2);
            chart1.Series[0].Points.AddXY(450, 1882.3);
            chart1.Series[0].Points.AddXY(475, 2028.07);
            chart1.Series[0].Points.AddXY(500, 2180.2);
            chart1.Series[0].Points.AddXY(525, 2339.3);
            chart1.Series[0].Points.AddXY(550, 2506.1);
            chart1.Series[0].Points.AddXY(575, 2681.3);
            chart1.Series[0].Points.AddXY(600, 2865.8);
            chart1.Series[0].Points.AddXY(625, 3060.8);

       


        }

        private void btnTochech_Graf_Click(object sender, EventArgs e)
        {
                chart1.Series[1].Points.Clear();
                chart1.Series[1].Points.AddXY(0, 0);
                chart1.Series[1].Points.AddXY(25, 19.9);
                chart1.Series[1].Points.AddXY(50, 107.8);
                chart1.Series[1].Points.AddXY(75, 197.6);
                chart1.Series[1].Points.AddXY(100, 289.5);
                chart1.Series[1].Points.AddXY(125, 383.5);
                chart1.Series[1].Points.AddXY(150, 479.7);
                chart1.Series[1].Points.AddXY(175, 578.4);
                chart1.Series[1].Points.AddXY(200, 679.7);
                chart1.Series[1].Points.AddXY(225, 783.7);
                chart1.Series[1].Points.AddXY(250, 890.7);
                chart1.Series[1].Points.AddXY(275, 1000.8);
                chart1.Series[1].Points.AddXY(300, 1114.4);
                chart1.Series[1].Points.AddXY(350, 1352.6);
                chart1.Series[1].Points.AddXY(375, 1477.8);
                chart1.Series[1].Points.AddXY(400, 1607.5);
                chart1.Series[1].Points.AddXY(425, 1742.2);
                chart1.Series[1].Points.AddXY(450, 1882.3);
                chart1.Series[1].Points.AddXY(475, 2028.07);
                chart1.Series[1].Points.AddXY(500, 2180.2);
                chart1.Series[1].Points.AddXY(525, 2339.3);
                chart1.Series[1].Points.AddXY(550, 2506.1);
                chart1.Series[1].Points.AddXY(575, 2681.3);
                chart1.Series[1].Points.AddXY(600, 2865.8);
                chart1.Series[1].Points.AddXY(625, 3060.8);
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lblPover_Nagrev_Click(object sender, EventArgs e)
        {
            
        }

        private void lblKonech_Temp_Click(object sender, EventArgs e)
        {

        }



    }
}

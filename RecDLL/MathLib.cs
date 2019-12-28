using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace RecDLL
{
    [Serializable]
    public class MathLib
    {

        #region Исходные данные

        /// <summary>
        /// Поверхность нагрева, м2
        /// </summary> 
        private double _Fbl;    // закрытая переменная класса 
        public double Fbl
        {
            get { return _Fbl; }
            set { _Fbl = value; }
        }

           
        /// <summary>
        /// Сечение для прохода воздуха, м2
        /// </summary> 
        private double _Fv;    // закрытая переменная класса 
        public double Fv
        {
            get { return _Fv; }
            set { _Fv = value; }
        }

        /// <summary>
        /// Сечение для прохода дыма, м2
        /// </summary> 
        private double _Fd;    // закрытая переменная класса 
        public double Fd
        {
            get { return _Fd; }
            set { _Fd = value; }
        }

        /// <summary>
        /// Эквивалентный диаметр воздушного канала, м
        /// </summary> 
        private double _decvi;    // закрытая переменная класса 
        public double decvi
        {
            get { return _decvi; }
            set { _decvi = value; }
        }

        /// <summary>
        /// Эквивалентный диаметр дымового канала, м
        /// </summary> 
        private double _decvidi;    // закрытая переменная класса 
        public double decvidi
        {
            get { return _decvidi; }
            set { _decvidi = value; }
        }
        
       
        /// <summary>
        /// Теплота сгорания, Дж/м3
        /// </summary> 
        private double _Q;    // закрытая переменная класса 
        public double Q
        {
            get { return _Q; }
            set { _Q = value; }
        }

        /// <summary>
        /// Начальная температура, C
        /// </summary> 
        private double _tv1;    // закрытая переменная класса 
        public double tv1
        {
            get { return _tv1; }
            set { _tv1 = value; }
        }

        /// <summary>
        /// Конечная температура, С
        /// </summary> 
        private double _tv2;    // закрытая переменная класса 
        public double tv2
        {
            get { return _tv2; }
            set { _tv2 = value; }
        }

        /// <summary>
        /// Расход топлива на печь, м3/с
        /// </summary> 
        private double _B;    // закрытая переменная класса 
        public double B
        {
            get { return _B; }
            set { _B = value; }
        }

        /// <summary>
        /// коэффициент избытка воздуха
        /// </summary> 
        private double _α;    // закрытая переменная класса 
        public double α
        {
            get { return _α; }
            set { _α = value; }
        }

        /// <summary>
        /// Характеристика горения топлива
        /// </summary> 
        private double _Lα;    // закрытая переменная класса 
        public double Lα
        {
            get { return _Lα; }
            set { _Lα = value; }
        }

        /// <summary>
        /// Характеристика горения топлива
        /// </summary> 
        private double _Vα;    // закрытая переменная класса 
        public double Vα
        {
            get { return _Vα; }
            set { _Vα = value; }
        }

        /// <summary>
        /// Характеристика горения топлива
        /// </summary> 
        private double _Vl;    // закрытая переменная класса 
        public double Vl
        {
            get { return _Vl; }
            set { _Vl = value; }
        }


        /// <summary>
        /// Температура продуктов горения, уходящих из печи
        /// </summary> 
        private double _td1;    // закрытая переменная класса 
        public double td1
        {
            get { return _td1; }
            set { _td1 = value; }
        }


        /// <summary>
        /// Температура продуктов горения, уходящих из печи
        /// </summary> 
        private double _j;    // закрытая переменная класса 
        public double j
        {
            get { return _j; }
            set { _j = value; }
        }


        /// <summary>
        /// Температура продуктов горения, уходящих из печи
        /// </summary> 
        private double _deltat;    // закрытая переменная класса 
        public double deltat
        {
            get { return _deltat; }
            set { _deltat = value; }
        }


        /// <summary>
        /// Температура продуктов горения, уходящих из печи
        /// </summary> 
        private double _K;    // закрытая переменная класса 
        public double K
        {
            get { return _K; }
            set { _K = value; }
        }


        /// <summary>
        /// Средняя теплоемкость воздуха, кДж/м3
        /// </summary> 
        private double _Сv1;    // закрытая переменная класса 
        public double Сv1
        {
            get { return _Сv1; }
            set { _Сv1 = value; }
        }

        /// <summary>
        /// Средняя теплоемкость воздуха, кДж/м3
        /// </summary> 
        private double _Сv2;    // закрытая переменная класса 
        public double Сv2
        {
            get { return _Сv2; }
            set { _Сv2 = value; }
        }

        /// <summary>
        /// Коэффициент, учитывающий потери теплоты
        /// </summary> 
        private double _η;    // закрытая переменная класса 
        public double η
        {
            get { return _η; }
            set { _η = value; }
        }


        /// <summary>
        /// Температура дыма
        /// </summary> 
        private double _td2;    // закрытая переменная класса 
        public double td2
        {
            get { return _td2; }
            set { _td2 = value; }
        }


        /// <summary>
        /// Поправочный множитель
        /// </summary> 
        private double _εΔt;    // закрытая переменная класса 
        public double εΔt
        {
            get { return _εΔt; }
            set { _εΔt = value; }
        }


        /// <summary>
        /// Число блоков по ширине печи, шт
        /// </summary> 
        private double _Z1;    // закрытая переменная класса 
        public double Z1
        {
            get { return _Z1; }
            set { _Z1 = value; }
        }


        /// <summary>
        /// Число блоков по высоте печи, шт
        /// </summary> 
        private double _Z2;    // закрытая переменная класса 
        public double Z2
        {
            get { return _Z2; }
            set { _Z2 = value; }
        }


        /// <summary>
        /// Число блоков по длине печи, шт
        /// </summary> 
        private double _Z3;    // закрытая переменная класса 
        public double Z3
        {
            get { return _Z3; }
            set { _Z3 = value; }
        }


        /// <summary>
        /// Число ходов по дыму
        /// </summary> 
        private double _nд;    // закрытая переменная класса 
        public double nд
        {
            get { return _nд; }
            set { _nд = value; }
        }


        /// <summary>
        /// Число ходов по воздуху
        /// </summary> 
        private double _nв;    // закрытая переменная класса 
        public double nв
        {
            get { return _nв; }
            set { _nв = value; }
        }


        /// <summary>
        /// Допустимая скорость дыма в рекуператоре, м/с
        /// </summary> 
        private double _Wо_ддоп;    // закрытая переменная класса 
        public double Wо_ддоп
        {
            get { return _Wо_ддоп; }
            set { _Wо_ддоп = value; }
        }


        /// <summary>
        /// Допустимая скорость воздуха в рекуператоре, м/с
        /// </summary> 
        private double _Wо_вдоп;    // закрытая переменная класса 
        public double Wо_вдоп
        {
            get { return _Wо_вдоп; }
            set { _Wо_вдоп = value; }
        }

        /// <summary>
        /// Прочий параметр
        /// </summary> 
        private double _a;    // закрытая переменная класса 
        public double a
        {
            get { return _a; }
            set { _a = value; }
        }


        /// <summary>
        /// Прочий параметр
        /// </summary> 
        private double _b;    // закрытая переменная класса 
        public double b
        {
            get { return _b; }
            set { _b = value; }
        }

        /// <summary>
        /// Предварительное значение коэффициента лучистого теплообмена, Вт/м2град
        /// </summary> 
        private double _α1dl;    // закрытая переменная класса 
        public double α1dl
        {
            get { return _α1dl; }
            set { _α1dl = value; }
        }


        /// <summary>
        /// Поправочный коэффициент
        /// </summary> 
        private double _Кт;    // закрытая переменная класса 
        public double Кт
        {
            get { return _Кт; }
            set { _Кт = value; }
        }


        /// <summary>
        /// Прочий параметр
        /// </summary> 
        private double _с;    // закрытая переменная класса 
        public double с
        {
            get { return _с; }
            set { _с = value; }
        }


        /// <summary>
        /// Прочий параметр
        /// </summary> 
        private double _d;    // закрытая переменная класса 
        public double d
        {
            get { return _d; }
            set { _d = value; }
        }


        /// <summary>
        /// Толщина стенки стандартного блока, м
        /// </summary> 
        private double _S;    // закрытая переменная класса 
        public double S
        {
            get { return _S; }
            set { _S = value; }
        }


        /// <summary>
        /// Средняя температура, C
        /// </summary> 
        private double _tст;    // закрытая переменная класса 
        public double tст
        {
            get { return _tст; }
            set { _tст = value; }
        }


        /// <summary>
        /// Прочий параметр
        /// </summary> 
        private double _B1;    // закрытая переменная класса 
        public double B1
        {
            get { return _B1; }
            set { _B1 = value; }
        }


        /// <summary>
        /// Коэффициент теплопроводности, Вт/м2град
        /// </summary> 
        private double _Kтп;    // закрытая переменная класса 
        public double Kтп
        {
            get { return _Kтп; }
            set { _Kтп = value; }
        }


        /// <summary>
        /// Прочий параметр
        /// </summary> 
        private double _e;    // закрытая переменная класса 
        public double e
        {
            get { return _e; }
            set { _e = value; }
        }


        /// <summary>
        /// Прочий параметр
        /// </summary> 
        private double _g;    // закрытая переменная класса 
        public double g
        {
            get { return _g; }
            set { _g = value; }
        }

        #endregion Исходные данные

        #region Методы сериализации/десериализации

        /// <summary>
        /// Загрузить исходные данные в экземпляр объекта расчета 
        /// </summary>  
        /// <param name="NameFile">Имя файла для извлечения данных</param>
        public MathLib LoadData(string FileName)
        {
            // Восстановить данные путем десериализации из XML-файла
            SoapFormatter myXMLFormat = new SoapFormatter();
            FileStream myStreamB = File.OpenRead(FileName);
            MathLib _s = (MathLib)myXMLFormat.Deserialize(myStreamB);
            myStreamB.Close();
            return _s;
        }

        /// <summary>
        /// Сохранение исходных данных объекта на диск
        /// </summary>  
        /// <param name="hc">Объект  для сохранения на диск</param>
        /// <param name="NameFile">Имя файла для сохранения</param>
        public void SaveData(MathLib s, string NameFile)
        {
            FileStream myStream = File.Create(NameFile);
            SoapFormatter myXMLFormat = new SoapFormatter();
            myXMLFormat.Serialize(myStream, s);
            myStream.Close();
        }

        #endregion Методы сериализации/десериализации

        #region Методы расчета показателей

        /// <summary>
        /// количество воздуха,поступающее в рекуператор, м3/с
        /// </summary> 
        private double _Vв1;    // закрытая переменная класса 
        public double get_Vв1()
        {
            return _Vв1 = (1 + _j) * _B * _Lα;
        }

        /// <summary>
        /// количество воздуха,просасываемое через неплотности на сторону дыма в рекуп., м3/с
        /// </summary> 
        private double _Vv_pr;    // закрытая переменная класса 
        public double get_Vv_pr()
        {
            return _Vv_pr = (_Vв1 - (_B * _Lα));
        }

        /// <summary>
        /// количество дыма,поступающее в рекуператор, м3/с
        /// </summary> 
        private double _Vд1;    // закрытая переменная класса 
        public double get_Vд1()
        {
            return _Vд1 = (_B * _Vα);
        }

        /// <summary>
        /// теплосодержание дыма до рекуператора, кДж/м3
        /// </summary> 
        private double _iд1;    // закрытая переменная класса 
        public double get_iд1()
        {
            return _iд1 = (_K + _deltat * _Vl);
        }

        /// <summary>
        /// теплосодержание воздуха до рекуператора, кДж/м3
        /// </summary> 
        private double _iв1;    // закрытая переменная класса 
        public double get_iв1()
        {
            return _iв1 = (_Сv1 * _tv1);
        }


        /// <summary>
        /// теплосодержание воздуха после рекуператора, кДж/м3
        /// </summary> 
        private double _iв2;    // закрытая переменная класса 
        public double get_iв2()
        {
            return _iв2 = (_Сv2 * _tv2);
        }

        /// <summary>
        /// теплосодержание дыма после рекуператора, кДж/м3
        /// </summary> 
        private double _iд2;    // закрытая переменная класса 
        public double get_iд2()
        {
            return _iд2 = (_Vд1 * _iд1 - ((1 / _η) * (_Vв1 - _Vv_pr) * (_iв2 - _iв1))) / (_Vд1 + _Vv_pr);
        }


        /// <summary>
        /// предварительное значение средней логарифмической разности температур, °C
        /// </summary> 
        private double _Δt1;    // закрытая переменная класса 
        public double get_Δt1()
        {
            return _Δt1 = ((_td1 - _tv2) - (_td2 - _tv1)) / Math.Log((_td1 - _tv2) / (_td2 - _tv1));
        }

        /// <summary>
        /// вспомогательная величина
        /// </summary> 
        private double _P;    // закрытая переменная класса 
        public double get_P()
        {
            return _P = (_tv2 - _tv1) / (_td1 - _tv1);
        }


        /// <summary>
        /// вспомогательная величина
        /// </summary> 
        private double _R;    // закрытая переменная класса 
        public double get_R()
        {
            return _R = (_td1 - _td2) / (_tv2 - _tv1);
        }


        /// <summary>
        /// действительная средняя логарифмическая разность температур в рекуператоре, °C 
        /// </summary> 
        private double _Δt;    // закрытая переменная класса 
        public double get_Δt()
        {
            return _Δt = (_Δt1 * _εΔt);
        }


        /// <summary>
        /// общее число блоков, шт
        /// </summary> 
        private double _Z;    // закрытая переменная класса 
        public double get_Z()
        {
            return _Z = (_Z1 * _Z2 * _Z3);
        }


        /// <summary>
        /// скорость дыма в рекуператоре, м/с
        /// </summary> 
        private double _Wод;    // закрытая переменная класса 
        public double get_Wод()
        {
            return _Wод = (_Vд1 + (0.5 * _Vv_pr)) / ((_Z1 - 1) * _Fd * (_Z2 / _nд));
        }


        /// <summary>
        /// скорость воздуха в рекуператоре, м/с
        /// </summary> 
        private double _Wов;    // закрытая переменная класса 
        public double get_Wов()
        {
            return _Wов = (_Vв1 - 0.5 * _Vv_pr) / (_Fv * ((_Z1 * _Z3) / nв));
        }


        /// <summary>
        /// средняя температура дыма в рекуператоре, °C
        /// </summary> 
        private double _tд;    // закрытая переменная класса 
        public double get_tд()
        {
            return _tд = 0.5 * (_td1 + _td2);
        }


        /// <summary>
        /// коэффициент конвективного теплообмена между дымом и стенкой рекуператора, Вт/м2град
        /// </summary> 
        private double _αд_к;    // закрытая переменная класса 
        public double get_αд_к()
        {
            return _αд_к = (_a + (_b * _tд)) * (Math.Pow(_Wод, 0.8) / Math.Pow(_decvidi, 0.2));
        }


        /// <summary>
        /// значение коэффициента лучистого теплообмена, Вт/м2град
        /// </summary> 
        private double _αд_л;    // закрытая переменная класса 
        public double get_αд_л()
        {
            return _αд_л = (_α1dl * _Кт);
        }


        /// <summary>
        /// коэффициент теплообмена на стороне дыма, Вт/м2град
        /// </summary> 
        private double _αд;    // закрытая переменная класса 
        public double get_αд()
        {
            return _αд = (_αд_к + _αд_л);
        }


        /// <summary>
        /// средняя температура воздуха,  °C
        /// </summary> 
        private double _tв;    // закрытая переменная класса 
        public double get_tв()
        {
            return _tв = 0.5 * (_tv1 + _tv2);
        }


        /// <summary>
        /// средняя температура стенки,  °C
        /// </summary> 
        private double _tst;    // закрытая переменная класса 
        public double get_tst()
        {
            return _tst = 0.5 * (_tд + _tв);
        }


        /// <summary>
        /// средняя температура воздуха в пограничном слое,  °C
        /// </summary> 
        private double _tV1;    // закрытая переменная класса 
        public double get_tV1()
        {
            return _tV1 = 0.5 * (_tв + _tst);
        }


        /// <summary>
        /// температурный напор,  °C
        /// </summary> 
        private double _ΔT;    // закрытая переменная класса 
        public double get_ΔT()
        {
            return _ΔT = (_tst - _tв);
        }


        /// <summary>
        /// коэффициент теплоотдачи от стенки к воздуху,  Вт/м2град
        /// </summary> 
        private double _αв;    // закрытая переменная класса 
        public double get_αв()
        {
            return _αв = (_с + (_d * _tV1)) * (Math.Pow(_Wов, 0.2) / Math.Pow(_decvi, 0.5)) * Math.Pow(_ΔT, 0.1);
        }


        /// <summary>
        /// коэффициент теплопроводности материала стенки, Вт/м2град
        /// </summary> 
        private double _lш;    // закрытая переменная класса 
        public double get_lш()
        {
            return _lш = 0.9 + (2.3 * _tст * _B1);
        }


        /// <summary>
        /// коэффициент теплопередачи в рекуператоре, Вт/м2град
        /// </summary> 
        private double _k;    // закрытая переменная класса 
        public double get_k()
        {
            return _k = 1 / ((1 / _αд) + (_S / _lш) + (1 / _αв));
        }

        /// <summary>
        /// коэффициент теплопроводности материала стенки, Вт/м2град
        /// </summary> 
        private double _Qв;    // закрытая переменная класса 
        public double get_Qв()
        {
            return _Qв = (_Vв1 - _e * _Vv_pr) * (_iв2 - _iв1) * _g;
        }


        /// <summary>
        /// поверхность нагрева, м2
        /// </summary> 
        private double _F;    // закрытая переменная класса 
        public double get_F()
        {
            return _F = _Qв / (_k  * _Δt);
        }


        /// <summary>
        /// поверхность рекуператора,принятого при компоновке, м2
        /// </summary> 
        private double _F1;    // закрытая переменная класса 
        public double get_F1()
        {
            return _F1 = _Z * _Fbl;
        }


        #endregion Методы расчета показателей

    }

}




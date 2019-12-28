using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using RecDLL;
//using NumberSumDll;

namespace RecApp
{
    [Serializable]
    public class DataInput
    {
        // Создать главный объект, который включает в себя все нужные объекты
        private MathLib _ml = new MathLib();

        public DataInput(MathLib ml)
        {
            _ml = ml;
        }


        [Description("Поверхность нагрева, м2")]
        [DisplayName("Fбл., м2")]
        [Category("Геометрические параметры")]
        public double Fbl
        {
            get { return _ml.Fbl; }
            set { _ml.Fbl = value; }
        }

        [Description("Сечение для прохода воздуха, м2")]
        [DisplayName("Fв, м2")]
        [Category("Геометрические параметры")]
        public double Fv
        {
            get { return _ml.Fv; }
            set { _ml.Fv = value; }
        }

        [Description("Сечение для прохода дыма, м2")]
        [DisplayName("Fд, м2")]
        [Category("Геометрические параметры")]
        public double Fd
        {
            get { return _ml.Fd; }
            set { _ml.Fd = value; }
        }

        [Description("Эквивалентный диаметр воздушного канала, м")]
        [DisplayName("dэкв., м2")]
        [Category("Геометрические параметры")]
        public double decvi
        {
            get { return _ml.decvi; }
            set { _ml.decvi = value; }
        }


        [Description("Эквивалентный диаметр дымового канала, м")]
        [DisplayName("dэкв.д, м")]
        [Category("Геометрические параметры")]
        public double decvidi
        {
            get { return _ml.decvidi; }
            set { _ml.decvidi = value; }
        }


        [Description("Теплота сгорания, Дж/м3")]
        [DisplayName("Q, Дж/м3")]
        [Category("Теплотехнические параметры")]
        public double Q
        {
            get { return _ml.Q; }
            set { _ml.Q = value; }
        }


        [Description("Начальная температура, С")]
        [DisplayName("tв', С")]
        [Category("Теплотехнические параметры")]
        public double tv1
        {
            get { return _ml.tv1; }
            set { _ml.tv1 = value; }
        }


        [Description("Конечная температура, С")]
        [DisplayName("tв'', С")]
        [Category("Теплотехнические параметры")]
        public double tv2
        {
            get { return _ml.tv2; }
            set { _ml.tv2 = value; }
        }


        [Description("Расход топлива на печь, м3/с")]
        [DisplayName("В, м3/с")]
        [Category("Теплотехнические параметры")]
        public double B
        {
            get { return _ml.B; }
            set { _ml.B = value; }
        }


        [Description("Коэффициент избытка воздуха")]
        [DisplayName("α")]
        [Category("Теплотехнические параметры")]
        public double α
        {
            get { return _ml.α; }
            set { _ml.α = value; }
        }


        [Description("Характеристика горения топлива, м3/м3")]
        [DisplayName("Lα, м3/м3")]
        [Category("Теплотехнические параметры")]
        public double Lα
        {
            get { return _ml.Lα; }
            set { _ml.Lα = value; }
        }


        [Description("Характеристика горения топлива, м3/м3")]
        [DisplayName("Vα, м3/м3")]
        [Category("Теплотехнические параметры")]
        public double Vα
        {
            get { return _ml.Vα; }
            set { _ml.Vα = value; }
        }

        [Description("Характеристика горения топлива, %")]
        [DisplayName("Vl, %")]
        [Category("Теплотехнические параметры")]
        public double Vl
        {
            get { return _ml.Vl; }
            set { _ml.Vl = value; }
        }


        [Description("Температура продуктов горения, уходящих из печи, C")]
        [DisplayName("tд', C")]
        [Category("Теплотехнические параметры")]
        public double td1
        {
            get { return _ml.td1; }
            set { _ml.td1 = value; }
        }


        [Description("Температура продуктов горения, уходящих из печи, C")]
        [DisplayName("j, C")]
        [Category("Теплотехнические параметры")]
        public double j
        {
            get { return _ml.j; }
            set { _ml.j = value; }
        }


        [Description("Температура продуктов горения, уходящих из печи, C")]
        [DisplayName("δt, C")]
        [Category("Теплотехнические параметры")]
        public double deltat
        {
            get { return _ml.deltat; }
            set { _ml.deltat = value; }
        }


        [Description("Температура продуктов горения, уходящих из печи, C")]
        [DisplayName("K, C")]
        [Category("Теплотехнические параметры")]
        public double K
        {
            get { return _ml.K; }
            set { _ml.K = value; }
        }


        [Description("Средняя теплоемкость воздуха, кДж/м3")]
        [DisplayName("Cв', кДж/м3")]
        [Category("Теплотехнические параметры")]
        public double Сv1
        {
            get { return _ml.Сv1; }
            set { _ml.Сv1 = value; }
        }


        [Description("Средняя теплоемкость воздуха, кДж/м3")]
        [DisplayName("Cв'', кДж/м3")]
        [Category("Теплотехнические параметры")]
        public double Сv2
        {
            get { return _ml.Сv2; }
            set { _ml.Сv2 = value; }
        }


        [Description("Коэффициент, учитывающий потери теплоты")]
        [DisplayName("η")]
        [Category("Теплотехнические параметры")]
        public double η
        {
            get { return _ml.η; }
            set { _ml.η = value; }
        }


        [Description("Температура дыма, С")]
        [DisplayName("tд''")]
        [Category("Теплотехнические параметры")]
        public double td2
        {
            get { return _ml.td2; }
            set { _ml.td2 = value; }
        }


        [Description("Поправочный множитель")]
        [DisplayName("εΔt")]
        [Category("Прочие параметры")]
        public double εΔt
        {
            get { return _ml.εΔt; }
            set { _ml.εΔt = value; }
        }


        [Description("Число блоков по ширине печи, шт")]
        [DisplayName("Z1")]
        [Category("Количество блоков")]
        public double Z1
        {
            get { return _ml.Z1; }
            set { _ml.Z1 = value; }
        }


        [Description("Число блоков по высоте печи, шт")]
        [DisplayName("Z2")]
        [Category("Количество блоков")]
        public double Z2
        {
            get { return _ml.Z2; }
            set { _ml.Z2 = value; }
        }


        [Description("Число блоков по длине печи, шт")]
        [DisplayName("Z3")]
        [Category("Количество блоков")]
        public double Z3
        {
            get { return _ml.Z3; }
            set { _ml.Z3 = value; }
        }


        [Description("Число ходов по дыму")]
        [DisplayName("nд")]
        [Category("Количество ходов")]
        public double nд
        {
            get { return _ml.nд; }
            set { _ml.nд = value; }
        }


        [Description("Число ходов по воздуху")]
        [DisplayName("nв")]
        [Category("Количество ходов")]
        public double nв
        {
            get { return _ml.nв; }
            set { _ml.nв = value; }
        }


        [Description("Допустимая скорость дыма в рекуператоре, м/с")]
        [DisplayName("Wо_ддоп")]
        [Category("Скорость")]
        public double Wо_ддоп
        {
            get { return _ml.Wо_ддоп; }
            set { _ml.Wо_ддоп = value; }
        }


        [Description("Допустимая скорость воздуха в рекуператоре, м/с")]
        [DisplayName("Wо_вдоп")]
        [Category("Скорость")]
        public double Wо_вдоп
        {
            get { return _ml.Wо_вдоп; }
            set { _ml.Wо_вдоп = value; }
        }


        [Description()]
        [DisplayName("a")]
        [Category("Прочие параметры")]
        public double a
        {
            get { return _ml.a; }
            set { _ml.a = value; }
        }


        [Description()]
        [DisplayName("b")]
        [Category("Прочие параметры")]
        public double b
        {
            get { return _ml.b; }
            set { _ml.b = value; }
        }


        [Description("Предварительное значение коэффициента лучистого теплообмена, Вт/м2град")]
        [DisplayName("α'д.л")]
        [Category("Коэффициенты")]
        public double α1dl
        {
            get { return _ml.α1dl; }
            set { _ml.α1dl = value; }
        }


        [Description("Поправочный коэффициент")]
        [DisplayName("Кт")]
        [Category("Коэффициенты")]
        public double Кт
        {
            get { return _ml.Кт; }
            set { _ml.Кт = value; }
        }


        [Description()]
        [DisplayName("c")]
        [Category("Прочие параметры")]
        public double с
        {
            get { return _ml.с; }
            set { _ml.с = value; }
        }


        [Description()]
        [DisplayName("d")]
        [Category("Прочие параметры")]
        public double d
        {
            get { return _ml.d; }
            set { _ml.d = value; }
        }


        [Description("Толщина стенки стандартного блока, м")]
        [DisplayName("S")]
        [Category("Геометрические параметры")]
        public double S
        {
            get { return _ml.S; }
            set { _ml.S = value; }
        }


        [Description("Средняя температура, C")]
        [DisplayName("tст")]
        [Category("Теплотехнические параметры")]
        public double tст
        {
            get { return _ml.tст; }
            set { _ml.tст = value; }
        }


        [Description()]
        [DisplayName("B1")]
        [Category("Прочие параметры")]
        public double B1
        {
            get { return _ml.B1; }
            set { _ml.B1 = value; }
        }


        [Description("Коэффициент теплопроводности, Вт/м2град")]
        [DisplayName("Kтп")]
        [Category("Коэффициенты")]
        public double Kтп
        {
            get { return _ml.Kтп; }
            set { _ml.Kтп = value; }
        }


        [Description()]
        [DisplayName("e")]
        [Category("Прочие параметры")]
        public double e
        {
            get { return _ml.e; }
            set { _ml.e = value; }
        }


        [Description()]
        [DisplayName("g")]
        [Category("Прочие параметры")]
        public double g
        {
            get { return _ml.g; }
            set { _ml.g = value; }
        }
    }


}

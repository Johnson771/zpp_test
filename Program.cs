using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   

class Program{
    public static void Main()
    {
        Car _newCar1 = new Car(1);
        _newCar1.Number = 1;
        _newCar1.Licence_plate = "NF123456";
        _newCar1.Engine_power = 147;
        _newCar1.Max_speed = 200;
        _newCar1.Colour = "green";
        _newCar1.Type = "personal vehicle";
        Console.WriteLine("car1 licence plate:" + _newCar1.Licence_plate + ", engine power:" + _newCar1.Engine_power + "kW,  maximal speed: " + _newCar1.Max_speed + "km/h, colour:" + _newCar1.Colour + ", type:" + _newCar1.Type);

        Car _newCar2 = new Car(2);
        _newCar1.Number = 2;
        _newCar2.Licence_plate = "NF654321";
        _newCar2.Engine_power = 150;
        _newCar2.Max_speed = 195;
        _newCar2.Colour = "blue";
        _newCar2.Type = "personal vehicle";
        Console.WriteLine("car2 licence plate:" + _newCar2.Licence_plate + ", engine power:" + _newCar2.Engine_power + "kW,  maximal speed: " + _newCar2.Max_speed + "km/h, colour:" + _newCar2.Colour + ", type:" + _newCar2.Type);
        CompareCar(_newCar1, _newCar2);

        Plane _newPlane = new Plane();
        _newPlane.Registration = "LN1234";
        _newPlane.Engine_power = 1000;
        _newPlane.Wingspan = 30;
        _newPlane.Load_capacity = 2;
        _newPlane.Weight = 10;
        Console.WriteLine("plane registration:" + _newPlane.Registration + ", engine power:" + _newPlane.Engine_power + "kW,  wingspan: " + _newPlane.Wingspan + "m, load capacity:" + _newPlane.Load_capacity + "t, weight:" + _newPlane.Weight + "t");

        Plane flyplane = _newPlane;
        _newPlane.StartFly();
        Car drivecar = _newCar1;
        drivecar.StartDrive();

        Boat _newBoat = new Boat();
        _newBoat.Registration = "ABC123";
        _newBoat.Engine_power = 100;
        _newBoat.Max_speed = 30;
        _newBoat.GrossTonnage = 500;
        Console.WriteLine("plane registration:" + _newBoat.Registration + ", engine power:" + _newBoat.Engine_power + "kW, " + _newBoat.Max_speed + " knot per hour, " + _newBoat.GrossTonnage + "kg gross tonnage");

        //if ((_newCar1.Licence_plate == _newCar2.Licence_plate) && (_newCar1.Engine_power == _newCar2.Engine_power) && (_newCar1.Max_speed == _newCar2.Max_speed) && (_newCar1.Colour == _newCar2.Colour) && (_newCar1.Type == _newCar1.Type))
        //{ 
        //    Console.WriteLine("The same car !");
        //}
        //else
        //{
        //    Console.WriteLine("The different car !");
        //}
    }
    public static void CompareCar(Car a,Car b)
    {if ((a.Licence_plate == b.Licence_plate) && (a.Engine_power == a.Engine_power) && (a.Max_speed == b.Max_speed) && (a.Colour == b.Colour) && (a.Type == b.Type))
        {
            Console.WriteLine("The same car !");
        }
        else
        {
            Console.WriteLine("The different car !");}
    }
        
       
    }
        //public static void Car1()
        //{
        //    Car _newCar1 = new Car();
        //    _newCar1.Licence_plate = "NF123456";
        //    _newCar1.Engine_power = 147;
        //    _newCar1.Max_speed = 200;
        //    _newCar1.Colour = "green";
        //    _newCar1.Type = "personal vehicle";
        //    Console.WriteLine("car1 licence plate:" + _newCar1.Licence_plate + ", engine power:" + _newCar1.Engine_power + "kW,  maximal speed: " + _newCar1.Max_speed + "km/h, colour:" + _newCar1.Colour + ", type:" + _newCar1.Type);

        //}



//public class DriveCar {
//        public string Licence_platelicence;  // 车牌属性
//        // 构造函数
//       public Car(string Licence_plate)
//        {
//            // 用this关键字给正在构造的对象赋值
//            this.Licence_plate = Licence_plate;
//        }
    
//    public void Information()
//    {
//        Console.WriteLine("this car is driving! car licence plate:" + Licence_plate + ", engine power:" + Engine_power + "kW,  maximal speed: " + Max_speed + "km/h, colour:" + Colour + ", type:" + Type);

//    }  
//}
// ;

    //class Drive
    //{
    //    public void Drive()
    //    {
    //        Program _newprogram = new Program();
    //        _newprogram.Car1();
    //    }
    //}


public class Car //车类
{
    public int _number;
    public string _licence_plate;
    public int _engine_power;
    public int _max_speed;
    public string _colour;
    public string _type;

    public int Number //车牌属性
    {
        get { return _number; }
        set { _number = value; }
    }
    public string Licence_plate //车牌属性
    {
        get { return _licence_plate; }
        set { _licence_plate = value; }
    }
    public int Engine_power //发动机属性(单位kW)
    {
        get { return _engine_power; }
        set { _engine_power = value; }
    }
    public int Max_speed //最大车速属性(单位km/h)
    {
        get { return _max_speed; }
        set { _max_speed = value; }
    }
    public string Colour //颜色属性
    {
        get { return _colour; }
        set { _colour = value; }
    }
    public string Type //车类别属性
    {
        get { return _type; }
        set { _type = value; }
    }
    public Car(int Number)
    {
        // 用this关键字给正在构造的对象赋值
        this.Number = Number;
    }

    public void StartDrive()
    {
        Console.WriteLine(DiveInfo.CarNum(this));

    }  
}
public class DiveInfo
{
    public static string CarNum(Car A)
    {
        return ("the car to drive! car licence plate:" + A.Licence_plate + ", engine power:" + A.Engine_power + "kW,  maximal speed: " + A.Max_speed + "km/h, colour:" + A.Colour + ", type:" + A.Type);
    }
}


public class Plane //飞机类
{
    public string _registration;
    public int _engine_power;
    public int _wingspan;
    public int _load_capacity;
    public int _weight;

    public string Registration //飞机牌属性
    {
        get { return _registration; }
        set { _registration = value; }
    }
    public int Engine_power //发动机属性(单位kW)
    {
        get { return _engine_power; }
        set { _engine_power = value; }
    }
    public int Wingspan //翼展(单位m)
    {
        get { return _wingspan; }
        set { _wingspan = value; }
    }
    public int Load_capacity //载重(单位t)
    {
        get { return _load_capacity; }
        set { _load_capacity = value; }
    }
    public int Weight //净重(单位t)
    {
        get { return _weight; }
        set { _weight = value; }
    }
    public void StartFly()
    {
        Console.WriteLine("the plane to fly! plane registration:" + Registration + ", engine power:" + Engine_power + "kW,  wingspan: " + Wingspan + "m, load capacity:" + Load_capacity + "t, weight:" + Weight + "t");

    }  
}   ;


public class Boat //船类
{
    public string _registration;
    public int _engine_power;
    public int _max_speed;
    public int _gross_tonnage;

    public string Registration //船牌属性
    {
        get { return _registration; }
        set { _registration = value; }
    }
    public int Engine_power //发动机属性(单位kW)
    {
        get { return _engine_power; }
        set { _engine_power = value; }
    }
    public int Max_speed //最高时速(单位knot per hour)
    {
        get { return _max_speed; }
        set { _max_speed = value; }
    }
    public int GrossTonnage //总吨位(单位kg)
    {
        get { return _gross_tonnage; }
        set { _gross_tonnage = value; }
    }
}   ;
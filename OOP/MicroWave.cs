using System.Collections.Generic;
namespace OOP
{
    public class TimerSystem
    {

        int timer;
        public TimerSystem()
        {
        }
        public void setTimer(int s)
        {
            timer = s;
            System.Console.WriteLine($"Da thiet lap thoi gian dem nguoc la {s} s");
        }
        public bool countDown()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine($"Se ket thuc trong {timer} s");
                timer = timer - 1;
                if (timer == 0) return true;
            }
        }
        //Cac doan code phuc tap khac

    }
    public class TemperatureSystem
    {
        int temperature;
        public TemperatureSystem()
        {
        }
        public void setTemperature(int t)
        {
            temperature = t;
            System.Console.WriteLine($"Da thiet lap nhiet do la {t} do C");
        }
        //Cac doan code phuc tap khac
    }

    public class ElectricSystem
    {
        public ElectricSystem()
        {
        }
        public void Start()
        {
            System.Console.WriteLine("Da cap dien thanh cong");
        }
        public void End()
        {
            System.Console.WriteLine("Da ngung cap dien");
            System.Console.WriteLine();
        }
        //Cac doan code phuc tap khac
    }

    public class NotifySystem
    {
        public NotifySystem()
        {
        }
        public void notify()
        {
            System.Console.WriteLine("Ting! Ting!");
            System.Console.WriteLine("Xong roi do");
        }
        //Cac doan code phuc tap khac
    }

    public class MicroWaveFacade
    {
        static int no = 0;
        static List<MicroWaveFacade> listMicroWave = new List<MicroWaveFacade>();
        TimerSystem timer;
        TemperatureSystem temperature;
        ElectricSystem electric;
        NotifySystem notify;
        //client da su dung lo vi song nay
        List<Client> listClient = new List<Client>();
        List<int> listClientTime = new List<int>();
        List<int> listClientTemper = new List<int>();
        int id;
        public MicroWaveFacade()
        {
            this.timer = new TimerSystem();
            this.temperature = new TemperatureSystem();
            this.electric = new ElectricSystem();
            this.notify = new NotifySystem();
            this.id = no++;
            listMicroWave.Add(this);
        }
        public void start(int time, int temperature, Client client)
        {
            System.Console.WriteLine($"Client so {client.id} dang su dung lo vi song so {this.id}");
            this.timer.setTimer(time);
            this.temperature.setTemperature(temperature);
            // this.electric.Start();
            // if (timer.countDown())
            // {
            //     this.notify.notify();
            //     this.electric.End();
            // }
            System.Console.WriteLine();
            this.listClient.Add(client);
            this.listClientTemper.Add(temperature);
            this.listClientTime.Add(time);
        }
        public void getInfo()
        {
            if (listClient.Count == 0)
            {
                System.Console.WriteLine($"Lo si song so {this.id} chu co ai su dung");
            }
            else
                foreach (Client client in listClient)
                {
                    var n = this.listClient.IndexOf(client);
                    System.Console.WriteLine(
                    $"Client so {client.id} da thiet lap lo vi song {this.id} thoi gian la {this.listClientTime[n]}"
                    + $" va nhiet do la {this.listClientTemper[n]} ");
                    System.Console.WriteLine();
                }
        }
        public static void getInfoClient(Client client)
        {
            bool used = false;
            foreach (MicroWaveFacade microWave in listMicroWave)
            {
                if (microWave.listClient.Contains(client))
                {
                    used = true;
                    var n = microWave.listClient.IndexOf(client);
                    System.Console.WriteLine(
                    $"Client {client.id} da thiet lap lo vi song {microWave.id} co thoi gian la {microWave.listClientTime[n]}"
                    + $" va nhiet do la {microWave.listClientTemper[n]}");
                    System.Console.WriteLine();
                }
            }
            if (used == false)
                System.Console.WriteLine($"Client so {client.id} chua su dung lo vi song nao");
        }


        public bool checkStarted(Client client)
        {
            if (this.listClient.Contains(client))
            {
                System.Console.WriteLine($"Client so {client.id} da dung lo vi song so {this.id}");
                return true;
            }
            else
            {
                System.Console.WriteLine($"Client so {client.id} chua dung lo vi song so {this.id}");
            }
            return false;
        }
        //Cac doan code phuc tap khac
    }
    public class MicroWaveFacade1
    {
        TimerSystem timer;
        TemperatureSystem temperature;
        ElectricSystem electric;
        NotifySystem notify;
        public MicroWaveFacade1()
        {
            this.timer = new TimerSystem();
            this.temperature = new TemperatureSystem();
            this.electric = new ElectricSystem();
            this.notify = new NotifySystem();
        }
        public void setTime(int time)
        {
            this.timer.setTimer(time);
        }
        public void setTemperature(int temperature)
        {
            this.temperature.setTemperature(temperature);
        }
        public void start()
        {
            electric.Start();
            if (timer.countDown())
            {
                this.notify.notify();
                this.electric.End();
            }
        }
        //Cac doan code phuc tap khac
    }
    public class MicroWaveFacade2
    {
        TimerSystem timer;
        TemperatureSystem temperature;
        ElectricSystem electric;
        NotifySystem notify;
        public MicroWaveFacade2()
        {
            this.timer = new TimerSystem();
            this.temperature = new TemperatureSystem();
            this.electric = new ElectricSystem();
            this.notify = new NotifySystem();
        }
        public void setTime(int time)
        {
            this.timer.setTimer(time);
        }
        public void setTemperature(int temperature)
        {
            this.temperature.setTemperature(temperature);
        }
        public void start(int time, int temperature)
        {
            this.timer.setTimer(time);
            this.temperature.setTemperature(temperature);
            this.electric.Start();
            if (timer.countDown())
            {
                this.notify.notify();
                this.electric.End();
            }
        }
        //Cac doan code phuc tap khac
    }


}
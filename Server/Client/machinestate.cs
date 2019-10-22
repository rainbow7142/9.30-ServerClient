using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class machinestate
    {
        public class MachineState
        {

            // UseStillImage = 0, UseColorSenseor = 2, UseEDMS = 4, UsePinhole = 6, UseRVMS = 8
            // SP_Speed = 10, PV_Speed = 12, PV_Postion = 14,
            // LotNo = 18, Model = 38, Worker = 58, Paste = 78,
            // RollDia = 98, RewinderCut = 102
            
            bool isConnected = false;
            public bool IsConnected { get => isConnected; set => isConnected = value; }

            bool stillImageOnStart = false;
            public bool StillImageOnStart { get => stillImageOnStart; set => stillImageOnStart = value; }

            bool colorSensorOnStart = false;
            public bool ColorSensorOnStart { get => colorSensorOnStart; set => colorSensorOnStart = value; }

            bool edmsOnStart = false;
            public bool EdmsOnStart { get => edmsOnStart; set => edmsOnStart = value; }

            bool pinholeOnStart = false;
            public bool PinholeOnStart { get => pinholeOnStart; set => pinholeOnStart = value; }

            bool rvmsOnStart = false;
            public bool RvmsOnStart { get => rvmsOnStart; set => rvmsOnStart = value; }

            bool sedmsOnStart = false;
            public bool SedmsOnStart { get => sedmsOnStart; set => sedmsOnStart = value; }

            //  Target SetPoint speed m/min
            double spSpeed = 200;
            public double SpSpeed { get => spSpeed; set => spSpeed = value; }

            //speed m/min
            double pvSpeed = 200;
            public double PvSpeed { get => pvSpeed; set => pvSpeed = value; }

            //m
            double pvPosition = 0;
            public double PvPosition { get => pvPosition; set => pvPosition = value; }

            string lotNo = "";
            public string LotNo
            {
                get
                {
                    return lotNo;
                    //if (string.IsNullOrEmpty(lotNo))
                    //    lotNo = string.Format("Unkown/{0}", DateTime.Now.ToString("yyMMddHHmm"));

                    //else if ( lotNo.IndexOf("Unkown/") >= 0)
                    //    lotNo = string.Format("Unkown/{0}", DateTime.Now.ToString("yyMMddHHmm"));

                    //return lotNo;
                }
                set { lotNo = value; }
            }

            string modelName = "";
            public string ModelName { get => modelName; set => modelName = value; }

            string worker = "";
            public string Worker { get => worker; set => worker = value; }

            string paste = "";
            public string Paste { get => paste; set => paste = value; }

            double rollDia = 0;
            public double RollDia { get => rollDia; set => rollDia = value; }

            bool rewinderCut = false;
            public bool RewinderCut { get => rewinderCut; set => rewinderCut = value; }


            int rvms_BeforePattern = 0;
            public int Rvms_BeforePattern { get => rvms_BeforePattern; set => rvms_BeforePattern = value; }

            int rvms_AfterPattern = 0;
            public int Rvms_AfterPattern { get => rvms_AfterPattern; set => rvms_AfterPattern = value; }

            //public MachineState()
            //{

            //}
            public MachineState(MachineState org)
            {
                this.isConnected = org.isConnected;
                this.stillImageOnStart = org.stillImageOnStart;
                this.colorSensorOnStart = org.colorSensorOnStart;
                this.edmsOnStart = org.edmsOnStart;
                this.pinholeOnStart = org.pinholeOnStart;
                this.rvmsOnStart = org.rvmsOnStart;
                this.sedmsOnStart = org.sedmsOnStart;
                this.spSpeed = org.spSpeed;
                this.pvSpeed = org.pvSpeed;
                this.pvPosition = org.pvPosition;

                this.lotNo = String.Copy(org.lotNo);
                this.modelName = String.Copy(org.modelName);
                this.worker = String.Copy(org.worker);
                this.paste = String.Copy(org.paste);

                this.rollDia = org.rollDia;
                this.rewinderCut = org.rewinderCut;
                this.rvms_BeforePattern = org.rvms_BeforePattern;
                this.rvms_AfterPattern = org.rvms_AfterPattern;
            }


            public void Set()
            {
                stillImageOnStart = true;
                colorSensorOnStart = true;
                edmsOnStart = true;
                pinholeOnStart = true;
                rvmsOnStart = true;
                sedmsOnStart = true;
                rewinderCut = true;
            }

            public void Reset()
            {
                stillImageOnStart = false;
                colorSensorOnStart = false;
                edmsOnStart = false;
                pinholeOnStart = false;
                rvmsOnStart = false;
                sedmsOnStart = false;
                rewinderCut = false;
            }

            public void Toggle()
            {
                stillImageOnStart = !stillImageOnStart;
                colorSensorOnStart = !colorSensorOnStart;
                edmsOnStart = !edmsOnStart;
                pinholeOnStart = !pinholeOnStart;
                rvmsOnStart = !rvmsOnStart;
                sedmsOnStart = !sedmsOnStart;
                rewinderCut = !rewinderCut;
            }

            public virtual void Load()
            {
                // 현재는 필요 없어 보이나 마지막 러닝 상태 굳이 확인 한다면 넣어주세요
            }

            public MachineState DeepCopy()
            {
                MachineState copy = new MachineState(this);
                return copy;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lv7.components
{
    //3.zad
    //class SystemDataProvider : SimpleSystemDataProvider
    //{
    //    private float previousCPULoad;
    //    private float previousRAMAvailable;
    //    public SystemDataProvider() : base()
    //    {
    //        this.previousCPULoad = this.CPULoad;
    //        this.previousRAMAvailable = this.AvailableRAM;
    //    }
    //    public float GetCPULoad()
    //    {
    //        float currentLoad = this.CPULoad;
    //        if (currentLoad != this.previousCPULoad)
    //        {
    //            this.Notify();
    //        }
    //        this.previousCPULoad = currentLoad;
    //        return currentLoad;
    //    }
    //    public float GetAvailableRAM()
    //    {
    //        float RAMAvailable = this.AvailableRAM;
    //        if (RAMAvailable != this.previousRAMAvailable)
    //        {
    //            this.Notify();
    //        }
    //        this.previousCPULoad = RAMAvailable;
    //        return RAMAvailable;
    //    }
    //}

    //4.zad
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if ((currentLoad / this.previousCPULoad * 100 > 110) || (currentLoad / this.previousCPULoad * 100 < 90))
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float RAMAvailable = this.AvailableRAM;
            if ((RAMAvailable / this.previousRAMAvailable * 100 > 110) || (RAMAvailable / this.previousRAMAvailable * 100 < 90))
            {
                this.Notify();
            }
            this.previousCPULoad = RAMAvailable;
            return RAMAvailable;
        }
    }
}

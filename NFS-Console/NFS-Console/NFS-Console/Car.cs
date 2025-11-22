

using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;

namespace NFS_Console
{
    public class Car
    {
        private string model_;
        private double speed_;

        public void SetModel(string model)
        {
            model_ = model;
        }

        public string GetModel()
        {
            return model_;
        }

        public void SetSpeed(double speed)
        {
            speed_ = speed;
        }
        public double GetSpeed()
        {
            return speed_;
        }

    }   
}

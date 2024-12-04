using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class watch
    {
        private DateTime startTime;
        private DateTime endTime;

        // Phương thức khởi tạo không tham số
        public watch()
        {
            startTime = DateTime.Now; // Khởi tạo startTime với thời gian hiện tại
        }

        // Phương thức Start
        public void Start()
        {
            startTime = DateTime.Now; // Đặt startTime lại là thời gian hiện tại
        }

        // Phương thức Stop
        public void Stop()
        {
            endTime = DateTime.Now; // Đặt endTime là thời gian hiện tại
        }

        // Phương thức GetElapsedTime
        public double GetElapsedTime()
        {
            return (endTime - startTime).TotalMilliseconds; // Trả về thời gian đã trôi qua (tính theo mili giây)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AnkiCardCreator
{
    public class DownloaderThreading
    {
        PictureBox pcb;
        Presenter presenter;
        Task tsk;
        object locker = new object();

        public DownloaderThreading(Presenter pr, PictureBox pbox)
        {
            presenter = pr;
            pcb = pbox;

            tsk = Task.Factory.StartNew(Download);
        }

        public void Download()
        {
            lock (locker)
            {
                pcb.Load(presenter.GetImageUrl());    
            }
            
        }
    }
}

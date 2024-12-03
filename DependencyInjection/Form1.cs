using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjection
{
     public interface IEvent
    {
        void LoadEventDetails();
       
    }

    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

        }
       

        private void btnGetEventDetails_Click(object sender, EventArgs e)
        {
            College col = new College(new FootballEvent());
            col.GetEvents();
        }

       
        private void btnDIUsingProperties_Click(object sender, EventArgs e)
        {
            College col = new College();
            col.EventProperty = new PartyEvent();
            col.GetEvents();
        }

        private void btnDIUsingMethod_Click(object sender, EventArgs e)
        {
            College col = new College();
            col.GetEventDetails(new TechEvent());
            col.GetEvents();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDIUsingServiceLocator_Click(object sender, EventArgs e)
        {
            if (cmbEvents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select event");
                return;
            }
            College col = new College(cmbEvents.SelectedIndex);          
            col.GetEvents();
        }
    }

    class College
    {
        private IEvent _event = null;

        public College()
        { }

        //DI using Constructor
        public College(IEvent evnt)
        {
            this._event = evnt;
        }

        //DI using Service locator
        EventLocator el = new EventLocator();
        public College(int index)
        {

            this._event = el.LoadEvent(index);
        }

        //DI Using Properties
         public IEvent EventProperty
        {
            set
            {
                _event = value;
            }
        }
        public void GetEvents()
        {
            this._event.LoadEventDetails();
        }


        //DI Using Method
        public void GetEventDetails(IEvent eve)
        {
            this._event = eve;
        }
    }


    class EventLocator
    {

        public IEvent LoadEvent(int index)
        {
            if(index == 0)
            {
                return new FootballEvent();
            }
            else if(index==1)
            {
                return new PartyEvent();
            }
            else
            {
                return new TechEvent();
            }

        }
    }

    class TechEvent : IEvent
    {
        public void LoadEventDetails()
        {
            MessageBox.Show("Tech event details");
        }
    }

    class FootballEvent : IEvent
    {
        public void LoadEventDetails()
        {
            MessageBox.Show("Football event details");
        }
    }

    class PartyEvent : IEvent
    {
        public void LoadEventDetails()
        {
            MessageBox.Show("Party event details");
        }
    }




   
}

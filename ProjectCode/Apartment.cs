using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace partBproject
{
    public class Apartment
    {
        private int apartmentNum;
        public Project project;
        private int apartmentFloor;
        private int numofRooms;
        private SaleStatus saleStatus;
        private float estimatedPrice;
        private float salePrice;
        public System.Collections.Generic.List<Request> requests;


        public Apartment(int apartmentNum, Project project, int apartmentFloor, int numofRooms, SaleStatus saleStatus, float estimatedPrice, float salePrice)
        {
            this.apartmentNum = apartmentNum;
            this.project = project;
            this.apartmentFloor = apartmentFloor;
            this.numofRooms = numofRooms;
            this.saleStatus = saleStatus;
            this.estimatedPrice = estimatedPrice;
            this.salePrice = salePrice;
            requests = new List<Request>();
        }
        //getters
        public int getApartmentNum()
        {
            return this.apartmentNum;
        }
        public Project getProject()
        {
            return this.project;
        }
        public int getApartmentFloor()
        {
            return this.apartmentFloor;
        }
        public int getnumofRooms()
        {
            return this.numofRooms;
        }
        public SaleStatus getSaleStatus()
        {
            return this.saleStatus;
        }
        public float getestimatedPrice()
        {
            return this.estimatedPrice;
        }
        public float getsalePrice()
        {
            return this.salePrice;
        }
        public List<Request> getRequests()
        {
            return this.requests;
        }

    }
}
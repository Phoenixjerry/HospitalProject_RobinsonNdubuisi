using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
	public class Patient {
		public int ticketno;
		public string name;
        public string gender;
        public string bloodType;
        public string diseaseType;
		public void Dataentry(string nam, string btype, string dtype, string sex, int num) {
			name = nam;
			bloodType = btype;
			diseaseType = dtype;
			gender = sex;
			ticketno = num;
		}
        public string getData()
        {
            return (name + '\t' + bloodType + '\t' + diseaseType + '\t' + gender + '\t' + ticketno);
        }
		public string dispName() {
			return name;
		}
		public string dispblood() {
			return bloodType;
		}
		public string dispdisease() {
			return diseaseType;
		}
		public string dispsex() {
			return gender;
		}
		public int dispnumber() {
			return ticketno;
		}
	}
}

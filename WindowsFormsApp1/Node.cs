using System;
namespace WindowsFormsApp1 {
	public class Node {
		public Patient data;
		public Node next;
        public Node(Patient temp)
        {
            data = new Patient();
            data = temp;
        }
	}
}
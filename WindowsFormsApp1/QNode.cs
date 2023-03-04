using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1 {
	class QNode {
		public Node key;
		public QNode next;

		public QNode(Node key = null) {
			this.key = key;
			this.next = null;
		}
	}


	class Queue {
		QNode front, rear;
        public int size = 0;

		public Queue() {
			this.front = this.rear = null;
		}

        public QNode at(int index)
        {
            if (index >= size)
            {
                return null;
            }
            QNode tmp = this.front;
            for  (int i = 0; i < index; i++)
            {
                tmp = tmp.next;
            }
            return tmp;
        }
		public void enqueue(Node key) {


			QNode temp = new QNode(key);


			if (this.rear == null) {
				this.front = this.rear = temp;
                size++;
				return;
			}


			this.rear.next = temp;
			this.rear = temp;
            size++;
		}

		public QNode dequeue() {

			if (this.front == null)
				return null;



			QNode temp = this.front;
			this.front = this.front.next;


			if (this.front == null)
				this.rear = null;
            size--;
			return temp;
		}
	}
}
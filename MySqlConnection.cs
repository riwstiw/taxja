﻿using System;

namespace WindowsFormsApp1
{
    internal class MySqlConnection
    {
        private string v;

        public MySqlConnection(string v)
        {
            this.v = v;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}
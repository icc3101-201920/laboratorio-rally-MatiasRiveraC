﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasRally
{
	public class AgregarVehiculoEventArgs: EventArgs
	{
		public string marca { get; set; }
		public int cilindrada { get; set; }
	}
}

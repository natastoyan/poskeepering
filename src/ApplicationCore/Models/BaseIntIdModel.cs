using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Models
{
	public class BaseIntIdModel
	{
		public virtual decimal Id { get; protected set; }
	}
}

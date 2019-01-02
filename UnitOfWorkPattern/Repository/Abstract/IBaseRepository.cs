﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain;

namespace UnitOfWorkPattern.Repository.Abstract
{
	public interface IBaseRepository<T> where T : BaseEntity
	{
		void Add(T entity);
	}
}

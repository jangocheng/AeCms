using System;
using System.Collections.Generic;
using System.Text;

namespace Ator.Model
{
    public class PagingDto
    {
        #region Page

        /// <summary>
        /// 每页显示条数
        /// Linq分页查询时Take的参数
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// 每页开始的记录序号
        /// Linq分页查询时Skip的参数
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// 当前页
        /// 返回前端显示当前页码
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// 总数据个数
        /// </summary>
        public int Total { get; set; }

        #endregion
    }
}

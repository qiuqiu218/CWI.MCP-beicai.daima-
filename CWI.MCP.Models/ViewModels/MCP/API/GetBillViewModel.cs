﻿using System.ComponentModel.DataAnnotations;
using Evt.Framework.Mvc;

namespace CWI.MCP.Models
{
    /// <summary>
    /// 获取打印票据参数
    /// </summary>
    public class GetBillViewModel : ViewModel
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 订单Key
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 是否需要加密,1:要加密
        /// </summary>
        public string ptype { get; set; }
    }
}

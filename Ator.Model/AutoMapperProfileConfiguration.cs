using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ator.Model
{
    class AutoMapperProfileConfiguration : Profile
    {
        //构造函数里完成初始化绑定
        public AutoMapperProfileConfiguration()
        {
            //添加配置
            CreateMap<string, int>().ReverseMap();//ReverseMap反转映射
        }
    }
}

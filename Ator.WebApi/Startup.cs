﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ator.Common.Web.Filter;
using Ator.Common.Web.Handler;
using Ator.Entity;
using Ator.Model.Api;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;

namespace Ator.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AeDbContext>(options => options.UseMySql(Configuration.GetConnectionString("SQLConnection")));

            #region jwt配置
            services.Configure<JwtSettingsModel>(Configuration.GetSection("JwtSettings"));
            var jwtSettings = new JwtSettingsModel();
            Configuration.Bind("JwtSettings", jwtSettings);
            //认证middleware配置
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            //Jwt的middleware配置
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
                };
            });
            //检测Token有效性
            services.AddScoped<IAuthorizationHandler, ValidJtiHandler>();
            #endregion

            #region 添加MVC并添加配置
            services.AddMvc(o =>
            {
                o.Filters.Add(typeof(GlobalExceptionsFilter));//添加全局异常处理
            })
            .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();//json默认处理不会大小写变化
                    options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";//默认时间处理格式，去除T
                });
            #endregion

            #region AutoMapper（实体转换）配置
            services.AddAutoMapper();
            #endregion

            #region 配置跨域处理
            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder.AllowAnyOrigin() //允许任何来源的主机访问
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();//指定处理cookie
                });
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

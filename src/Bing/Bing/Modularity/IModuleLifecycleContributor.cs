﻿using Bing.DependencyInjection;

namespace Bing.Modularity
{
    /// <summary>
    /// 模块生命周期构造器
    /// </summary>
    public interface IModuleLifecycleContributor : ITransientDependency
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="context">应用程序初始化上下文</param>
        /// <param name="module">模块</param>
        void Initialize(ApplicationInitializationContext context, IBingModule module);

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="context">应用程序关闭上下文</param>
        /// <param name="module">模块</param>
        void Shutdown(ApplicationShutdownContext context, IBingModule module);
    }
}

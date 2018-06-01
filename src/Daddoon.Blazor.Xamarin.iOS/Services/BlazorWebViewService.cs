﻿using Daddoon.Blazor.Xam.iOS.Renderer;
using Daddoon.Blazor.Xam.Services;
using System;
using System.IO;

namespace Daddoon.Blazor.Xam.iOS.Services
{
    public class BlazorWebViewService
    {
        private static void InitComponent()
        {
            BlazorWebViewRenderer.BlazorInit();
        }

        /// <summary>
        /// Init the WebApplicationFactory with the given app stream resolver.
        /// Shorthand for <see cref="WebApplicationFactory.RegisterAppStreamResolver" />
        /// </summary>
        /// <param name="appStreamResolver"></param>
        public static void Init(Func<Stream> appStreamResolver)
        {
            InitComponent();
            WebApplicationFactory.Init(appStreamResolver);
        }

        public static void Init()
        {
            InitComponent();
            WebApplicationFactory.Init();
        }
    }
}

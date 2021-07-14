﻿using System.Collections.Generic;

namespace FastGithub.Scanner
{
    /// <summary>
    /// 域名
    /// </summary>
    [Options("Lookup")]
    public class GithubLookupFactoryOptions
    {
        /// <summary>
        /// 反查的域名
        /// </summary>
        public string [] Domains { get; set; } = new string[0];
    }
}

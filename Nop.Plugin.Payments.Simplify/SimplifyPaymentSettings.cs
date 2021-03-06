/*
 * 
 * Copyright (c) 2013 - 2014, MasterCard International Incorporated
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are 
 * permitted provided that the following conditions are met:
 *
 * Redistributions of source code must retain the above copyright notice, this list of 
 * conditions and the following disclaimer.
 * Redistributions in binary form must reproduce the above copyright notice, this list of 
 * conditions and the following disclaimer in the documentation and/or other materials 
 * provided with the distribution.
 * Neither the name of the MasterCard International Incorporated nor the names of its 
 * contributors may be used to endorse or promote products derived from this software 
 * without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY 
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES 
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT 
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; 
 * OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
 * IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING 
 * IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System.Text;
using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.Simplify
{
    public class SimplifyPaymentSettings : ISettings
    {
        public bool LiveMode { get; set; }
        public string SandboxPublicKey { get; set; }
        public string SandboxPrivateKey { get; set; }
        public string LivePublicKey { get; set; }
        public string LivePrivateKey { get; set; }
        public bool DebugEnabled { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
              .Append("SimplifyPaymentSettings {")
              .Append("LiveMode=").Append(LiveMode)
              .Append(", SandboxPublicKey=").Append(SandboxPublicKey)
              .Append(", SandboxPrivateKey=").Append(SimplifyPaymentHelper.FirstAndLast4(SandboxPrivateKey))
              .Append(", LivePublicKey=").Append(LivePublicKey)
              .Append(", LivePrivateKey=").Append(SimplifyPaymentHelper.FirstAndLast4(LivePrivateKey))
              .Append(", DebugEnabled=").Append(DebugEnabled)
              .Append("}").ToString();
        }
    }
}

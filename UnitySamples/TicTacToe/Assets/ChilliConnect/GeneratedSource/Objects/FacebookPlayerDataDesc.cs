//
//  This file was auto-generated using the ChilliConnect SDK Generator.
//
//  The MIT License (MIT)
//
//  Copyright (c) 2015 Tag Games Ltd
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using SdkCore;

namespace ChilliConnect 
{
	/// <summary>
	/// <para>A mutable description of a FacebookPlayerData.</para>
	///
	/// <para>This is not thread-safe and should typically only be used to create new 
	/// instances of FacebookPlayerData.</para>
	/// </summary>
	public sealed class FacebookPlayerDataDesc
	{
		/// <summary>
		/// The ChilliConnectID of the Facebook friend.
		/// </summary>
        public string ChilliConnectId { get; set; }
	
		/// <summary>
		/// The requested Custom Data Key.
		/// </summary>
        public string Key { get; set; }
	
		/// <summary>
		/// The value of the Custom Data Key.
		/// </summary>
        public MultiTypeValue Value { get; set; }
	
		/// <summary>
		/// True if the Key has Attachment data associated with it.
		/// </summary>
        public bool? HasAttachment { get; set; }
	
		/// <summary>
		/// The player's UserName.
		/// </summary>
        public string UserName { get; set; }
	
		/// <summary>
		/// The player's DisplayName.
		/// </summary>
        public string DisplayName { get; set; }
	
		/// <summary>
		/// The player's Facebook name.
		/// </summary>
        public string FacebookName { get; set; }
	
		/// <summary>
		/// The Date the Key was first created. Format: ISO8601 e.g. 2016-01-12T11:08:23.
		/// </summary>
        public DateTime DateCreated { get; set; }
	
		/// <summary>
		/// The Date the Key was last updated. Format: ISO8601 e.g. 2016-01-12T11:08:23.
		/// </summary>
        public DateTime DateModified { get; set; }

		/// <summary>
		/// Initialises a new instance with the given required properties.
		/// </summary>
		///
		/// <param name="chilliConnectId">The ChilliConnectID of the Facebook friend.</param>
		/// <param name="key">The requested Custom Data Key.</param>
		/// <param name="value">The value of the Custom Data Key.</param>
		/// <param name="facebookName">The player's Facebook name.</param>
		/// <param name="dateCreated">The Date the Key was first created. Format: ISO8601 e.g. 2016-01-12T11:08:23.</param>
		/// <param name="dateModified">The Date the Key was last updated. Format: ISO8601 e.g. 2016-01-12T11:08:23.</param>
		public FacebookPlayerDataDesc(string chilliConnectId, string key, MultiTypeValue value, string facebookName, DateTime dateCreated, DateTime dateModified)
		{
			ReleaseAssert.IsNotNull(chilliConnectId, "Chilli Connect Id cannot be null.");
			ReleaseAssert.IsNotNull(key, "Key cannot be null.");
			ReleaseAssert.IsNotNull(value, "Value cannot be null.");
			ReleaseAssert.IsNotNull(facebookName, "Facebook Name cannot be null.");
			ReleaseAssert.IsNotNull(dateCreated, "Date Created cannot be null.");
			ReleaseAssert.IsNotNull(dateModified, "Date Modified cannot be null.");
	
            ChilliConnectId = chilliConnectId;
            Key = key;
            Value = value;
            FacebookName = facebookName;
            DateCreated = dateCreated;
            DateModified = dateModified;
		}
	}
}

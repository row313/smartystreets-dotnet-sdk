﻿using System;
using System.Runtime.Serialization;
using System.Collections;

namespace SmartyStreets
{
	[DataContract]
	public class Lookup
	{
		#region [ Fields ]

		public ArrayList Result { get; set; }

		public string InputId { get; set; }

		[DataMember(Name = "street")]
		public string Street { get; set; }

		[DataMember(Name = "street2")]
		public string Street2 { get; set; }

		[DataMember(Name = "secondary")]
		public string Secondary { get; set; }

		[DataMember(Name = "city")]
		public string City { get; set; }

		[DataMember(Name = "state")]
		public string State { get; set; }

		[DataMember(Name = "zipcode")]
		public string ZipCode { get; set; }

		[DataMember(Name = "lastline")]
		public string Lastline { get; set; }

		[DataMember(Name = "addressee")]
		public string Addressee { get; set; }

		[DataMember(Name = "urbanization")]
		public string Urbanization { get; set; }

		[DataMember(Name = "candidates")]
		private int maxCandidates;

		public int MaxCandidates
		{ 
			get { return this.maxCandidates; }
			set 
			{
				if (value > 0)
					this.maxCandidates = value;
				else
					throw new ArgumentException("Max candidates must be a positive integer.");
			}
				
		}

		#endregion

		#region [ Constructors ]

		public Lookup()
		{
			this.maxCandidates = 1;
			this.Result = new ArrayList();
		}

		public Lookup(String freeformAddress) : this()
		{
			this.Street = freeformAddress;
		}

		#endregion

		public void addToResult(Candidate newCandidate) {
			this.Result.Add(newCandidate);
		}
	}
}

﻿/*
 * Copyright (c) 2019 ETH Zürich, Educational Development and Technology (LET)
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using SafeExamBrowser.Contracts.Lockdown;

namespace SafeExamBrowser.Lockdown.UnitTests
{
	[Serializable]
	internal class FeatureConfigurationStub : IFeatureConfiguration
	{
		public Guid Id { get; set; }
		public Guid GroupId { get; set; }

		public FeatureConfigurationStub()
		{
			Id = Guid.NewGuid();
		}

		public bool DisableFeature()
		{
			throw new NotImplementedException();
		}

		public bool EnableFeature()
		{
			throw new NotImplementedException();
		}

		public void Monitor()
		{
			throw new NotImplementedException();
		}

		public bool Restore()
		{
			throw new NotImplementedException();
		}
	}
}
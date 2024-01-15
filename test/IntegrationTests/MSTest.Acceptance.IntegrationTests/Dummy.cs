﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MSTest.Acceptance.IntegrationTests;

[TestGroup]
public sealed class Dummy(ITestExecutionContext testExecutionContext) : TestBase(testExecutionContext)
{
    public void A()
    {
    }
}

﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Perspex.Controls;
using Perspex.UnitTests;
using Xunit;

namespace Perspex.Markup.Xaml.UnitTests.Xaml
{
    public class BindingTests
    {
        [Fact]
        public void Binding_To_DataContext_Works()
        {
            throw new NotImplementedException();
////            using (UnitTestApplication.Start(TestServices.StyledWindow))
////            {
////                var xaml = @"
////<Window xmlns='https://github.com/perspex'
////             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
////             xmlns:local='clr-namespace:Perspex.Markup.Xaml.UnitTests.Xaml;assembly=Perspex.Markup.Xaml.UnitTests'>
////    <Button Name='button' Content='{Binding Foo}'/>
////</Window>";
////                var loader = new PerspexXamlLoader();
////                var window = (Window)loader.Load(xaml);
////                var button = window.FindControl<Button>("button");

////                button.DataContext = new { Foo = "foo" };
////                window.ApplyTemplate();

////                Assert.Equal("foo", button.Content);
////            }
        }

        [Fact]
        public void Longhand_Binding_To_DataContext_Works()
        {
            throw new NotImplementedException();
            ////            using (UnitTestApplication.Start(TestServices.StyledWindow))
            ////            {
            ////                var xaml = @"
            ////<Window xmlns='https://github.com/perspex'
            ////             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
            ////             xmlns:local='clr-namespace:Perspex.Markup.Xaml.UnitTests.Xaml;assembly=Perspex.Markup.Xaml.UnitTests'>
            ////    <Button Name='button'>
            ////        <Button.Content>
            ////            <Binding Path='Foo'/>
            ////        </Button.Content>
            ////    </Button>
            ////</Window>";
            ////                var loader = new PerspexXamlLoader();
            ////                var window = (Window)loader.Load(xaml);
            ////                var button = window.FindControl<Button>("button");

            ////                button.DataContext = new { Foo = "foo" };
            ////                window.ApplyTemplate();

            ////                Assert.Equal("foo", button.Content);
            ////            }
        }

        [Fact]
        public void Can_Bind_Control_To_Non_Control()
        {
            throw new NotImplementedException();
            ////            using (UnitTestApplication.Start(TestServices.StyledWindow))
            ////            {
            ////                var xaml = @"
            ////<Window xmlns='https://github.com/perspex'
            ////             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
            ////             xmlns:local='clr-namespace:Perspex.Markup.Xaml.UnitTests.Xaml;assembly=Perspex.Markup.Xaml.UnitTests'>
            ////    <Button Name='button' Content='Foo'>
            ////        <Button.Tag>
            ////            <local:NonControl Control='{Binding #button}'/>
            ////        </Button.Tag>
            ////    </Button>
            ////</Window>";
            ////                var loader = new PerspexXamlLoader();
            ////                var window = (Window)loader.Load(xaml);
            ////                var button = window.FindControl<Button>("button");

            ////                Assert.Same(button, ((NonControl)button.Tag).Control);
            ////            }
        }

        [Fact]
        public void Can_Bind_To_DataContext_Of_Anchor_On_Non_Control()
        {
            throw new NotImplementedException();
            ////            using (UnitTestApplication.Start(TestServices.StyledWindow))
            ////            {
            ////                var xaml = @"
            ////<Window xmlns='https://github.com/perspex'
            ////             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
            ////             xmlns:local='clr-namespace:Perspex.Markup.Xaml.UnitTests.Xaml;assembly=Perspex.Markup.Xaml.UnitTests'>
            ////    <Button Name='button'>
            ////        <Button.Tag>
            ////            <local:NonControl String='{Binding Foo}'/>
            ////        </Button.Tag>
            ////    </Button>
            ////</Window>";
            ////                var loader = new PerspexXamlLoader();
            ////                var window = (Window)loader.Load(xaml);
            ////                var button = window.FindControl<Button>("button");

            ////                button.DataContext = new { Foo = "foo" };

            ////                Assert.Equal("foo", ((NonControl)button.Tag).String);
            ////            }
        }

        [Fact]
        public void Binding_To_Window_Works()
        {
            throw new NotImplementedException();
            ////            using (UnitTestApplication.Start(TestServices.StyledWindow))
            ////            {
            ////                var xaml = @"
            ////<Window xmlns='https://github.com/perspex'
            ////             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
            ////             Title='{Binding Foo}'>
            ////</Window>";
            ////                var loader = new PerspexXamlLoader();
            ////                var window = (Window)loader.Load(xaml);

            ////                window.DataContext = new { Foo = "foo" };
            ////                window.ApplyTemplate();

            ////                Assert.Equal("foo", window.Title);
            ////            }
        }
    }
}

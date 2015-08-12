//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Source: truthy.txt
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Liquid.Ruby\writetest.rb
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liquid.NET.Constants;
using NUnit.Framework;

namespace Liquid.NET.Tests.Ruby
{
    [TestFixture]
    public class TruthyTests {

        [Test]
        [TestCase(@"{% assign myarray = ""1"" |split: "","" %}{% if myarray %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% if myarray %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% if myundefined == empty %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% if myundefined == blank %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% if nil == empty %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% if "" "" == blank %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% if ""notblank"" == blank %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign space = "" "" %}{% if space == blank %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign space = "" "" %}{% if space == empty %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% if "" "".empty? %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% if "" "".blank? %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign myvar = 123 %}{% if myvar.empty? %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% if myvar.empty? %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% if myvar.blank? %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myvar = 123 %}{% if myvar == empty %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myarray = ""1,2"" |split: "","" %}{% if myarray == blank %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myarray = """" |split: "","" %}{% if myarray == blank %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign myarray = ""1,2"" |split: "","" %}{% if myarray == empty %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myarray = """" |split: "","" %}{% if myarray == empty %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign myval = ""123"" %}{% if myval == true %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myval = ""123"" %}{% if myval == false %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myval = """" %}{% if myval == true %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myval = """" %}{% if myval == false %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myval = ""  "" %}{% if myval == true %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myval = ""  "" %}{% if myval == false %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myarray = """" |split: "","" %}{% if myarray == true %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign myarray = """" |split: "","" %}{% if myarray == false %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil == nil %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil == true %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil == empty %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil == blank %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil.empty? %}TRUTHY X{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil.blank? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign testNull = null %}{% if testNull == nil %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign testNull = null %}{% if testNull == true %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign testNull = null %}{% if testNull == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign testNull = null %}{% if testNull == empty %}TRUTHY X{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign testNull = null %}{% if testNil == blank %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign testNull = null %}{% if testNil.empty? %}TRUTHY X{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign testNull = null %}{% if testNil.blank? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue == nil %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue == true %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue == empty %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue == blank %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue.empty? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue.blank? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse == nil %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse == true %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse == false %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse == empty %}TRUTHY X{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse == blank %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse.empty? %}TRUTHY X{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse.blank? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents == nil %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents == true %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents == empty %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents == blank %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents.empty? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents.blank? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty == nil %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty == true %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty == empty %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty == blank %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty.empty? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty.blank? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace == nil %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace == true %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace == empty %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace == blank %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace.empty? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace.blank? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]

        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents == nil %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents == true %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents == empty %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents == blank %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]

        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents.empty? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents.blank? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]

        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty == nil %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty == true %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty == false %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty == empty %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty == blank %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"TRUTHY")]
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty.empty? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")] // Liquid.Net Error
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty.blank? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")] // Liquid.Net Error
        public void It_Should_Match_Ruby_Output(String input, String assigns, String expected) {

            // Arrange
            ITemplateContext ctx = new TemplateContext().WithAllFilters();
            
            foreach (var tuple in DictionaryFactory.CreateStringMapFromJson(assigns))
            {
                ctx.DefineLocalVariable(tuple.Item1, tuple.Item2);
            }

            
            var template = LiquidTemplate.Create(input);
            
            // Act
            String result = template.Render(ctx);
        
            // Assert
            Assert.That(result.Trim(), Is.EqualTo(expected));
        }

        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace == present %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty.present? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringEmpty = """" %}{% if stringEmpty == present %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents.present? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringWithContents = ""Hello World"" %}{% if stringWithContents == present %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse.present? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolFalse = false %}{% if boolFalse == present %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue.present? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign boolTrue = true %}{% if boolTrue == present %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign testNull = null %}{% if testNil.present? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign testNull = null %}{% if testNil == present %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"TRUTHY X")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil.present? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% if myvar.present? %}TRUTHY{% else %}NOT TRUTHY{% endif %}", @"", @"NOT TRUTHY")]
        [TestCase(@"{% assign testNil = nil %}{% if testNil == present %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"TRUTHY X")]
        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents.present? %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign stringWhitespace = ""     "" %}{% if stringWhitespace.present? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign intWithContents = 123 %}{% if intWithContents == present %}TRUTHY{% else %}FALSY X{% endif %}", @"", @"FALSY X")]
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty == present %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        [TestCase(@"{% assign arrayEmpty = """" | split: "","" %}{% if arrayEmpty.present? %}TRUTHY X{% else %}FALSY{% endif %}", @"", @"FALSY")]
        public void It_Should_Match_Ruby_Output_2(String input, String assigns, String expected)
        {

            // Arrange
            ITemplateContext ctx = new TemplateContext().WithAllFilters();

            foreach (var tuple in DictionaryFactory.CreateStringMapFromJson(assigns))
            {
                ctx.DefineLocalVariable(tuple.Item1, tuple.Item2);
            }


            var template = LiquidTemplate.Create(input);

            // Act
            String result = template.Render(ctx);

            // Assert
            Assert.That(result.Trim(), Is.EqualTo(expected));
        }
    }
}

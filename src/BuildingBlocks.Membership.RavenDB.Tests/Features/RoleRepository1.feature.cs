﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.1.84
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BuildingBlocks.Membership.RavenDB.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.1.84")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("хранилище ролей")]
    [NUnit.Framework.CategoryAttribute("ravendb")]
    public partial class ХранилищеРолейFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RoleRepository.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "хранилище ролей", "", ProgrammingLanguage.CSharp, new string[] {
                        "ravendb"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table1.AddRow(new string[] {
                        "Врач"});
            table1.AddRow(new string[] {
                        "Медсестра"});
            table1.AddRow(new string[] {
                        "Админ"});
#line 6
testRunner.Given("существуют роли", ((string)(null)), table1, "Пусть ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("проверка существования роли")]
        [NUnit.Framework.TestCaseAttribute("Админ", "существует", null)]
        [NUnit.Framework.TestCaseAttribute("Врач", "существует", null)]
        [NUnit.Framework.TestCaseAttribute("Медсестра", "существует", null)]
        [NUnit.Framework.TestCaseAttribute("Автомеханик", "не существует", null)]
        public virtual void ПроверкаСуществованияРоли(string роль, string существует, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("проверка существования роли", exampleTags);
#line 12
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 13
 testRunner.When(string.Format("проверяют что роль \"{0}\" существует", роль), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 14
 testRunner.Then(string.Format("результат проверки признает что роль \"{0}\"", существует), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("получение списка всех ролей отсортированного по названию")]
        public virtual void ПолучениеСпискаВсехРолейОтсортированногоПоНазванию()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("получение списка всех ролей отсортированного по названию", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 23
 testRunner.When("получают список ролей", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table2.AddRow(new string[] {
                        "Админ"});
            table2.AddRow(new string[] {
                        "Врач"});
            table2.AddRow(new string[] {
                        "Медсестра"});
#line 24
 testRunner.Then("возвращается следующий список ролей", ((string)(null)), table2, "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("список ролей по имени")]
        public virtual void СписокРолейПоИмени()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("список ролей по имени", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table3.AddRow(new string[] {
                        "Админ"});
            table3.AddRow(new string[] {
                        "Медсестра"});
            table3.AddRow(new string[] {
                        "Медбрат"});
#line 31
 testRunner.When("получают список ролей содержащих имена", ((string)(null)), table3, "Когда ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table4.AddRow(new string[] {
                        "Админ"});
            table4.AddRow(new string[] {
                        "Медсестра"});
#line 36
 testRunner.Then("возвращается следующий список ролей", ((string)(null)), table4, "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("создание роли")]
        public virtual void СозданиеРоли()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("создание роли", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 42
 testRunner.When("создают роль \"Медбрат\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 43
 testRunner.Then("существует \"4\" роли", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("создание роли с привязкой к пользователям")]
        public virtual void СозданиеРолиСПривязкойКПользователям()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("создание роли с привязкой к пользователям", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table5.AddRow(new string[] {
                        "Иванов"});
            table5.AddRow(new string[] {
                        "Петров"});
            table5.AddRow(new string[] {
                        "Сидоров"});
#line 46
 testRunner.Given("существуют пользователи", ((string)(null)), table5, "Пусть ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table6.AddRow(new string[] {
                        "Иванов"});
            table6.AddRow(new string[] {
                        "Петров"});
#line 51
 testRunner.When("создают роль \"Медбрат\" со списком пользователей", ((string)(null)), table6, "Когда ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table7.AddRow(new string[] {
                        "Иванов"});
            table7.AddRow(new string[] {
                        "Петров"});
#line 55
 testRunner.Then("существует роль \"Медбрат\" со списком пользователей", ((string)(null)), table7, "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("удаление роли")]
        public virtual void УдалениеРоли()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("удаление роли", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 61
 testRunner.When("удаляют роль \"Медсестра\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 62
 testRunner.Then("существует \"2\" роли", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("удаление роли с удалением из списка ролей пользователей")]
        public virtual void УдалениеРолиСУдалениемИзСпискаРолейПользователей()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("удаление роли с удалением из списка ролей пользователей", ((string[])(null)));
#line 64
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table8.AddRow(new string[] {
                        "Иванов"});
            table8.AddRow(new string[] {
                        "Петров"});
            table8.AddRow(new string[] {
                        "Сидоров"});
#line 65
 testRunner.Given("существуют пользователи", ((string)(null)), table8, "Пусть ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table9.AddRow(new string[] {
                        "Иванов"});
            table9.AddRow(new string[] {
                        "Петров"});
#line 70
 testRunner.When("создают роль \"Медбрат\" со списком пользователей", ((string)(null)), table9, "Когда ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "имя"});
            table10.AddRow(new string[] {
                        "Иванов"});
            table10.AddRow(new string[] {
                        "Петров"});
#line 74
 testRunner.And("создают роль \"Уборщик\" со списком пользователей", ((string)(null)), table10, "И ");
#line 78
 testRunner.And("удаляют роль \"Медбрат\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "роль"});
            table11.AddRow(new string[] {
                        "Уборщик"});
#line 79
 testRunner.Then("существует пользователь \"Иванов\" со списком ролей", ((string)(null)), table11, "Тогда ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "роль"});
            table12.AddRow(new string[] {
                        "Уборщик"});
#line 82
 testRunner.Then("существует пользователь \"Петров\" со списком ролей", ((string)(null)), table12, "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
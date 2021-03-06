//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.17.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Cheatsheet.Core
{
	/// <summary>Standard Page</summary>
	[PublishedModel("standardPage")]
	public partial class StandardPage : PublishedContentModel, IContentComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const string ModelTypeAlias = "standardPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<StandardPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public StandardPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Elements
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("elements")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement> Elements => global::Umbraco.Cheatsheet.Core.ContentComposition.GetElements(this);

		///<summary>
		/// Notes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("notes")]
		public virtual string Notes => global::Umbraco.Cheatsheet.Core.ContentComposition.GetNotes(this);
	}
}

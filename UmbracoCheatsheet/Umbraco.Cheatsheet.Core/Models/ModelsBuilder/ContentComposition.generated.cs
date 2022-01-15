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
	// Mixin Content Type with alias "contentComposition"
	/// <summary>Content Composition</summary>
	public partial interface IContentComposition : IPublishedContent
	{
		/// <summary>Elements</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement> Elements { get; }
	}

	/// <summary>Content Composition</summary>
	[PublishedModel("contentComposition")]
	public partial class ContentComposition : PublishedContentModel, IContentComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const string ModelTypeAlias = "contentComposition";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentComposition, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentComposition(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Elements
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("elements")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement> Elements => GetElements(this);

		/// <summary>Static getter for Elements</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement> GetElements(IContentComposition that) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedElement>>("elements");
	}
}

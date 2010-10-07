namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Html : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Html()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Html), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.Html(@__env);
			}
		}
		protected Html(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ImageGetter 
		{
			global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0);
		}

		public partial class ImageGetter_
		{
			public static global::java.lang.Class _class
			{
				get { return __ImageGetter.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ImageGetter : java.lang.Object, ImageGetter
		{
			internal static global::java.lang.Class staticClass;
			static __ImageGetter()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Html.__ImageGetter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.Html.__ImageGetter(@__env);
				}
			}
			internal __ImageGetter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getDrawable7406;
			 global::android.graphics.drawable.Drawable android.text.Html.ImageGetter.getDrawable(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Html.__ImageGetter._getDrawable7406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Html.__ImageGetter.staticClass, global::android.text.Html.__ImageGetter._getDrawable7406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.Html.__ImageGetter.staticClass = @__class;
				global::android.text.Html.__ImageGetter._getDrawable7406 = @__env.GetMethodID(global::android.text.Html.__ImageGetter.staticClass, "android.text.Html.ImageGetter.getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface TagHandler 
		{
			void handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3);
		}

		public partial class TagHandler_
		{
			public static global::java.lang.Class _class
			{
				get { return __TagHandler.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __TagHandler : java.lang.Object, TagHandler
		{
			internal static global::java.lang.Class staticClass;
			static __TagHandler()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Html.__TagHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.Html.__TagHandler(@__env);
				}
			}
			internal __TagHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _handleTag7407;
			 void android.text.Html.TagHandler.handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.text.Html.__TagHandler._handleTag7407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.text.Html.__TagHandler.staticClass, global::android.text.Html.__TagHandler._handleTag7407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.Html.__TagHandler.staticClass = @__class;
				global::android.text.Html.__TagHandler._handleTag7407 = @__env.GetMethodID(global::android.text.Html.__TagHandler.staticClass, "android.text.Html.TagHandler.handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromHtml7408;
		public static global::android.text.Spanned fromHtml(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spanned>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Html.staticClass, global::android.text.Html._fromHtml7408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromHtml7409;
		public static global::android.text.Spanned fromHtml(java.lang.String arg0, android.text.Html.ImageGetter arg1, android.text.Html.TagHandler arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spanned>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Html.staticClass, global::android.text.Html._fromHtml7409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toHtml7410;
		public static global::java.lang.String toHtml(android.text.Spanned arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Html.staticClass, global::android.text.Html._toHtml7410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.Html.staticClass = @__class;
			global::android.text.Html._fromHtml7408 = @__env.GetStaticMethodID(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;)Landroid/text/Spanned;");
			global::android.text.Html._fromHtml7409 = @__env.GetStaticMethodID(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;Landroid/text/Html$ImageGetter;Landroid/text/Html$TagHandler;)Landroid/text/Spanned;");
			global::android.text.Html._toHtml7410 = @__env.GetStaticMethodID(global::android.text.Html.staticClass, "toHtml", "(Landroid/text/Spanned;)Ljava/lang/String;");
		}
	}
}

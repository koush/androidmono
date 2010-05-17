namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Html : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Html() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Html), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			android.graphics.drawable.Drawable getDrawable(java.lang.String arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface TagHandler 
		{ 
			void handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromHtml6460; 
		public static android.text.Spanned fromHtml(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spanned>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Html.staticClass, _fromHtml6460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromHtml6461; 
		public static android.text.Spanned fromHtml(java.lang.String arg0, android.text.Html.ImageGetter arg1, android.text.Html.TagHandler arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Spanned>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Html.staticClass, _fromHtml6461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toHtml6462; 
		public static java.lang.String toHtml(android.text.Spanned arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Html.staticClass, _toHtml6462, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.Html.staticClass = @__class; 
			global::android.text.Html._fromHtml6460 = @__env.GetStaticMethodID(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;)Landroid/text/Spanned;"); 
			global::android.text.Html._fromHtml6461 = @__env.GetStaticMethodID(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;Landroid/text/Html$ImageGetter;Landroid/text/Html$TagHandler;)Landroid/text/Spanned;"); 
			global::android.text.Html._toHtml6462 = @__env.GetStaticMethodID(global::android.text.Html.staticClass, "toHtml", "(Landroid/text/Spanned;)Ljava/lang/String;"); 
		} 
	} 
} 

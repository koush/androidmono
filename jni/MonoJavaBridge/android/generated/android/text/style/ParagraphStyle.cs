namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ParagraphStyle 
	{
	}

	public partial class ParagraphStyle_
	{
		public static global::java.lang.Class _class
		{
			get { return __ParagraphStyle.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ParagraphStyle : java.lang.Object, ParagraphStyle
	{
		internal static global::java.lang.Class staticClass;
		static __ParagraphStyle()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.__ParagraphStyle), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.__ParagraphStyle(@__env);
			}
		}
		internal __ParagraphStyle(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.__ParagraphStyle.staticClass = @__class;
		}
	}
}

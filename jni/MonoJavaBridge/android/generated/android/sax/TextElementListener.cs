namespace android.sax
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface TextElementListener : StartElementListener, EndTextElementListener
	{
	}

	public partial class TextElementListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __TextElementListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __TextElementListener : java.lang.Object, TextElementListener
	{
		internal static global::java.lang.Class staticClass;
		static __TextElementListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.sax.__TextElementListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.sax.__TextElementListener(@__env);
			}
		}
		internal __TextElementListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _start6981;
		 void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.__TextElementListener._start6981, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.__TextElementListener.staticClass, global::android.sax.__TextElementListener._start6981, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _end6982;
		 void android.sax.EndTextElementListener.end(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.__TextElementListener._end6982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.__TextElementListener.staticClass, global::android.sax.__TextElementListener._end6982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.sax.__TextElementListener.staticClass = @__class;
			global::android.sax.__TextElementListener._start6981 = @__env.GetMethodID(global::android.sax.__TextElementListener.staticClass, "android.sax.StartElementListener.start", "(Lorg/xml/sax/Attributes;)V");
			global::android.sax.__TextElementListener._end6982 = @__env.GetMethodID(global::android.sax.__TextElementListener.staticClass, "android.sax.EndTextElementListener.end", "(Ljava/lang/String;)V");
		}
	}
}

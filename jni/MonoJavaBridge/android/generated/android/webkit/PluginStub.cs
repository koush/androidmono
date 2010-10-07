namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface PluginStub 
	{
		global::android.view.View getEmbeddedView(int arg0, android.content.Context arg1);
		global::android.view.View getFullScreenView(int arg0, android.content.Context arg1);
	}

	public partial class PluginStub_
	{
		public static global::java.lang.Class _class
		{
			get { return __PluginStub.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __PluginStub : java.lang.Object, PluginStub
	{
		internal static global::java.lang.Class staticClass;
		static __PluginStub()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.__PluginStub), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.__PluginStub(@__env);
			}
		}
		internal __PluginStub(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmbeddedView10011;
		 global::android.view.View android.webkit.PluginStub.getEmbeddedView(int arg0, android.content.Context arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.__PluginStub._getEmbeddedView10011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.__PluginStub.staticClass, global::android.webkit.__PluginStub._getEmbeddedView10011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFullScreenView10012;
		 global::android.view.View android.webkit.PluginStub.getFullScreenView(int arg0, android.content.Context arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.__PluginStub._getFullScreenView10012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.__PluginStub.staticClass, global::android.webkit.__PluginStub._getFullScreenView10012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.__PluginStub.staticClass = @__class;
			global::android.webkit.__PluginStub._getEmbeddedView10011 = @__env.GetMethodID(global::android.webkit.__PluginStub.staticClass, "android.webkit.PluginStub.getEmbeddedView", "(ILandroid/content/Context;)Landroid/view/View;");
			global::android.webkit.__PluginStub._getFullScreenView10012 = @__env.GetMethodID(global::android.webkit.__PluginStub.staticClass, "android.webkit.PluginStub.getFullScreenView", "(ILandroid/content/Context;)Landroid/view/View;");
		}
	}
}

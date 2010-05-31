namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class WebViewDatabase : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static WebViewDatabase()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebViewDatabase), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.WebViewDatabase(@__env);
			}
		}
		protected WebViewDatabase(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance9648;
		public static global::android.webkit.WebViewDatabase getInstance(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebViewDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._getInstance9648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearFormData9649;
		public virtual void clearFormData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebViewDatabase._clearFormData9649);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearFormData9649);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasUsernamePassword9650;
		public virtual bool hasUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebViewDatabase._hasUsernamePassword9650);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasUsernamePassword9650);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearUsernamePassword9651;
		public virtual void clearUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebViewDatabase._clearUsernamePassword9651);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearUsernamePassword9651);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasHttpAuthUsernamePassword9652;
		public virtual bool hasHttpAuthUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword9652);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword9652);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearHttpAuthUsernamePassword9653;
		public virtual void clearHttpAuthUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword9653);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword9653);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFormData9654;
		public virtual bool hasFormData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebViewDatabase._hasFormData9654);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasFormData9654);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebViewDatabase.staticClass = @__class;
			global::android.webkit.WebViewDatabase._getInstance9648 = @__env.GetStaticMethodID(global::android.webkit.WebViewDatabase.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;");
			global::android.webkit.WebViewDatabase._clearFormData9649 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearFormData", "()V");
			global::android.webkit.WebViewDatabase._hasUsernamePassword9650 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearUsernamePassword9651 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword9652 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasHttpAuthUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword9653 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearHttpAuthUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasFormData9654 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasFormData", "()Z");
		}
	}
}

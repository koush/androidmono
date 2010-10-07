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
		internal static global::net.sf.jni4net.jni.MethodId _getInstance10341;
		public static global::android.webkit.WebViewDatabase getInstance(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebViewDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._getInstance10341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearFormData10342;
		public virtual void clearFormData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebViewDatabase._clearFormData10342);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearFormData10342);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasUsernamePassword10343;
		public virtual bool hasUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebViewDatabase._hasUsernamePassword10343);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasUsernamePassword10343);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearUsernamePassword10344;
		public virtual void clearUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebViewDatabase._clearUsernamePassword10344);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearUsernamePassword10344);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasHttpAuthUsernamePassword10345;
		public virtual bool hasHttpAuthUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword10345);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword10345);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearHttpAuthUsernamePassword10346;
		public virtual void clearHttpAuthUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword10346);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword10346);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFormData10347;
		public virtual bool hasFormData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebViewDatabase._hasFormData10347);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasFormData10347);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.WebViewDatabase.staticClass = @__class;
			global::android.webkit.WebViewDatabase._getInstance10341 = @__env.GetStaticMethodID(global::android.webkit.WebViewDatabase.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;");
			global::android.webkit.WebViewDatabase._clearFormData10342 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearFormData", "()V");
			global::android.webkit.WebViewDatabase._hasUsernamePassword10343 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearUsernamePassword10344 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword10345 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasHttpAuthUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword10346 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearHttpAuthUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasFormData10347 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasFormData", "()Z");
		}
	}
}

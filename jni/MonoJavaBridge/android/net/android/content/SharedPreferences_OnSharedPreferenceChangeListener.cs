namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SharedPreferences_OnSharedPreferenceChangeListener 
	{ 
		void onSharedPreferenceChanged(android.content.SharedPreferences arg0, java.lang.String arg1); 
	} 

	public partial class SharedPreferences_OnSharedPreferenceChangeListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SharedPreferences_OnSharedPreferenceChangeListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SharedPreferences_OnSharedPreferenceChangeListener : java.lang.Object, SharedPreferences_OnSharedPreferenceChangeListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SharedPreferences_OnSharedPreferenceChangeListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.__SharedPreferences_OnSharedPreferenceChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__SharedPreferences_OnSharedPreferenceChangeListener(@__env); 
			} 
		} 
		internal __SharedPreferences_OnSharedPreferenceChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSharedPreferenceChanged1501; 
		 void android.content.SharedPreferences_OnSharedPreferenceChangeListener.onSharedPreferenceChanged(android.content.SharedPreferences arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_OnSharedPreferenceChangeListener)) 
				@__env.CallVoidMethod(this, _onSharedPreferenceChanged1501, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.__SharedPreferences_OnSharedPreferenceChangeListener.staticClass, _onSharedPreferenceChanged1501, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__SharedPreferences_OnSharedPreferenceChangeListener.staticClass = @__class; 
			global::android.content.__SharedPreferences_OnSharedPreferenceChangeListener._onSharedPreferenceChanged1501 = @__env.GetMethodID(global::android.content.__SharedPreferences_OnSharedPreferenceChangeListener.staticClass, "android.content.SharedPreferences_OnSharedPreferenceChangeListener.onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V"); 
		} 
	} 
} 

namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface SharedPreferences 
	{
		bool getBoolean(java.lang.String arg0, bool arg1);
		int getInt(java.lang.String arg0, int arg1);
		long getLong(java.lang.String arg0, long arg1);
		float getFloat(java.lang.String arg0, float arg1);
		bool contains(java.lang.String arg0);
		global::java.lang.String getString(java.lang.String arg0, java.lang.String arg1);
		global::android.content.SharedPreferences_Editor edit();
		global::java.util.Map getAll();
		void registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0);
		void unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0);
	}

	public partial class SharedPreferences_
	{
		public static global::java.lang.Class _class
		{
			get { return __SharedPreferences.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __SharedPreferences : java.lang.Object, SharedPreferences
	{
		internal static global::java.lang.Class staticClass;
		static __SharedPreferences()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__SharedPreferences), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.__SharedPreferences(@__env);
			}
		}
		internal __SharedPreferences(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean1502;
		 bool android.content.SharedPreferences.getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.__SharedPreferences._getBoolean1502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._getBoolean1502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt1503;
		 int android.content.SharedPreferences.getInt(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.__SharedPreferences._getInt1503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._getInt1503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong1504;
		 long android.content.SharedPreferences.getLong(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.content.__SharedPreferences._getLong1504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._getLong1504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat1505;
		 float android.content.SharedPreferences.getFloat(java.lang.String arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.content.__SharedPreferences._getFloat1505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._getFloat1505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains1506;
		 bool android.content.SharedPreferences.contains(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.__SharedPreferences._contains1506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._contains1506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString1507;
		 global::java.lang.String android.content.SharedPreferences.getString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.__SharedPreferences._getString1507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._getString1507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _edit1508;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences.edit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.__SharedPreferences._edit1508));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._edit1508));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAll1509;
		 global::java.util.Map android.content.SharedPreferences.getAll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.__SharedPreferences._getAll1509));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._getAll1509));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerOnSharedPreferenceChangeListener1510;
		 void android.content.SharedPreferences.registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__SharedPreferences._registerOnSharedPreferenceChangeListener1510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._registerOnSharedPreferenceChangeListener1510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterOnSharedPreferenceChangeListener1511;
		 void android.content.SharedPreferences.unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__SharedPreferences._unregisterOnSharedPreferenceChangeListener1511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__SharedPreferences.staticClass, global::android.content.__SharedPreferences._unregisterOnSharedPreferenceChangeListener1511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.__SharedPreferences.staticClass = @__class;
			global::android.content.__SharedPreferences._getBoolean1502 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.getBoolean", "(Ljava/lang/String;Z)Z");
			global::android.content.__SharedPreferences._getInt1503 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.getInt", "(Ljava/lang/String;I)I");
			global::android.content.__SharedPreferences._getLong1504 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.getLong", "(Ljava/lang/String;J)J");
			global::android.content.__SharedPreferences._getFloat1505 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.getFloat", "(Ljava/lang/String;F)F");
			global::android.content.__SharedPreferences._contains1506 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.contains", "(Ljava/lang/String;)Z");
			global::android.content.__SharedPreferences._getString1507 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.__SharedPreferences._edit1508 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.edit", "()Landroid/content/SharedPreferences$Editor;");
			global::android.content.__SharedPreferences._getAll1509 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.getAll", "()Ljava/util/Map;");
			global::android.content.__SharedPreferences._registerOnSharedPreferenceChangeListener1510 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V");
			global::android.content.__SharedPreferences._unregisterOnSharedPreferenceChangeListener1511 = @__env.GetMethodID(global::android.content.__SharedPreferences.staticClass, "android.content.SharedPreferences.unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V");
		}
	}
}

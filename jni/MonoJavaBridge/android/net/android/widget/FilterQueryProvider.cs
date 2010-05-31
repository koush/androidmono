namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface FilterQueryProvider 
	{ 
		global::android.database.Cursor runQuery(java.lang.CharSequence arg0); 
	} 

	public partial class FilterQueryProvider_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __FilterQueryProvider.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __FilterQueryProvider : java.lang.Object, FilterQueryProvider
	{ 
		internal static global::java.lang.Class staticClass; 
		static __FilterQueryProvider() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__FilterQueryProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.__FilterQueryProvider(@__env); 
			} 
		} 
		internal __FilterQueryProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runQuery10203; 
		 global::android.database.Cursor android.widget.FilterQueryProvider.runQuery(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__FilterQueryProvider._runQuery10203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__FilterQueryProvider.staticClass, global::android.widget.__FilterQueryProvider._runQuery10203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.__FilterQueryProvider.staticClass = @__class; 
			global::android.widget.__FilterQueryProvider._runQuery10203 = @__env.GetMethodID(global::android.widget.__FilterQueryProvider.staticClass, "android.widget.FilterQueryProvider.runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;"); 
		} 
	} 
} 
